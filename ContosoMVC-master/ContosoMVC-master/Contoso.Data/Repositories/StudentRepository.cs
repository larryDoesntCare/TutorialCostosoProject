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
    public class StudentRepository : IRepository<Student>, IDisposable
    {
        private readonly SchoolContext _context;

        public StudentRepository(SchoolContext context)
        {
            _context = context;
        }


        public void Add(Student entity)
        {
            _context.Students.Add(entity);
            _context.SaveChanges();

        }

        public void Update(Student entity)
        {
            _context.Students.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();

        }

        public void Delete(Student entity)
        {
            _context.Students.Remove(entity);
            _context.SaveChanges();

        }

        public void Delete(Expression<Func<Student, bool>> @where)
        {
            IEnumerable<Student> objects = _context.Students.Where<Student>(where).AsEnumerable();
            foreach (Student obj in objects)
                _context.Students.Remove(obj);
            _context.SaveChanges();
        }

        public Student GetById(int id)
        {
            return _context.Students.Find(id);
        }

        public Student GetByName(string name)
        {
            return _context.Students.FirstOrDefault(d => d.LastName == name);
        }

        public Student Get(Expression<Func<Student, bool>> @where)
        {
            return _context.Students.Where(where).FirstOrDefault();
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public IEnumerable<Student> GetMany(Expression<Func<Student, bool>> @where)
        {
            return _context.Students.Where(where).ToList();
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
