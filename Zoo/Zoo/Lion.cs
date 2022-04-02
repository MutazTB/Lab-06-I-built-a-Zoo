using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interface;

namespace Zoo
{
    public class Lion : Mammal , ISwim , IJump
    {
        public override string sound { get; set; } = "Roar";
        public override string eat { get; set; } = "Meat";

        public Lion(string sound) 
        {
            this.sound = sound;
        }

        public override void Eat()
        {
            Console.WriteLine($"I eat {this.eat}");
        }

        public override string Hibernate()
        {
            return "I do NOT hibernate during winter";
        }

        public override string Sound()
        {
            return $"I go {this.sound}";
        }

        public override void Hunt()
        {
            //base.Hunt();
            Console.WriteLine("Yes I am a hunter");
        }

        public string CanSwim()
        {
            return "I am a cat but i can swim";
        }

        public string CanJump()
        {
            return "I can jump more than 2 metters";
        }
    }
} 