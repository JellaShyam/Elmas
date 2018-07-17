using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using BusinessEntities;
using Elmas.MVCUI.Controllers;
using Elmas.MVCUI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Elmas.MVCUI.Tests.Controllers
{

    [TestClass]
    public class LatestSiteEventsControllerTest
    {

        public LatestSiteEventsControllerTest()
        {
            ProjectGlobals.ApplicationDomain = "http://vtrace.in/ElmasApiRestfull";
        }
        [TestMethod]
        public void LatestEvents()
        {
            LatestSiteEventsController controller = new LatestSiteEventsController();
            ViewResult Result = controller.DisplayAll() as ViewResult;
            Assert.IsNotNull(Result);
        }

        [TestMethod]
        public void SiteInfoById()
        {
            string id = "ELMASUPS01";
            var controller = new LatestSiteEventsController();
            var result = controller.GetSiteInfo(id) as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetAllLatestEvents()
        {
            var controller = new LatestSiteEventsController();
            var result = controller.GetAllLatestEvents() as JsonResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Index()
        {
            LatestSiteEventsController controller = new LatestSiteEventsController();
            var result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Index1()
        {
            var info = new SortingPagingInfo
            {
                SortField = "SiteEvent.EventDateTime",
                SortDirection = "descending",
                PageSize = 1,
            };

            var ctrl = new LatestSiteEventsController();
            var result = ctrl.Index(info, "10001") as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}
