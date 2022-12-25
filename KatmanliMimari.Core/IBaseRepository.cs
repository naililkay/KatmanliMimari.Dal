﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KatmanliMimari.Core
{
    public interface IBaseRepository<T> where T : class
    {
        public List<T> List();
        public T Find(int Id);
        public T Find(string Id);
        public bool Update(T entity);
        public bool Delete(int Id);
        public bool Delete (string id);
        public bool Delete(T entity);
        public bool Add(T entity);
        public DbSet<T>  Set();

    }
}
