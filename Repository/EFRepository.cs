using Microsoft.EntityFrameworkCore;
using Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public abstract class EFRepository<T> : IRepository<T> where T : class
    {
        protected readonly EFContent context;

        public EFRepository(EFContent db)
        {
            this.context = db;
        }

        /// <summary>
        /// 取数据
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> Query()
        {
            return context.Query<T>();
        }
    }
}
