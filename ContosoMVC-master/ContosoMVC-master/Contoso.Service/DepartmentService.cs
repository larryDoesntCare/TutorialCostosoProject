using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data.Repositories;
using Contoso.Model;

namespace Contoso.Service
{
    public interface IDepartmentService
    {
        IEnumerable<Department> GetAllDepartments(string name = null);
        Department GetDepartment(int id);
        Department GetDepartment(string name);
        void CreateDepartment(Department department);
        void DeleteDepartment(Department department);
    }

    public class DepartmentService : IDepartmentService
    {
        private readonly IRepository<Department> _depRepository;

        public DepartmentService(IRepository<Department> depRepository)
        {
            _depRepository = depRepository;
        }

        public IEnumerable<Department> GetAllDepartments(string name = null)
        {
            return string.IsNullOrEmpty(name) ? _depRepository.GetAll() : _depRepository.GetAll().Where(c => c.Name == name);
        }

        public Department GetDepartment(int id)
        {
            var dep = _depRepository.GetById(id);
            return dep;
        }

        public Department GetDepartment(string name)
        {
            return _depRepository.GetByName(name);
        }

        public void CreateDepartment(Department department)
        {
            _depRepository.Add(department);
        }

        public void DeleteDepartment(Department department)
        {
            _depRepository.Delete(department);
        }
    }
}