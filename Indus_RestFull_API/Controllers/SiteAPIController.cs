using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessEntities;
using BusinessServices;

namespace Indus_RestFull_API.Controllers
{
    public class SiteAPIController : ApiController
    {
        private readonly ISiteService _siteServices;

        #region Public Constructor

        /// <inheritdoc />
        /// <summary>
        /// Public constructor to initialize product service instance
        /// </summary>
        public SiteAPIController()
        {
            _siteServices = new SiteService();
        }

        #endregion

        // GET api/product
        [Route("api/SiteAPI/GetUpsList")]
        public HttpResponseMessage GetUpsList()
        {
            var sites = _siteServices.GetAllSites();
            if (sites == null) return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Sites not found");
            var siteEntities = sites as List<SiteEntity> ?? sites.ToList();
            return siteEntities.Any()
                ? Request.CreateResponse(HttpStatusCode.OK, siteEntities)
                : Request.CreateErrorResponse(HttpStatusCode.NotFound, "Sites not found");
        }
    }
}
