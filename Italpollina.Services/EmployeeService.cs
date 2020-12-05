using Italpollina.Data;
using Italpollina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Italpollina.Services
{
    public class EmployeeService
    {
        public void CreateEmployee(EmployeeCreate model)
        {
            var entity = new Employee
            {
                Name = model.Name,
            };
                        
        }
    }
}
