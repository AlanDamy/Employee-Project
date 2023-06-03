using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damy__Alan_Major_Assignment_2
{

/*
 * Alan Damy
 * May 25, 2023
 * Major Assignment 2
 * This program contains the main program logic for an employee management system created by Alan Damy.
 * Due: Wednesday, May 31, 2023
 */
    class Program
    {
        static List<Employee> employees = new List<Employee>();
        static String Menu() 
        {
            Console.WriteLine("1 -Add Employee ");
            Console.WriteLine("2 -Create Pay Roll ");
            Console.WriteLine("3 -Find an Employee information ");
            Console.WriteLine("4 -Exit ");
            return Console.ReadLine();

        }
        static void Main()
        {
            while (true)
            {
                string choice = Menu();
                if (choice.Equals("1")) add_Employee();
                else if (choice.Equals("2")) create_PayRoll();
                else if (choice.Equals("3")) employee_Info();
                else if (choice.Equals("4")) { Console.WriteLine("Thanks for Using my program"); break; }
                else { Console.WriteLine("Bad Input"); }
                Console.WriteLine(); //extra line to help make the output more aesthetic

            }
        }
        private static void add_Employee() //Adds a new employee to the system
        {
            Console.WriteLine(); //extra line to help make the output more aesthetic
            Console.WriteLine("Enter employee details:");
            Console.WriteLine("First Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine(); //extra line to help make the output more aesthetic

            Console.WriteLine("Enter residence details:");
            Console.WriteLine("Street Name: ");
            string streetName = Console.ReadLine();
            Console.WriteLine("City Name: ");
            string cityName = Console.ReadLine();
            Console.WriteLine("Zip Code: ");
            string zipCode = Console.ReadLine();
            Console.WriteLine("Province: ");
            string province = Console.ReadLine();
            Console.WriteLine("Country: ");
            string country = Console.ReadLine();
            Console.WriteLine(); //extra line to help make the output more aesthetic

            Residence residence = new Residence(streetName, cityName, zipCode, province, country);
           
            Console.WriteLine("Are you a base salary employee? Y/N");
            string answer = Console.ReadLine().ToUpper(); // used Google to help me find code to fix
                                                          // the upper/lower case issue
            if (answer == "Y")
            {
                Employee employee = new Employee(firstName, lastName, residence);
                employees.Add(employee);

                Console.WriteLine("Employee added successfully.");

            }

            else if(answer == "N")
            {
                Console.WriteLine("Annual Salary: ");
                int annualSalary = Convert.ToInt32(Console.ReadLine());
                Employee employee = new Employee(firstName, lastName, annualSalary, residence);
                employees.Add(employee);

                Console.WriteLine("Employee added successfully.");
            }

            else { Console.WriteLine("Bad Input! Please enter either 'Y' or 'N'."); }


            Console.WriteLine(); //extra line to help make the output more aesthetic

        }
        private static void create_PayRoll() //Generates the payroll for the current month 
        {
            Console.WriteLine();
            Console.WriteLine("Generating Payroll for Current Month:");
            Console.WriteLine();
            Console.WriteLine("Each Employee Salary: ");

            int totalPayroll = 0;
            foreach (Employee employee in employees)
            {
                int monthlySalary = employee.EmpAnnualSalary / 12; // divide the annual salary by 12
                                                                   // to get the monthly salary
                Console.WriteLine($"Employee ID: {employee.EmpID}");
                Console.WriteLine($"Employee: {employee.EmpFirstName} {employee.EmpLastName}");
                Console.WriteLine($"Annual Salary: {employee.EmpAnnualSalary:N2}");
                Console.WriteLine($"Monthly Salary: {monthlySalary:N2}");
                Console.WriteLine();
                totalPayroll += monthlySalary;
            }

            Console.WriteLine($"Total Payable to Employees this Month: {totalPayroll:N2}");
            Console.WriteLine(); //extra line to help make the output more aesthetic

        }
        private static void employee_Info() //Searches for an employee the ID inputted by the user
                                            //displays their information
        {
            Console.WriteLine(); //extra line to help make the output more aesthetic
            Console.WriteLine("Enter Employee ID: ");
            int empID = Convert.ToInt32(Console.ReadLine());

            Employee employee = null;

            foreach (Employee emp in employees)
            {
                if (emp.EmpID==empID)
                {
                    employee = emp;
                    break;
                }
            }

            if (employee != null)
            {
                // IF Employee is found
                Console.WriteLine($"Employee Found: ");
                Console.WriteLine(employee.ToString());
                Console.WriteLine(); //extra line to help make the output more aesthetic

            }

            else
            {
                //IF Employee is not found
                Console.WriteLine("Employee Not Found");
                Console.WriteLine(); //extra line to help make the output more aesthetic
            }

        }

    }
}
