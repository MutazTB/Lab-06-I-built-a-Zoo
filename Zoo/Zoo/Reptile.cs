using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class Reptile : Animal 
    {
        public abstract void LayEggs();

        public virtual String Food() 
        {
            return "Food";
        }
    }
}
