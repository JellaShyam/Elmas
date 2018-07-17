using AutoMapper;
using BusinessEntities;
using DataModel.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic;

namespace BusinessServices
{
    public class LatestSiteEventServices : ILatestSiteEventServices
    {
        private readonly UnitOfWork _unitOfWork;
        /// <summary>
        /// Public constructor.
        /// </summary>
        public LatestSiteEventServices()
        {
            _unitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// Fetches LatestSiteEventEntity details by id
        /// </summary>
        /// <param name="LatestSiteEventId"></param>
        /// <returns></returns>
        public LatestSiteEventEntity GetLatestSiteEventById(int LatestSiteEventId)
        {
            var latestSiteEvent = _unitOfWork.LatestSiteEventRepository.GetByID(LatestSiteEventId);
            if (latestSiteEvent != null)
            {
                var _latestSiteEvent = Mapper.Map<LatestSiteEventEntity>(latestSiteEvent);
                return _latestSiteEvent;
            }
            return null;
        }
        /// <summary>
        /// Fetches LatestSiteEventEntity details by SiteId
        /// </summary>
        /// <param name="SiteId"></param>
        /// <returns></returns>
        public LatestSiteEventEntity GetLatestSiteEventBySiteId(string SiteId)
        {
            var latestSiteEvent = _unitOfWork.LatestSiteEventRepository.Get(x => x.SiteEvent.Site.SiteId == SiteId);
            if (latestSiteEvent != null)
            {
                var _latestSiteEvent = Mapper.Map<LatestSiteEventEntity>(latestSiteEvent);
                return _latestSiteEvent;
            }
            return null;
        }

        /// <summary>
        /// Fetches all the LatestSiteEvents.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<LatestSiteEventEntity> GetAllLatestSiteEvents()
        {
            var latestSiteEvents = _unitOfWork.LatestSiteEventRepository.GetAll().ToList();
            if (latestSiteEvents.Any())
            {
                var _latestSiteEvents = Mapper.Map<List<LatestSiteEventEntity>>(latestSiteEvents);
                return _latestSiteEvents;
            }
            return null;
        }
        /// <summary>
        /// Fetches all the LatestSiteEvents.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<LatestSiteEventEntity> GetSortedLatestSiteEvents(string SortColumn, string SortDirection, int take, int skip)
        {
            var latestSiteEvents = _unitOfWork.LatestSiteEventRepository.GetSrtedData(SortColumn, SortDirection, take, skip);
            //var latestSiteEvents = _unitOfWork.LatestSiteEventRepository.GetAll().ToList();
            if (latestSiteEvents.Any())
            {
                var _latestSiteEvents = Mapper.Map<List<LatestSiteEventEntity>>(latestSiteEvents);
                return _latestSiteEvents;
            }
            return null;
        }


        public IEnumerable<LatestSiteEventEntity> GetManyLatestSiteEvents(List<int> Keys)
        {
            var latestSiteEvents = _unitOfWork.LatestSiteEventRepository.GetMany(x => Keys.Contains(x.SiteId)).ToList();
            if (!latestSiteEvents.Any()) return null;
            var _latestSiteEvents = Mapper.Map<List<LatestSiteEventEntity>>(latestSiteEvents);
            return _latestSiteEvents;
        }


        public decimal GetLatestSiteEventCount()
        {
            return _unitOfWork.LatestSiteEventRepository.GetCount();
        }
    }

}
