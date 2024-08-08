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

        //The attributes mammal and carnivore are known in advance,
        //therefore, in my opinion, there is no need to receive these attributes in the Cat ctor,
        //they can be automatically sent to the Animal ctor like this:
        public Cat(int mood) : base(true, true, mood)
        {
        }

        //I added this function according to the class diagram, but in my opinion it is unnecessary
        public Cat(bool mammals, bool carnivorous, int mood) : base(true, true, mood)
        {
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

        public int GetNumberOfLegs()
        {
            return numberOfLegs;
        }
    }
}
