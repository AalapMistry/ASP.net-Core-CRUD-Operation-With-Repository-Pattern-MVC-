using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Category
{
    public interface ICategoryService
    {
        IList<CategoryModel> GetAllCategorys();

        void AddCategory(CategoryModel Category);

        void UpdateCategory(CategoryModel Category);

        CategoryModel GetCategoryData(int? id);

        void DeleteCategory(int? id);
    }
}
