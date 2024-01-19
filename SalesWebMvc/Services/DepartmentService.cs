using System;
using System.Collections.Generic;
using System.Linq;
using SalesWebMvc.Models;
using System.Threading.Tasks;
using SalesWebMvc.Controllers;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {

        private readonly SalesWebMvcContext _salesContext;

        public DepartmentService(SalesWebMvcContext salesContext)
        {
            _salesContext = salesContext;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _salesContext.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
