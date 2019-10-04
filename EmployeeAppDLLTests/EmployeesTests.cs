using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeAppDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAppDLL.Tests
{
    [TestClass()]
    public class EmployeesTests
    {
        [TestMethod()]
        public void EmployeesTest()
        {
            Employees loadfile = new Employees();
            Console.WriteLine("File Successfully loaded");
        }

        [TestMethod()]
        public void SalaryTest()
        {
            Employees loadfile = new Employees();
            loadfile.getSalary();
            Console.WriteLine("Salary Successfully deduced");
        }
    }
}