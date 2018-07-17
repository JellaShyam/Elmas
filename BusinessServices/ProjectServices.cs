using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using AutoMapper;
using BusinessEntities;
using DataModel;
using DataModel.UnitOfWork;

namespace BusinessServices
{
    /// <summary>
    /// Offers services for Project specific CRUD operations
    /// </summary>
    public class ProjectServices:IProjectServices
    {
        private readonly UnitOfWork _unitOfWork;

        /// <summary>
        /// Public constructor.
        /// </summary>
        public ProjectServices()
        {
            _unitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// Fetches Project details by id
        /// </summary>
        /// <param name="ProjectId"></param>
        /// <returns></returns>
        public ProjectEntity GetProjectById(int productId)
        {
            var project = _unitOfWork.ProjectRepository.GetByID(productId);
            if (project != null)
            {
                ///For Old Version Mapper
                //Mapper.CreateMap<Project, ProjectEntity>();

                //For New Version Mapper
                //Mapper.Initialize(cfg =>
                //{
                //    cfg.CreateMap<Project, EndClientEntity>();
                //    cfg.CreateMap<Project, ProjectEntity>()
                //        .ForMember(d => d.EndClientEntity, opt => opt.MapFrom(s => s));
                //});
                //var projectModel = Mapper.Map<Project,ProjectEntity>(project);

                //Mapper Global Initiazized
                var projectModel = Mapper.Map<ProjectEntity>(project);
                return projectModel;
            }
            return null;
        }

        /// <summary>
        /// Fetches all the Projects.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ProjectEntity> GetAllProjects()
        {
            
            var projects = _unitOfWork.ProjectRepository.GetAll().ToList();
            if (projects.Any())
            {
                ///For Old Version Mapper
                //Mapper.CreateMap<Project, ProjectEntity>();
                //For New Version Mapper
                //Mapper.Initialize(cfg =>
                //{
                //    cfg.CreateMap<Project, EndClientEntity>();
                //    cfg.CreateMap<Project, ProjectEntity>()
                //        .ForMember(d => d.EndClientEntity, opt => opt.MapFrom(s => s));
                //});
                var productsModel = Mapper.Map<List<ProjectEntity>>(projects);
                return productsModel;
            }
            return null;
        }

        /// <summary>
        /// Creates a Project
        /// </summary>
        /// <param name="ProjectEntity"></param>
        /// <returns></returns>
        public int CreateProject(ProjectEntity productEntity)
        {
            using (var scope = new TransactionScope())
            {
                var project = new Project
                {
                    Name = productEntity.Name
                };
                _unitOfWork.ProjectRepository.Insert(project);
                _unitOfWork.Save();
                scope.Complete();
                return project.Id;
            }
        }

        /// <summary>
        /// Updates a Project
        /// </summary>
        /// <param name="ProjectId"></param>
        /// <param name="ProjectEntity"></param>
        /// <returns></returns>
        public bool UpdateProject(int productId, ProjectEntity projectEntity)
        {
            var success = false;
            if (projectEntity != null)
            {
                using (var scope = new TransactionScope())
                {
                    var project = _unitOfWork.ProjectRepository.GetByID(productId);
                    if (project != null)
                    {
                        project.Name = projectEntity.Name;
                        _unitOfWork.ProjectRepository.Update(project);
                        _unitOfWork.Save();
                        scope.Complete();
                        success = true;
                    }
                }
            }
            return success;
        }

        /// <summary>
        /// Deletes a particular Project
        /// </summary>
        /// <param name="ProjectId"></param>
        /// <returns></returns>
        public bool DeleteProject(int ProjectId)
        {
            var success = false;
            if (ProjectId > 0)
            {
                using (var scope = new TransactionScope())
                {
                    var Project = _unitOfWork.ProjectRepository.GetByID(ProjectId);
                    if (Project != null)
                    {

                        _unitOfWork.ProjectRepository.Delete(Project);
                        _unitOfWork.Save();
                        scope.Complete();
                        success = true;
                    }
                }
            }
            return success;
        }
    }
}