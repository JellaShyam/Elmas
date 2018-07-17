using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using BusinessEntities;
using Elmas.MVCUI.Models;
using Newtonsoft.Json;

namespace Elmas.MVCUI.Controllers
{
    [Authorize]
    public class SiteController : Controller
    {
        //
        // GET: /SiteEvent/
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetUpsList()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetStringAsync(ProjectGlobals.ApplicationDomain + "/api/SiteAPI/GetUpsList").Result;
                return Json(response, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Home", "Index"));
            }
        }
    }
}