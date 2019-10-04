using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace EmployeeAppDLL
{
    public class Employees
    {
        string idEmployee;
        string idManager;
        string salaryAmount;
        string[] fields;

   


        public Employees()
        {
            var path = @"test.csv";

            using (TextFieldParser csvParser = new TextFieldParser(path))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                csvParser.ReadLine();
                Console.WriteLine("EmployeeID   ManagerID   Salary");
                Console.WriteLine("--------------------------------");
                

                while (!csvParser.EndOfData)
                {
                    fields = csvParser.ReadFields();
                    idEmployee = fields[0];
                    idManager = fields[1];
                    salaryAmount = fields[2];
                    int checkSalary;

                    //Check if Salary is an integer
                    if (int.TryParse(salaryAmount, out checkSalary))
                    {
                        //Check if Manager is an employee
                        if (idManager == "" && idEmployee == "")
                        {
                            Console.WriteLine("Error: Manager must have an employeeID");
                            break;
                        }
                        else
                        {

                            Console.WriteLine(idEmployee + "  " + idManager + "  " + salaryAmount);
                        }
                        
                       


                    }
                    else
                    {
                        Console.WriteLine("Invalid Loaded File: Salary Amount not an integer for EmployeeID: " + idEmployee);
                        break;
                    }

                }

            }

        }

        public void getSalary()
        {
            var path = @"test.csv";
            Console.WriteLine();
            Console.Write("Enter Manager ID: ");
            string managerID=Console.ReadLine();
            Console.WriteLine();
            long sumSalary = 0;
            string employeeID=managerID;

            using (TextFieldParser csvParser = new TextFieldParser(path))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                csvParser.ReadLine();
                while (!csvParser.EndOfData)
                {
                    fields = csvParser.ReadFields();
                   
                    if (managerID == fields[1])
                    {
                        sumSalary = sumSalary + Convert.ToInt32(fields[2]);
                      
                    }
                   
                  
                    if (employeeID == fields[0])
                    {
                   
                        sumSalary = sumSalary + Convert.ToInt32(fields[2]);
                    }

                }
            }
            Console.WriteLine("Salary for: " +managerID+" = " + sumSalary);
        }
    }

}
