using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Eagle : Birds
    {
        public override bool canFly { get; set; } = true;        
        public override string sound { get; set; } = "Scream";
        public override string eat { get; set; } = "meat";
        public override string beakColor { get; set; } = "Yellow";

        public Eagle(bool canFly , string sound , string eat , string beakColor)
        {
            this.canFly = canFly;
            this.sound = sound;
            this.eat = eat;
            this.beakColor = beakColor;
        }

        public override string BeakColor()
        {
            return $"My beak color is {beakColor}";
        }

        public override void Eat()
        {
            Console.WriteLine("I eat meat");
        }

        public override bool Fly(bool canfly)
        {
           return base.Fly(canFly);           
        }

        public override string Sound()
        {
            return $"I go {this.sound}";
        }
    }
}
