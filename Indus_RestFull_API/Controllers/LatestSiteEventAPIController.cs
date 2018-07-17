using System;
using BusinessEntities;
using BusinessServices;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Indus_RestFull_API.Controllers
{
    public class LatestSiteEventApiController : ApiController
    {
        private readonly ILatestSiteEventServices _latestSiteEventServices;

        #region Public Constructor

        /// <inheritdoc />
        /// <summary>
        /// Public constructor to initialize product service instance
        /// </summary>
        public LatestSiteEventApiController()
        {
            _latestSiteEventServices = new LatestSiteEventServices();
        }

        #endregion

        // GET api/product
        public HttpResponseMessage Get()
        {
            /// <summary>
            /// To Get All latestSiteEvents
            /// </summary>
            //var latestSiteEvents= _latestSiteEventServices.GetAllLatestSiteEvents();
            var latestSiteEvents = _latestSiteEventServices.GetAllLatestSiteEvents();
            if (latestSiteEvents == null)
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Products not found");
            var latestSiteEventEntities = latestSiteEvents as List<LatestSiteEventEntity> ?? latestSiteEvents.ToList();
            return latestSiteEventEntities.Any() ? Request.CreateResponse(HttpStatusCode.OK, latestSiteEventEntities) : Request.CreateErrorResponse(HttpStatusCode.NotFound, "Products not found");
        }
        [HttpPost]
        [Route("api/LatestSiteEventAPI/GetByPost/")]
        public HttpResponseMessage GetByPost(FilterOptions filterOptions)
        {
            IEnumerable<LatestSiteEventEntity> latestSiteEvents;
            PagedLatestSiteEvent pagedLatestSiteEvent;
            List<LatestSiteEventEntity> latestSiteEventEntities;
            var skip = (filterOptions.SortingPagingInfo.CurrentPageIndex * filterOptions.SortingPagingInfo.PageSize);
            if (filterOptions.SiteIdList != null && filterOptions.SiteIdList.Count > 0)
            {
                latestSiteEvents = _latestSiteEventServices.GetManyLatestSiteEvents(filterOptions.SiteIdList);
                if (latestSiteEvents == null)
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Products not found");
                latestSiteEventEntities = latestSiteEvents as List<LatestSiteEventEntity> ?? latestSiteEvents.ToList();
                var totalSites = latestSiteEventEntities.Count;
                pagedLatestSiteEvent = FilteredDataSource(filterOptions, latestSiteEventEntities, totalSites);
            }
            else
            {
                latestSiteEvents =
                    _latestSiteEventServices.GetSortedLatestSiteEvents(filterOptions.SortingPagingInfo.SortField,
                        filterOptions.SortingPagingInfo.SortDirection,
                        filterOptions.SortingPagingInfo.PageSize, skip);
                if (latestSiteEvents == null)
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Products not found");
                latestSiteEventEntities = latestSiteEvents as List<LatestSiteEventEntity> ?? latestSiteEvents.ToList();
                var totalSites = _latestSiteEventServices.GetLatestSiteEventCount();
                pagedLatestSiteEvent = FilteredDataSource(filterOptions, latestSiteEventEntities, totalSites);
            }
            return latestSiteEventEntities.Any()
                ? Request.CreateResponse(HttpStatusCode.OK, pagedLatestSiteEvent)
                : Request.CreateErrorResponse(HttpStatusCode.NotFound, "Products not found");
        }
        public PagedLatestSiteEvent FilteredDataSource(FilterOptions filterOptions, List<LatestSiteEventEntity> latestSiteEventEntities, decimal totalRecords)
        {
            var pagedLatestSiteEvent = new PagedLatestSiteEvent()
            {
                CurrentPageIndex = filterOptions.SortingPagingInfo.CurrentPageIndex,
                MinifiedLatestSiteEvents = latestSiteEventEntities,
                PageSize = filterOptions.SortingPagingInfo.PageSize,
                SortDirection = filterOptions.SortingPagingInfo.SortDirection,
                SortField = filterOptions.SortingPagingInfo.SortField,
                PageCount = Convert.ToInt32(Math.Ceiling(totalRecords / filterOptions.SortingPagingInfo.PageSize))
            };
            return pagedLatestSiteEvent;
        }
        // GET api/product/5
        public HttpResponseMessage Get(int id)
        {
            var latestSiteEvent = _latestSiteEventServices.GetLatestSiteEventById(id);
            return latestSiteEvent != null ? Request.CreateResponse(HttpStatusCode.OK, latestSiteEvent) : Request.CreateErrorResponse(HttpStatusCode.NotFound, "No product found for this id");
        }
        [Route("api/LatestSiteEventAPI/GetBySiteId/{SiteId}")]
        public HttpResponseMessage GetBySiteId(string SiteId)
        {
            var latestSiteEvent = _latestSiteEventServices.GetLatestSiteEventBySiteId(SiteId);
            return latestSiteEvent != null
                ? Request.CreateResponse(HttpStatusCode.OK, latestSiteEvent)
                : Request.CreateErrorResponse(HttpStatusCode.NotFound, "No product found for this id");
        }
    }
}
