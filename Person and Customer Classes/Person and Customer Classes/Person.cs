using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_and_Customer_Classes
{
    class Person
    {
        private string _name;
        private string _address;
        private string _number;

        public Person()
        {
            _name = "";
            _address = "";
            _number = "";
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }

    }
}
