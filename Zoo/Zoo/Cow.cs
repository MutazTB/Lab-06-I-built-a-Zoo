using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Cow : Mammal 
    {
        public override string sound { get; set; } = "Moo";
        public override string eat { get; set; } = "Grass";

        public Cow(string sound , string eat)
        {
            this.sound = sound;
            this.eat = eat;
        }
        public override void Eat()
        {
            Console.WriteLine($"I eat {eat}");
        }

        public override string Hibernate()
        {
            return "I do NOT hibernate during winter";
        }

        public override string Sound()
        {
            return $"I go {this.sound}";
        }
        
    }
}
