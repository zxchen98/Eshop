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
    public class BaseRepository<T>:IBaseRepository<T> where T:class
    {
        protected readonly TrainingDbContext _context;
        public BaseRepository(TrainingDbContext tb) { 
            _context = tb;
        }

        public int Delete(int id)
        {
            var entity = GetById(id);
            _context.Set<T>().Remove(entity);
            return _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public int Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            return _context.SaveChanges();
        }

        public int Update(T entity)
        {
            _context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return _context.SaveChanges();
        }
    }
}
