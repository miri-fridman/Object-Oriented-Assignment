using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Assignment_Animals
{
    public class Dog : Animal, Land
    {
        private int numberOfLegs=4;

        public Dog(int mood) : base(true, true, mood)
        {
        }
        public Dog(bool mammals, bool carnivorous, int mood) : base(true, true, mood)
        {

        }

        public void sayHello()
        {
            Console.WriteLine("wagging their tails");
        }

        public void sayHello(int mood)
        {
            switch (mood)
            {
                case MOOD_HAPPY:
                    Console.WriteLine("bark loudly");
                    break;
                case MOOD_SCARE:
                    Console.WriteLine("whooping");
                    break;
                default:
                    throw new Exception("ERROR: invalid mood");
            }
        }
        public int GetNumberOfLegs()
        {
            return numberOfLegs;
        }
    }
}
