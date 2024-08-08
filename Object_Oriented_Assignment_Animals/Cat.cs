using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Assignment_Animals
{
    public class Cat : Animal, Land
    {
        private int numberOfLegs = 4;
        public Cat(int mood) : base(true, true, mood)
        {
        }

        public Cat(bool mammals, bool carnivorous, int mood) : base(true, true, mood)
        {
        }
        public int GetNumberOfLegs()
        {
            return numberOfLegs;
        }

        public void sayHello()
        {
            Console.WriteLine("meow~");
        }

        public void sayHello(int mood)
        {
            switch (mood)
            {
                case MOOD_HAPPY:
                    Console.WriteLine("purr, purr");
                    break;
                case MOOD_SCARE:
                    Console.WriteLine("hiss");
                    break;
                default:
                    throw new Exception("ERROR: invalid mood");
            }
        }

        int Land.GetNumberOfLegs()
        {
            return numberOfLegs;
        }
    }
}
