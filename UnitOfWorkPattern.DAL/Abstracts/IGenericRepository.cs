﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UnitOfWorkPattern.DAL.Abstracts
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(T obj);
    }
}
