using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;

namespace Contoso.Data.Repositories
{
    public class DepartmentRepository : IRepository<Department>, IDisposable
    {
        private readonly SchoolContext _context;

        public DepartmentRepository(SchoolContext context)
        {
            _context = context;
        }

        public void Add(Department entity)
        {
            _context.Departments.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Department entity)
        {
            _context.Departments.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(Department entity)
        {
            _context.Departments.Remove(entity);
            _context.SaveChanges();
        }

        public void Delete(Expression<Func<Department, bool>> @where)
        {
            IEnumerable<Department> objects = _context.Departments.Where<Department>(where).AsEnumerable();
            foreach (Department obj in objects)
                _context.Departments.Remove(obj);
            _context.SaveChanges();
        }

        public Department GetById(int id)
        {
            return _context.Departments.Find(id);
        }

        public Department GetByName(string name)
        {
            return _context.Departments.FirstOrDefault(d => d.Name == name);
        }

        public Department Get(Expression<Func<Department, bool>> @where)
        {
            return _context.Departments.Where(where).FirstOrDefault();
        }

        public IEnumerable<Department> GetAll()
        {
            return _context.Departments.ToList();
        }

        public IEnumerable<Department> GetMany(Expression<Func<Department, bool>> @where)
        {
            return _context.Departments.Where(where).ToList();
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool _disposed = false;

        private void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }
    }
}