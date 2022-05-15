using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHandler
{
    internal class Electrical:Garage
    {
        public override void HandleRequest(Car car)
        {
            grade = random.Next(0, 11);
            if (grade > 5)
            {
                car.NeedsRepair = false;
                Console.WriteLine("was repaired after an electrical inspection");
            }
            else
                next.HandleRequest(car);
        }
    }
}
