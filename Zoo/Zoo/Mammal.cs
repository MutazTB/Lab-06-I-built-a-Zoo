using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public abstract class Mammal : Animal
    {
        public bool HasFur { get; set; }
            
        public abstract string Hibernate();// سبات شتوي 

        public virtual void Hunt()
        {
            Console.WriteLine("Where is my food?");
        }

        public string KeepWarm(bool fur)
        {
            return "This fur keeps me warm :D";
        }
    }
}
