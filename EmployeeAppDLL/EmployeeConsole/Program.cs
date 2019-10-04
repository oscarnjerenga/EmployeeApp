using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeAppDLL;

namespace EmployeeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees emp = new Employees();
            emp.getSalary();
           

        }
    }
}
