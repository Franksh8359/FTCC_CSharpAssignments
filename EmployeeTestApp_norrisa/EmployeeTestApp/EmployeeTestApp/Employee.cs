using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTestApp
{
    class Employee
    {
        private string _name;
        private int _idNumber;
        private string _department;
        private string _position;

        public string Name {
            get
            {
                return _name;
            }
            set 
            {
                _name = value;
            }
        }
        public int IdNumber { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }

        public Employee()
        {
            Name = "";
            IdNumber = 0;
            Department = "";
            Position = "";
        }

        public Employee(string employeeName)
        {
            Name = employeeName;
            IdNumber = 0;
            Department = "";
            Position = "";

        }

    }
}
