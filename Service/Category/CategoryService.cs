using Models;
using Repository.Category;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Category
{
    public class CategoryService
    {
        private readonly ICategoryRepo ICategoryrepo;

        public CategoryService(ICategoryRepo ICategoryre)
        {
            ICategoryrepo = ICategoryre;
        }
        //To View all Categorys details    
        public IList<CategoryModel> GetAllCategorys()
        {
            IList<CategoryModel> list = new List<CategoryModel>();
            try
            {
                list = ICategoryrepo.GetAllCategorys();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return list;
        }
        //To Add new Category record    
        public void AddCategory(CategoryModel Category)
        {
            try
            {
                ICategoryrepo.AddCategory(Category);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
        //To Update the records of a particluar Category  
        public void UpdateCategory(CategoryModel Category)
        {
            try
            {
                ICategoryrepo.UpdateCategory(Category);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        //Get the details of a particular Category  
        public CategoryModel GetCategoryData(int? id)
        {
            CategoryModel objCategory = new CategoryModel();
            try
            {
                objCategory = ICategoryrepo.GetCategoryData(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return objCategory;
        }
        //To Delete the record on a particular Category  
        public void DeleteCategory(int? id)
        {
            try
            {
                ICategoryrepo.DeleteCategory(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
