using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Indus_RestFull_API.Controllers;
using Indus_RestFull_API;
using System.Web.Mvc;
using BusinessEntities;
using System.Net;
using AutoMapper;
using DataModel;
using Indus_RestFull_API.App_Start;
using System.Net.Http;
using System.Web.Http;

namespace Elmas.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly ProjectAPIController _ProjectAPIController;

         #region Public Constructor
        public UnitTest1()
        {
            _ProjectAPIController = new ProjectAPIController();
            _ProjectAPIController.Request = new HttpRequestMessage();
            _ProjectAPIController.Configuration = new HttpConfiguration();
        }
        #endregion

        [ClassInitialize]
        public static void Init(TestContext context)
        {
            AutoMapperConfig.Initialize();
        }
        [TestMethod]
        public void ProjectGetAll()
        {
            var result = _ProjectAPIController.Get();
            //List<ProjectEntity> _ProjectEntity;
            //Assert.IsTrue(result.TryGetContentValue<List<ProjectEntity>>(out _ProjectEntity));
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
        }
        [TestMethod]
        public void ProjectGetById()
        {
            int id = 1004;
            var result = _ProjectAPIController.Get(id);
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
            
        }

    }
}
