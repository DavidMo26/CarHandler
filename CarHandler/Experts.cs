using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHandler
{
    internal class Experts:Garage
    {
        public override void HandleRequest(Car car)
        {            
                car.NeedsRepair = false;
                Console.WriteLine("was repaired after expert inspection");                        
        }
    }
}
