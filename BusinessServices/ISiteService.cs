using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessServices
{
    public interface ISiteService
    {
        IEnumerable<SiteEntity> GetAllSites();
        IEnumerable<SiteEntity> GetSitesForAutoLoad(string prefix);
    }
}
