using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollProgram
{


    public partial class Form1 : Form
    {
        public Employee[] employeeList =
        {
            new Employee("Jose Jerome Lalunio", "Software Engineer", 65000),
            new Employee("Elliot Alderson", "Cybersecurity Engineer", 95000),
            new Employee("Angela Moss", "Account Executive", 75000),
            new Employee("Tyrell Wellick", "Senior Vice President of Technology", 125000),
        };

        public int companyBalance = 1000000;

        public Form1()
        {
            InitializeComponent();
            balanceField.Text = companyBalance.ToString();
            BuildList();
        }

        private void BuildList()
        {
            for (int i = 0; i < employeeList.Length; i++)
            {
                Employee current = employeeList[i];
                Button button = new Button
                {
                    Height = 50,
                    AutoSize = true,
                    Margin = new Padding(16),
                    Text = current.name + " | " + current.position,
                    Dock = DockStyle.Top,
                    Font = new Font("MV Boli", 16),
                    BackColor = Color.Transparent,
                };


                button.Click += (s, e) =>
                {
                    if (current.salary > companyBalance)
                    {
                        MessageBox.Show("The Company has run out of funds to pay the employees OOOOOFF!");
                    }
                    else
                    {
                        MessageBox.Show("succesfully paid " + current.name + " " + current.salary);
                        companyBalance -= current.salary;
                        balanceField.Text = companyBalance.ToString();
                    }
                };

                employeePanel.Controls.Add(button);
                employeePanel.Controls.Add(new Panel { Height = 20, Width = 20, Dock = DockStyle.Top, BackColor = Color.Transparent });
            }
        }
    }
}
