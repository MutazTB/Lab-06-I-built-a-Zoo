using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class Animal
    {
        abstract public string sound { get; set; }
        abstract public string eat { get; set; }

        public abstract void Eat();

        public abstract string Sound();

        public virtual void Wings() 
        {
            Console.WriteLine("I have a wings");
        }
    }
}
