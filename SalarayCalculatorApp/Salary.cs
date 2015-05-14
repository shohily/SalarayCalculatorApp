using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarayCalculatorApp
{
    class Salary
    {
        public string employeeName;
        public double basicamount;
        public double rent;
        public double medical;

        public double GetRent()
        {
            return (basicamount/100)*rent;
        }

        public double GetAllowance()
        {
            return (basicamount/100)*medical;
        }

        public double GetSalary()
        {
            return basicamount + GetRent() + GetAllowance();
        }

    }
}
