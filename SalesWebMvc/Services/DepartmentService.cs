using System;
using System.Collections.Generic;
using System.Linq;
using SalesWebMvc.Models;
using System.Threading.Tasks;
using SalesWebMvc.Controllers;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {

        private readonly SalesWebMvcContext _salesContext;

        public DepartmentService(SalesWebMvcContext salesContext)
        {
            _salesContext = salesContext;
        }

        public List<Department> FindAll()
        {
            return _salesContext.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
