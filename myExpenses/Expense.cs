using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myExpenses
{
    

    class Expense
    {
        private string _category;
        private double _cost;
        private DateTime _incurredDate;
        

        public string Category { get { return _category; } set { _category = value; } }
        public double Cost
        {
            get { return _cost; }
            set
            {
                if (value > 0 || value <= 100)
                {
                    _cost = value;
                }
                else
                {
                    _cost = 0.01;
                }
            }
        }

        public DateTime IncurredDate { get { return _incurredDate; } set { _incurredDate = value; } }

            public override string ToString()
        {
            return string.Format("{0}: €{1:f2} on {2}", Category, Cost, IncurredDate.Date);
        }
    }  // end class
}  // end ns
