using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class LitwareLib
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Display(employee);
            CalculateSalary(employee);
            Console.Read();
        }
        static void Display(Employee employee)
        {
            try
            {
                Console.Write("Enter Employee Number : ");
                employee._EmpNo = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.Write("Enter Employee Name : ");
                employee._EmpName = Console.ReadLine();
                Console.Write("Enter Your Salary : ");
                employee._Salary = int.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (employee._Salary >= 20000)
            {
                employee._HRA = (employee._Salary * 30) / 100;
                employee._TA = (employee._Salary * 25) / 100;
                employee._DA = (employee._Salary * 35) / 100;
            }
            else if (employee._Salary < 20000 && employee._Salary > 15000)
            {
                employee._HRA = (employee._Salary * 25) / 100;
                employee._TA = (employee._Salary * 20) / 100;
                employee._DA = (employee._Salary * 30) / 100;
            }
            else if (employee._Salary < 15000 && employee._Salary > 10000)
            {
                employee._HRA = (employee._Salary * 20) / 100;
                employee._TA = (employee._Salary * 15) / 100;
                employee._DA = (employee._Salary * 25) / 100;
            }
            else if (employee._Salary < 10000 && employee._Salary > 5000)
            {
                employee._HRA = (employee._Salary * 15) / 100;
                employee._TA = (employee._Salary * 10) / 100;
                employee._DA = (employee._Salary * 20) / 100;
            }
            else
            {
                employee._HRA = (employee._Salary * 10) / 100;
                employee._TA = (employee._Salary * 5) / 100;
                employee._DA = (employee._Salary * 15) / 100;

            }
            employee._GrossSalary = employee._Salary + employee._HRA + employee._TA + employee._DA;

            Console.WriteLine("Gross Salary : " + employee._GrossSalary);
        }
        static void CalculateSalary(Employee employee)
        {
            employee._PF = (employee._GrossSalary * 10) / 100;
            employee._TDS = (employee._GrossSalary * 18) / 100;
            employee._NetSalary = employee._GrossSalary - (employee._PF + employee._TDS);
        }
    }
}
