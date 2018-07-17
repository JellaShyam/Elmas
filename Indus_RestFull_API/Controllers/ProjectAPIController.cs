using BusinessEntities;
using BusinessServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Indus_RestFull_API.Controllers
{
    public class ProjectAPIController : ApiController
    {
        private readonly IProjectServices _productServices;

         #region Public Constructor

        /// <summary>
        /// Public constructor to initialize product service instance
        /// </summary>
        public ProjectAPIController()
        {
            _productServices =new ProjectServices();
        }

        #endregion

        // GET api/product
        public HttpResponseMessage Get()
        {
            var products = _productServices.GetAllProjects();
            if (products != null)
            {
                var projectEntities = products as List<ProjectEntity> ?? products.ToList();
                if (projectEntities.Any())
                    return Request.CreateResponse(HttpStatusCode.OK, projectEntities);
            }
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Products not found");
        }

        // GET api/product/5
        public HttpResponseMessage Get(int id)
        {
            var product = _productServices.GetProjectById(id);
            if (product != null)
                return Request.CreateResponse(HttpStatusCode.OK, product);
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No product found for this id");
        }

        // POST api/product
        public int Post([FromBody] ProjectEntity productEntity)
        {
            return _productServices.CreateProject(productEntity);
        }

        // PUT api/product/5
        public bool Put(int id, [FromBody]ProjectEntity productEntity)
        {
            if (id  > 0)
            {
                return _productServices.UpdateProject(id, productEntity);
            }
            return false;
        }

        // DELETE api/product/5
        public bool Delete(int id)
        {
            if (id > 0)
                return _productServices.DeleteProject(id);
            return false;
        }
    }
}
