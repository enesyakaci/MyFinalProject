﻿using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint-generic kısıt
    //alttaki class referans tip olabilir anlamında kullanılır
    //IEntity : IEntity olabilir ya da IEntity implamente eden bir nesne olabilir
    // new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T:class, IEntity
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
