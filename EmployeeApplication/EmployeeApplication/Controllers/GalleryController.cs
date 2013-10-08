using EmployeeApplication.Models;
using EmployeeApplication.ViewModel;
using GalleryManager.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace EmployeeApplication.Controllers
{
    public class GalleryController : Controller
    {
        //
        // GET: /Employee/

        public ActionResult Index()
        {
          //  BFGLoginViewModel vmodel = new BFGLoginViewModel();
            BFGGalleryContentViewModel vmodel = new BFGGalleryContentViewModel();
            vmodel.Model = new GalleryMasterDto();
            return View("AddGallery");
        }

        [HttpPost]
        public ActionResult Index(BFGGalleryContentViewModel vModel)
        {
            GalleryManager.ORM.EntitiesModel1 ct = new EntitiesModel1();
            ct.Add(new GalleryMaster { Name = vModel.Model.Name, DisplayName = vModel.Model.DisplayName });
            ct.SaveChanges();
          //  ViewBag.Message = vModel.LogIn();
            return View("AddGallery");
        }

        //
        // GET: /Employee/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult GetAll()
        {
            
            return View("GalleryGrid");
        }

        public JsonResult GetAllGalleries()
        {
            GalleryManager.ORM.EntitiesModel1 ct = new EntitiesModel1();
           var result =  ct.GalleryMasters.ToList();
            return Json(result,JsonRequestBehavior.AllowGet);
        }

        //
        // GET: /Employee/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Employee/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Employee/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Employee/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Employee/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Employee/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
