using KBVault.Dal;
using KBVault.Web.Models;

namespace KBVault.Web.Business.Categories
{
    public class CategoryFactory : ICategoryFactory
    {
        public Category CreateCategory(string name, bool isHot, string sefName, long author, int? parent)
        {
            return new Category
            {
                Name = name,
                Author = author,
                IsHot = isHot,
                SefName = sefName,
                Parent = parent
            };
        }

        public CategoryViewModel CreateCategoryViewModel(Category cat)
        {
            CategoryViewModel categoryModel = new CategoryViewModel
            {
                Id = cat.Id,
                IsHot = cat.IsHot,
                ParentId = cat.Parent.HasValue ? (int) cat.Parent : -1,
                Name = cat.Name,
                SefName = cat.SefName
            };
            return categoryModel;
        }
    }
}