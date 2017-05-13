using _2014139610.Entities;
using _2014139610.Entities.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2014139610.Persistence.Repositories
{
    public class BusRepository : Repository<Bus>, IBusRepository
    {
        private readonly _2014139610DbContext _Context;

        public BusRepository(_2014139610DbContext context)
        {
            _Context = context;
        }
        public BusRepository() : base()
        {

        }
        void IRepository<Bus>.Add(Bus entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.AddRange(IEnumerable<Bus> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Bus> IRepository<Bus>.Find(Expression<Func<Bus, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Bus IRepository<Bus>.Get(int? id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Bus> IRepository<Bus>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.Remove(Bus entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.RemoveRange(IEnumerable<Bus> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.Update(Bus entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Bus>.UpdateRange(IEnumerable<Bus> entities)
        {
            throw new NotImplementedException();
        }
    }
}
