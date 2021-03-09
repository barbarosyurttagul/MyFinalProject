﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //class: referans tip olabilir demek
    // new(): Interface verilemesin diye limitliyoruz. 
    public interface IEntityRepository<T> where T:IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
