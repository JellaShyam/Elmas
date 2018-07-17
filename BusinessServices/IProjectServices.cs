using System.Collections.Generic;
using BusinessEntities;

namespace BusinessServices
{
    /// &lt;summary>
    /// Product Service Contract
    /// &lt;/summary>
    public interface IProjectServices
    {
        ProjectEntity GetProjectById(int productId);
        IEnumerable<ProjectEntity> GetAllProjects();
        int CreateProject(ProjectEntity projectEntity);
        bool UpdateProject(int projectId, ProjectEntity projectEntity);
        bool DeleteProject(int projectId);
    }
}