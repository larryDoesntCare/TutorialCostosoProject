using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data.Repositories;
using Contoso.Model;

namespace Contoso.Service
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAllStudents(string name = null);
        Student GetStudent(int id);
        Student GetStudent(string name);
        void CreateStudent(Student student);
        void DeleteStudent(Student student);
    }

    public class StudentService : IStudentService
    {
        private readonly IRepository<Student> _studentRepository;
        public StudentService(IRepository<Student> studentRepository)
        {
            this._studentRepository = studentRepository;
        }

        public IEnumerable<Student> GetAllStudents(string name = null)
        {
            return string.IsNullOrEmpty(name) ? _studentRepository.GetAll() : _studentRepository.GetAll().Where(c => c.LastName == name);
        }

        public Student GetStudent(int id)
        {
            var student = _studentRepository.GetById(id);
            return student;
        }

        public Student GetStudent(string name)
        {
            return _studentRepository.GetByName(name);
        }

        public void CreateStudent(Student student)
        {
            _studentRepository.Add(student);
        }

        public void DeleteStudent(Student student)
        {
            _studentRepository.Delete(student);
        }
    }
}
