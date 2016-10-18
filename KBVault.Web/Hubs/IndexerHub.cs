﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KBVault.Dal;
using KBVault.Dal.Repository;
using KBVault.Web.Helpers;
using Microsoft.AspNet.SignalR;

namespace KBVault.Web.Hubs
{
    public class IndexerHub : Hub
    {
        public ICategoryRepository CategoryRepository { get; set; }
        public IArticleRepository ArticleRepository { get; set; }

        public void RebuildIndexes()
        {
            var categories = CategoryRepository.GetAllCategories();
            int totalCategories = categories.Count();
            int indexingCategory = 1;
            foreach (var cat in categories)
            {
                Clients.All.updateProgress(indexingCategory, totalCategories, cat.Name, "-");
                var articles = CategoryRepository.GetArticles(cat.Id);
                foreach (var article in articles)
                {
                    Clients.All.updateProgress(indexingCategory, totalCategories, cat.Name, article.Title);
                    foreach (var attachment in article.Attachments)
                    {
                        try
                        {
                            KbVaultLuceneHelper.RemoveAttachmentFromIndex(attachment);
                            KbVaultLuceneHelper.AddAttachmentToIndex(attachment);
                        }
                        catch (Exception ex)
                        {
                            //Eat it :d
                        }
                    }                    
                    KbVaultLuceneHelper.AddArticleToIndex(article);                    
                }
                indexingCategory++;
            }
            Clients.All.updateProgress("", "", "", "Finished indexing");
        }
    }
}