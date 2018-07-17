#region Using Namespaces...

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Data.Entity.Validation;
using DataModel.GenericRepository;

#endregion

namespace DataModel.UnitOfWork
{
    /// <summary>
    /// Unit of Work class responsible for DB transactions
    /// </summary>
    public class UnitOfWork : IDisposable
    {
        #region Private member variables...

        private ELMAS_UPS_V1Entities _context = null;
        private GenericRepository<Project> _projectRepository;
        private GenericRepository<EndClient> _EndClientRepository;
        private GenericRepository<PrimeVendor> _primeVendorRepository;
        private GenericRepository<LatestSiteEvent> _latestSiteEventRepository;
        private GenericRepository<Site> _SiteRepository;

        #endregion

        public UnitOfWork()
        {
            _context = new ELMAS_UPS_V1Entities();
        }

        #region Public Repository Creation properties...

        /// <summary>
        /// Get/Set Property for Project repository.
        /// </summary>
        public GenericRepository<Project> ProjectRepository
        {
            get
            {
                if (this._projectRepository == null)
                    this._projectRepository = new GenericRepository<Project>(_context);
                return _projectRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for user repository.
        /// </summary>
        public GenericRepository<PrimeVendor> UserRepository
        {
            get
            {
                if (this._primeVendorRepository == null)
                    this._primeVendorRepository = new GenericRepository<PrimeVendor>(_context);
                return _primeVendorRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for EndClient repository.
        /// </summary>
        public GenericRepository<EndClient> EndClientRepository
        {
            get
            {
                if (this._EndClientRepository == null)
                    this._EndClientRepository = new GenericRepository<EndClient>(_context);
                return _EndClientRepository;
            }
        }
        /// <summary>
        /// Get/Set Property for LatestSiteEvent repository.
        /// </summary>
        public GenericRepository<LatestSiteEvent> LatestSiteEventRepository
        {
            get
            {
                if (this._latestSiteEventRepository == null)
                    this._latestSiteEventRepository = new GenericRepository<LatestSiteEvent>(_context);
                return _latestSiteEventRepository;
            }
        }
        public GenericRepository<Site> SiteRepository
        {
            get
            {
                if (this._SiteRepository == null)
                    this._SiteRepository = new GenericRepository<Site>(_context);
                return _SiteRepository;
            }
        }
        #endregion

        #region Public member methods...
        /// <summary>
        /// Save method.
        /// </summary>
        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {

                var outputLines = new List<string>();
                foreach (var eve in e.EntityValidationErrors)
                {
                    outputLines.Add(string.Format(
                        "{0}: Entity of type \"{1}\" in state \"{2}\" has the following validation errors:", DateTime.Now,
                        eve.Entry.Entity.GetType().Name, eve.Entry.State));
                    foreach (var ve in eve.ValidationErrors)
                    {
                        outputLines.Add(string.Format("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage));
                    }
                }
                System.IO.File.AppendAllLines(@"C:\errors.txt", outputLines);

                throw e;
            }

        }

        #endregion

        #region Implementing IDiosposable...

        #region private dispose variable declaration...
        private bool disposed = false;
        #endregion

        /// <summary>
        /// Protected Virtual Dispose method
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Debug.WriteLine("UnitOfWork is being disposed");
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        /// <summary>
        /// Dispose method
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}