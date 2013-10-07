using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeApplication.Controllers;
using EmployeeApplication.ViewModel;
using GalleryManager.ORM;

namespace GalleryManager.UnitTest
{
    [TestClass]
    public class ManageGalleryTestSuite
    {
        [TestMethod]
        public void CanAddNewGalleryToContext()
        {
            BFGGalleryContentViewModel vmodel = new BFGGalleryContentViewModel();
            vmodel.Model = new GalleryMasterDto { DisplayName = "testDispaly", Name = "testName" };
           GalleryManager.ORM.EntitiesModel1 ct = new EntitiesModel1();
            var newEntity = new GalleryMaster { Name = vmodel.Model.Name, DisplayName = vmodel.Model.DisplayName };
            ct.Add(newEntity);
            ct.SaveChanges();

            Assert.AreEqual(true, newEntity.ID>0);

        } 
    }
}
