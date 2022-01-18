using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollProgram
{
    public class Employee
    {
        public string name;
        public string position;
        public int salary;

        public Employee(string name, string position, int salary)
        {
            this.name = name;
            this.position = position;
            this.salary = salary;
        }
    }
}
