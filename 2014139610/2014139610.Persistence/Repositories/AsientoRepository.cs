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
    public class AsientoRepository : Repository<Asiento>, IAsientoRepository
    {
        private readonly _2014139610DbContext _Context;

        public AsientoRepository(_2014139610DbContext context)
        {
            _Context = context;
        }
        public AsientoRepository() : base()
        {

        }
        void IRepository<Asiento>.Add(Asiento entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Asiento>.AddRange(IEnumerable<Asiento> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Asiento> IRepository<Asiento>.Find(Expression<Func<Asiento, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Asiento IRepository<Asiento>.Get(int? id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Asiento> IRepository<Asiento>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<Asiento>.Remove(Asiento entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Asiento>.RemoveRange(IEnumerable<Asiento> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Asiento>.Update(Asiento entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Asiento>.UpdateRange(IEnumerable<Asiento> entities)
        {
            throw new NotImplementedException();
        }
    }
}
