using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class Used_Car : Car
    {
        double miles;

        public Used_Car() : this("default", "default", 0, 0 , 0)
        {

        }

        public Used_Car(string make, string model, int year, double price, double miles) : base(make, model, year, price)
        {
            this.miles = miles;
        }

        public override string PrintCar()
        {           
            string print = base.PrintCar() +  "   Used " +string.Format("{0,10} Miles", miles);
            return print;
        }
    }
}
