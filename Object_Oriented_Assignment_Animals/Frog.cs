using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Assignment_Animals
{
    public class Frog : Animal, Land, Water
    {
        private int numberOfLegs = 4;

        //The attributes mammal and carnivore are known in advance,
        //therefore, in my opinion, there is no need to receive these attributes in the Frog ctor,
        //they can be automatically sent to the Animal ctor like this:
        public Frog(int mood) : base(false, false, mood)
        {
        }

        //I added this function according to the class diagram, but in my opinion it is unnecessary
        public Frog(bool mammals, bool carnivorous, int mood) : base(false, false, mood)
        {
        }

        public bool hasGills()
        {
            return true;
        }

        public bool hasLaysEggs()
        {
            return true;
        }

       override public void sayHello(int mood)
        {
            switch (mood)
            {
                case MOOD_HAPPY:
                    Console.WriteLine("quack quack quack");
                    break;
                case MOOD_SCARE:
                    Console.WriteLine("plop into the water");
                    break;
                default:
                    throw new Exception("ERROR: invalid mood");
            }
        }

        public int GetNumberOfLegs()
        {
            return numberOfLegs;
        }

        public override void sayHello()
        {
            Console.WriteLine("plop into the water");
        }
    }
}
