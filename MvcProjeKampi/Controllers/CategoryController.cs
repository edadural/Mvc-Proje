using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        CategoryManager cm = new CategoryManager(new EfCategoryDal());

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
            var categoryValues = cm.GetList();
            return View(categoryValues);
        }

        [HttpGet] // sayfa yuklendigi zaman calisan attribute

        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost] // sayfadaki bisey post edildigi zaman calisan attribute
        public ActionResult AddCategory(Category p)
        {
            // cm.CategoryAddBL(p);
            return RedirectToAction("GetCategoryList");
        }
    }
}