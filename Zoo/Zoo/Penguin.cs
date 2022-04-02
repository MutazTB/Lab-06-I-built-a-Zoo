using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interface;

namespace Zoo
{
    public class Penguin : Birds , ISwim
    {
        public override bool canFly { get; set; } = false;
        public override string sound { get; set; } = "Bleat";
        public override string beakColor { get; set; } = "Orange";
        public override string eat { get; set; } = "Fish";

        public Penguin(bool canFly, string sound, string eat , string beakColor)
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

        public string CanSwim()
        {
            return "I can swim and I love it";
        }

        public override void Eat()
        {
            Console.WriteLine($"I eat {eat}");
        }

        public override bool Fly(bool canFly)
        {
            return base.Fly(canFly);           
        }        

        public override string Sound()
        {
            return $"I go {this.sound}";
        }
    }
}
