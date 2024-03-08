using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Contracts.Repository;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    internal class BaseRepository<T>:IBaseRepository<T> where T:class
    {
        protected readonly ProductDBContext _context;
        public BaseRepository(ProductDBContext tb) { 
            _context = tb;
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public int Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
