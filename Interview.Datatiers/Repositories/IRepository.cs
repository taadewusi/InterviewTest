﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Datatiers.Repositories
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(Guid id);
        void Add(T t);
        void Update(T t);
        void Delete(Guid id);
        void Save();
    }
}
