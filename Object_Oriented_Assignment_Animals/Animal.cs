using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Assignment_Animals
{
    public abstract class Animal
    {
        protected bool mammals;
        protected bool carnivorous;
        public const int MOOD_HAPPY = 0;
        public const int MOOD_SCARE = 1;
        protected int mood;
       
        public Animal(bool mammals, bool carnivorous, int mood)
        {
            this.mammals = mammals;
            this.carnivorous = carnivorous;
            switch(mood){
                case MOOD_HAPPY: 
                    this.mood = mood; 
                    break;
                case MOOD_SCARE: 
                    this.mood = mood; 
                    break;
                default: 
                    throw new Exception("ERROR: invalid mood");
            }
          
        }

        public void sayHello()
        {

        }

        public void sayHello(int mood)
        {

        }

        public bool isMammals()
        {
            return mammals;
        }

        public void setMammals(bool mammal)
        {
            this.mammals = mammal;
        }

        public bool isCarnivorous()
        {
            return carnivorous;
        }

        public void setCarnivorous(bool carnivorous)
        {
            this.carnivorous = carnivorous;
        }

    }
}
