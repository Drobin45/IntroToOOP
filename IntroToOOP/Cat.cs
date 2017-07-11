using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Cat
    {
        //Field (variable that belongs to a class) example
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;

        //Property example
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }

        }

        //Constructor (specialized method) example
        public Cat()
        {
            //This is an example of a default constructor. A default constructor takes no arguments/parameters.
        }

        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }

        public void Eat()
        {
            if (isHungry)
            {
                isHungry = false;
            }
            Console.WriteLine("Is the cat hungry? " + isHungry);
        }

    }
}
