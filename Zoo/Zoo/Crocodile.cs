using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interface;

namespace Zoo
{
    public class Crocodile : Reptile , ISwim , IJump
    {
        public override string sound { get; set; } = "Growls";
        public override string eat { get; set; } = "Meat";

        public Crocodile(string sound, string eat)
        {
            this.sound = sound;
            this.eat = eat;
        }

        public string CanJump()
        {
            return "I can jump just in the water";
        }

        public string CanSwim()
        {
            return "I can swim and I live in the water";
        }

        public override void Eat()
        {
            Console.WriteLine($"I eat {this.eat}");
        }

        public override void LayEggs()
        {
            Console.WriteLine("I lay eggs");
        }

        public override string Sound()
        {
            return $"{this.sound}";
        }       
    }
}
