using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using Service.Category;

namespace AalapCRUDAutomated.Controllers
{
    [Route("[controller]")]
    public class CategoryController : Controller
    {
        public ICategoryService _iCategoryService;


        public CategoryController(ICategoryService iCategoryService)
        {
            _iCategoryService = iCategoryService;
        }
        // GET: Category
        [HttpGet("[action]")]
        public ActionResult Index()
        {
            List<CategoryModel> CategoryList = new List<CategoryModel>();
            CategoryList = _iCategoryService.GetAllCategorys().ToList();
            return View(CategoryList);
        }

        // GET: Category/Details/5
        [HttpGet("[action]")]
        public ActionResult Category_Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            CategoryModel Category = _iCategoryService.GetCategoryData(id);

            if (Category == null)
            {
                return NotFound();
            }
            return View(Category);
        }

        // GET: Category/Create
        [HttpGet("[action]")]
        public ActionResult Create_Category()
        {
            return View();
        }

        // POST: Category/Create
        [ValidateAntiForgeryToken]
        [HttpPost("[action]")]
        public ActionResult Create_Category([Bind] CategoryModel Category)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    _iCategoryService.AddCategory(Category);
                    return RedirectToAction("Index", "Category");
                }
                return View(_iCategoryService);
            }
            catch
            {
                return View();
            }
        }

        // GET: Category/Edit/5
        [HttpGet("[action]")]
        public ActionResult Edit_Category(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            CategoryModel Category = _iCategoryService.GetCategoryData(id);

            if (Category == null)
            {
                return NotFound();
            }
            return View(Category);
        }

        // POST: Category/Edit/5
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit_Category(int id, CategoryModel Category)
        {
            if (id != Category.CategoryID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _iCategoryService.UpdateCategory(Category);
                return RedirectToAction("Index");
            }
            return View(_iCategoryService);

        }

        // GET: Category/Delete/5
        [HttpGet("[action]")]
        public ActionResult Delete_Category(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            CategoryModel Category = _iCategoryService.GetCategoryData(id);

            if (Category == null)
            {
                return NotFound();
            }
            return View(Category);
        }

        // POST: Category/Delete/5
        [HttpPost("[action]")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete_Category(int id, CategoryModel Category)
        {
            try
            {
                // TODO: Add delete logic here
                _iCategoryService.DeleteCategory(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}