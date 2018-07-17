using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;
using BusinessEntities;
using Elmas.Logger;
using Elmas.MVCUI.Models;
using Newtonsoft.Json;

namespace Elmas.MVCUI.Controllers
{
    [Authorize]
    public class LatestSiteEventsController : Controller
    {
        #region ErrorLog

        private readonly Log _log;

        public LatestSiteEventsController()
        {
            _log = Log.GetInstanceLogger;
        }

        protected override void OnException(ExceptionContext exceptionContext)
        {
            _log.WriteErrorLog(exceptionContext.Exception.Message);
            if (exceptionContext.ExceptionHandled) return;
            exceptionContext.Result = new ViewResult
            {
                ViewName = "~/Views/Shared/Error.cshtml"
            };
            exceptionContext.ExceptionHandled = true;
        }

        #endregion
        public ActionResult UPSView3()
        {
            var info = new SortingPagingInfo
            {
                SortField = "SiteEvent.EventDateTime",
                SortDirection = "descending",
                PageSize = 1,
            };
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.PostAsJsonAsync(ProjectGlobals.ApplicationDomain + "/api/LatestSiteEventAPI/GetByPost", new FilterOptions
            {
                SortingPagingInfo = info,
                SiteIdList = new List<int>()
            }).Result;
            var responseString2 = response.Content.ReadAsStringAsync();
            var deSerializedObject = JsonConvert.DeserializeObject<PagedLatestSiteEvent>(responseString2.Result);
            var newinfo = new SortingPagingInfo
            {
                SortField = deSerializedObject.SortField,
                SortDirection = deSerializedObject.SortDirection,
                PageSize = deSerializedObject.PageSize,
                PageCount = deSerializedObject.PageCount,
                CurrentPageIndex = deSerializedObject.CurrentPageIndex
            };
            ViewBag.SortingPagingInfo = newinfo;
            return View(deSerializedObject);
        }
        [HttpPost]
        public ActionResult UPSView3(SortingPagingInfo info, string siteIdlist)
        {
            List<int> siteIdIntList = null;
            if (siteIdlist != "")
            {
                var siteIdStringList = siteIdlist.Split('-').ToList();
                siteIdIntList = siteIdStringList.Select(int.Parse).ToList();
            }

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync(ProjectGlobals.ApplicationDomain + "/api/LatestSiteEventAPI/GetByPost", new FilterOptions
            {
                SiteIdList = siteIdIntList,
                SortingPagingInfo = info
            }).Result;
            var responseString2 = response.Content.ReadAsStringAsync();
            PagedLatestSiteEvent deSerializedObject = JsonConvert.DeserializeObject<PagedLatestSiteEvent>(responseString2.Result);
            SortingPagingInfo newinfo = new SortingPagingInfo()
            {
                CurrentPageIndex = deSerializedObject.CurrentPageIndex,
                SortDirection = deSerializedObject.SortDirection,
                PageCount = deSerializedObject.PageCount,
                PageSize = deSerializedObject.PageSize,
                SortField = deSerializedObject.SortField
            };
            ViewBag.SortingPagingInfo = newinfo;
            return View(deSerializedObject);
        }
        public ActionResult UPSView2()
        {
            var info = new SortingPagingInfo
            {
                SortField = "SiteEvent.EventDateTime",
                SortDirection = "descending",
                PageSize = 1,
            };
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.PostAsJsonAsync(ProjectGlobals.ApplicationDomain + "/api/LatestSiteEventAPI/GetByPost", new FilterOptions
            {
                SortingPagingInfo = info,
                SiteIdList = new List<int>()
            }).Result;
            var responseString2 = response.Content.ReadAsStringAsync();
            var deSerializedObject = JsonConvert.DeserializeObject<PagedLatestSiteEvent>(responseString2.Result);
            var newinfo = new SortingPagingInfo
            {
                SortField = deSerializedObject.SortField,
                SortDirection = deSerializedObject.SortDirection,
                PageSize = deSerializedObject.PageSize,
                PageCount = deSerializedObject.PageCount,
                CurrentPageIndex = deSerializedObject.CurrentPageIndex
            };
            ViewBag.SortingPagingInfo = newinfo;
            return View(deSerializedObject);
        }
        [HttpPost]
        public ActionResult UPSView2(SortingPagingInfo info, string siteIdlist)
        {
            List<int> siteIdIntList = null;
            if (siteIdlist != "")
            {
                var siteIdStringList = siteIdlist.Split('-').ToList();
                siteIdIntList = siteIdStringList.Select(int.Parse).ToList();
            }

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync(ProjectGlobals.ApplicationDomain + "/api/LatestSiteEventAPI/GetByPost", new FilterOptions
            {
                SiteIdList = siteIdIntList,
                SortingPagingInfo = info
            }).Result;
            var responseString2 = response.Content.ReadAsStringAsync();
            PagedLatestSiteEvent deSerializedObject = JsonConvert.DeserializeObject<PagedLatestSiteEvent>(responseString2.Result);
            SortingPagingInfo newinfo = new SortingPagingInfo()
            {
                CurrentPageIndex = deSerializedObject.CurrentPageIndex,
                SortDirection = deSerializedObject.SortDirection,
                PageCount = deSerializedObject.PageCount,
                PageSize = deSerializedObject.PageSize,
                SortField = deSerializedObject.SortField
            };
            ViewBag.SortingPagingInfo = newinfo;
            return View(deSerializedObject);
        }
        public ActionResult DisplayAll()
        {
            return View();
        }

        // GET: /LatestSiteEvents/
        public ActionResult Index()
        {
            var info = new SortingPagingInfo
            {
                SortField = "SiteEvent.EventDateTime",
                SortDirection = "descending",
                PageSize = 1,
            };
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.PostAsJsonAsync(ProjectGlobals.ApplicationDomain + "/api/LatestSiteEventAPI/GetByPost", new FilterOptions
            {
                SortingPagingInfo = info,
                SiteIdList = new List<int>()
            }).Result;
            var responseString2 = response.Content.ReadAsStringAsync();
            var deSerializedObject = JsonConvert.DeserializeObject<PagedLatestSiteEvent>(responseString2.Result);
            var newinfo = new SortingPagingInfo
            {
                SortField = deSerializedObject.SortField,
                SortDirection = deSerializedObject.SortDirection,
                PageSize = deSerializedObject.PageSize,
                PageCount = deSerializedObject.PageCount,
                CurrentPageIndex = deSerializedObject.CurrentPageIndex
            };
            ViewBag.SortingPagingInfo = newinfo;
            return View(deSerializedObject);
        }

        [HttpPost]
        public ActionResult Index(SortingPagingInfo info, string siteIdlist)
        {
            List<int> siteIdIntList = null;
            if (siteIdlist != "")
            {
                var siteIdStringList = siteIdlist.Split('-').ToList();
                siteIdIntList = siteIdStringList.Select(int.Parse).ToList();
            }

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync(ProjectGlobals.ApplicationDomain + "/api/LatestSiteEventAPI/GetByPost", new FilterOptions
            {
                SiteIdList = siteIdIntList,
                SortingPagingInfo = info
            }).Result;
            var responseString2 = response.Content.ReadAsStringAsync();
            PagedLatestSiteEvent deSerializedObject = JsonConvert.DeserializeObject<PagedLatestSiteEvent>(responseString2.Result);
            SortingPagingInfo newinfo = new SortingPagingInfo()
            {
                CurrentPageIndex = deSerializedObject.CurrentPageIndex,
                SortDirection = deSerializedObject.SortDirection,
                PageCount = deSerializedObject.PageCount,
                PageSize = deSerializedObject.PageSize,
                SortField = deSerializedObject.SortField
            };
            ViewBag.SortingPagingInfo = newinfo;
            return View(deSerializedObject);
        }
        [HttpGet]
        public ActionResult GetSiteInfo(string siteId)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync(ProjectGlobals.ApplicationDomain + "/api/LatestSiteEventAPI/GetBySiteId/" + siteId).Result;
            //HttpResponseMessage response = client.GetAsync("http://vtrace.in/ElmasApiRestfull/api/LatestSiteEventAPI/GetBySiteId/" + siteId).Result;
            var responseString2 = response.Content.ReadAsStringAsync();
            LatestSiteEventEntity deSerializedObject = JsonConvert.DeserializeObject<LatestSiteEventEntity>(responseString2.Result);
            return View(deSerializedObject);
        }

        [HttpGet]
        public ActionResult GetAllLatestEvents()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync(ProjectGlobals.ApplicationDomain + "/api/LatestSiteEventAPI/").Result;
            var responseString2 = response.Content.ReadAsStringAsync();
            List<LatestSiteEventEntity> deSerializedObject = JsonConvert.DeserializeObject<List<LatestSiteEventEntity>>(responseString2.Result);
            return Json(deSerializedObject, JsonRequestBehavior.AllowGet);

        }
    }
}