using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_and_ProductionWorker_Classes
{
    class ProductionWorker : Employee
    {
        private int _shift;
        private double _payRate;

        public ProductionWorker()
        {
            _shift = 0;
            _payRate = 0;
        }

        public int Shift
        {
            get { return _shift; }
            set { _shift = value; }
        }
        public double PayRate
        {
            get { return _payRate; }
            set { _payRate = value; }
        }

    }
}
