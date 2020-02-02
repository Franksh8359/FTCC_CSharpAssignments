using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_and_Customer_Classes
{
    class Customer : Person
    {
        private int _idNo;
        private bool _mailList;

        public Customer()
        {
            _idNo = 0;
            _mailList = false;
        }

        public int IDNo
        {
            get { return _idNo; }
            set { _idNo = value; }
        }

        public bool MaiList
        {
            get { return _mailList; }
            set { _mailList = value; }
        }

    }
}
