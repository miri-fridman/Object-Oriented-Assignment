using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Assignment_Animals
{
    public class Dog : Animal, Land
    {
        private int numberOfLegs = 4;

        //The attributes mammal and carnivore are known in advance,
        //therefore, in my opinion, there is no need to receive these attributes in the Dog ctor,
        //they can be automatically sent to the Animal ctor like this:
        public Dog(int mood) : base(true, true, mood)
        {
        }

        //I added this function according to the class diagram, but in my opinion it is unnecessary
        public Dog(bool mammals, bool carnivorous, int mood) : base(true, true, mood)
        {

        }

        override public void sayHello()
        {
            Console.WriteLine("wagging their tails");
        }

        override public void sayHello(int mood)
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
