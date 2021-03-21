using DWB_Tarea2.Backend;
using DWB_Tarea2.DataAccess;
using System;
using System.Linq;

namespace DWB_Tarea2
{
    class Program
    {

        public static EmployeesSC employeeService = new EmployeesSC();

        public static void Excercise()
        {
            var queryEmp = employeeService.GetEmployees();
            var output = queryEmp.ToList();
        }

        static void Main(string[] args)
        {
            Excercise();
            Console.WriteLine("Programa finalizado con exito");
        }
    }
}
