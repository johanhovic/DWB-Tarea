using DWB_Tarea2.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWB_Tarea2.Backend
{
    class EmployeesSC : BaseSC
    {
        public IQueryable<Employee> GetEmployees()
        {
            return dataContext.Employees.Select(e => e);
        }
    }
}
