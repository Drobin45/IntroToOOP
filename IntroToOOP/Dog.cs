using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Dog
    {
        //Create a Dog class
        //Your dog class should have fields for hair length, height, running speed and weight
        //Your class should have the following behaviors: run, bork, potty, cuddle.
        //Create at least one constructor

        //Fields
        private string hairLength;
        private int height;
        private int runningSpeed;
        private double weight;
        private bool crap = true;


        //Properties  (for fields)

        public string HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        //Shorthand, creates field and does most of what the above does. However longhand does give more flexability
        public double BarkVolume { get; set; }

        //Constructor (two separate examples!)

        public Dog()
        {
            //This is my default constructor
        }

        public Dog(string hairLength, int height, int runningSpeed, double weight)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }


        //Behaviors



        public int Run()
        {
            Console.WriteLine("Go Doggo, go!");
            RunningSpeed += 1;
            return RunningSpeed;
        }

        public void Bark()
        {
            Console.WriteLine("Bork bork bork!");
        }

        public void Potty()
        {
            if(crap == true)
            {
                Console.WriteLine("Your doggo just soiled your carpet.");
                weight -= 1.0;
            }
            else
            {
                Console.WriteLine("Your doggo needs to go! Hurry before he/she soils your carpet!");
                weight += 1.0;
            }
        }

        public void Cuddle()
        {
            Console.WriteLine("Aww, doggo is so sweet.");
        }


    }
}
