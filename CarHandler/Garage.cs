using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHandler
{
    abstract class Garage
    {
        protected Garage next;
        protected Random random = new Random();
        protected int grade;

        public void SetNext(Garage next)
        {
            this.next = next;
        }
        public abstract void HandleRequest(Car car);
    }
}
