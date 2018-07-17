using BusinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public interface ILatestSiteEventServices
    {
        LatestSiteEventEntity GetLatestSiteEventById(int LatestSiteEventId);
        LatestSiteEventEntity GetLatestSiteEventBySiteId(string SiteId);
        IEnumerable<LatestSiteEventEntity> GetManyLatestSiteEvents(List<int> Keys);
        IEnumerable<LatestSiteEventEntity> GetAllLatestSiteEvents();
        IEnumerable<LatestSiteEventEntity> GetSortedLatestSiteEvents(string SortColumn, string SortDirection, int take, int skip);
        decimal GetLatestSiteEventCount();

        // int CreateProject(LatestSiteEventEntity projectEntity);
        // bool UpdateProject(int projectId, LatestSiteEventEntity projectEntity);
        // bool DeleteProject(int projectId);
    }
}
