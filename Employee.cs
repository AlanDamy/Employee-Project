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
 */
    class Employee //the class that holds all employee info
    {
        private int empID; //any data needs some unique id for fetching the information
        private string empFirstName;
        private string empLastName;
        private int empAnnualSalary;
        private Residence empResidence;
        private static int IDGenerator = 0; 
        public string EmpFirstName { get => empFirstName; set => empFirstName = value; }
        public string EmpLastName { get => empLastName; set => empLastName = value; }
        public int EmpAnnualSalary { get => empAnnualSalary; set => empAnnualSalary = value; }
        public int EmpID { get => empID; }
        internal Residence EmpResidence { get => empResidence; set => empResidence = value; }

        public Employee(string empFirstName, string empLastName, int empAnnualSalary, Residence empResidence)
        {
            this.empID = ++IDGenerator;
            this.empFirstName = empFirstName;
            this.empLastName = empLastName;
            this.empAnnualSalary = empAnnualSalary;
            this.empResidence = empResidence;
        }
        public Employee( string empFirstName, string empLastName, Residence empResidence)
        {
            this.empID = ++IDGenerator;
            this.empFirstName = empFirstName;
            this.empLastName = empLastName;
            this.empAnnualSalary = 60000; // for base salary employees
            this.empResidence = empResidence;
        }

        public override string ToString()
        {
            return $"" +
                $"Employee ID: {empID}\n" +
                $"Name: {empFirstName} {empLastName}\n" +
                $"Annual Salary: {empAnnualSalary:N2}\n" +
                $"Residence: " +
                $"{empResidence}" +
                $"";
        }
    }
}
