using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CD_Account_Test
{
    class CDAccount : SavingsAccount
    {
        private string _maturityDate;

        public CDAccount()
        {
            _maturityDate = "";
        }

        public string MaturityDate
        {
            get { return _maturityDate; }
            set { _maturityDate = value; }
        }

    }
}
