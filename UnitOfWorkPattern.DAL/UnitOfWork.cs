using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UnitOfWorkPattern.DAL.Abstracts;
using UnitOfWorkPattern.DAL.Models;

namespace UnitOfWorkPattern.DAL
{
    public class UnitOfWork : IDisposable
    {
        private EmployeeDBContext context;
        private GenericRepository<Employee> _employeeRepository;

        public GenericRepository<Employee> EmployeeRepository
        {
            get
            {

                if (this._employeeRepository == null)
                {
                    this._employeeRepository = new GenericRepository<Employee>(context);
                }
                return _employeeRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
