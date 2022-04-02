using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interface;

namespace Zoo
{
    public abstract class Birds : Animal
    {
        abstract public bool canFly { get; set; }
        abstract public string beakColor { get; set; }

        public override void Wings()
        {
            base.Wings();
        }

        public abstract string BeakColor();

        public virtual bool Fly(bool canfly) 
        {
            if (canFly)
            {
                Console.WriteLine("Yes I can fly");
                return true;
            }
            else
            {
                Console.WriteLine("No i Cannot fly");
                return false;
            }
        }        
    }
}
