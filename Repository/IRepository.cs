using System;
using System.Linq;

namespace Repository
{
    public interface IRepository<T>
    {
        IQueryable<T> Query();
    }
}
