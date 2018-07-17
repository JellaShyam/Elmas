using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessEntities;
using DataModel.UnitOfWork;

namespace BusinessServices
{
    public class SiteService : ISiteService
    {
        private readonly UnitOfWork _unitOfWork;
        /// <summary>
        /// Public constructor.
        /// </summary>
        public SiteService()
        {
            _unitOfWork = new UnitOfWork();
        }
        public IEnumerable<SiteEntity> GetAllSites()
        {
            var siteEvent = _unitOfWork.SiteRepository.GetAll().ToList();
            if (!siteEvent.Any()) return null;
            var siteEvents = Mapper.Map<List<SiteEntity>>(siteEvent);
            return siteEvents;
        }


        public IEnumerable<SiteEntity> GetSitesForAutoLoad(string prefix)
        {
            var siteEvent = _unitOfWork.SiteRepository.GetMany(x => x.SiteId.Contains(prefix)).Take(5);
            if (!siteEvent.Any()) return null;
            var siteEvents = Mapper.Map<List<SiteEntity>>(siteEvent);
            return siteEvents;
        }
    }
}
