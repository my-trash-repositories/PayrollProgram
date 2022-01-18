using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollProgram
{
    class Employee
    {
        public string name;
        public string position;
        public int salary;
        public bool isPaid = false;

        Employee(string name, string position, int salary)
        {
            this.name = name;
            this.position = position;
            this.salary = salary;
        }
    }
}
