using System;
using System.Collections.Generic;

namespace Intro_to_OOP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] myArray = {1, 2, 3};
            int[] oldArray = myArray;

            myArray = new int[4];
            for (int index = 0; index < oldArray.Length; index++)
            {
                myArray[index] = oldArray[index];
            }

            myArray[3] = 42;
            List<string> toyList = new List<string>() {"action figure", "fake animal", "lego"};


            toyList.Add("Barbie");
            toyList.Add("remote car");
            toyList.Add("YoYo");
            toyList.Insert(0, "baby doll");

            foreach (string toys in toyList)
            {
                Console.WriteLine(toys);
            }

            List<bool> shelfStatus = new List<bool>() {true, false, true, true, false};
            for (int i = 0; i < shelfStatus.Count; i++)
            {
                if (shelfStatus[i] == true)
                {
                    Console.WriteLine("There are toys on this shelf");
                }
                else if (shelfStatus[i] == false)
                {
                    Console.WriteLine("This shelf is empty");
                }
                else
                {
                    Console.WriteLine("You broke the code!!!");
                }
            }

            Dictionary<string, int> studentGrades = new Dictionary<string, int>()
            {
                {"Mike", 90},
                {"Matt", 85},
                {"Michelle", 100}
            };
            Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            {
                {"A1", "Twix"},
                {"A2", "Twizzlers"},
                {"A3", "Hershey's"}
            };
            foreach (KeyValuePair<string, string> item in snackMachine)
            {
                Console.WriteLine(item);
            }

            Dictionary<int, string> drinkMachine = new Dictionary<int, string>();

            //Using the Add method to add drinks to the vending machine
            //This vending machine uses a number to access the items versus a
            //combination of numbers and letters (e.g. A4 in the snackMachine)

            drinkMachine.Add(10, "Ginger Ale");
            drinkMachine.Add(11, "Bottled Watter");
            drinkMachine.Add(12, "Orange Juice");
            drinkMachine.Add(13, "Fruit Punch");
            drinkMachine.Add(14, "Sparkling Water");
            drinkMachine.Add(15, "Sports Drink");

            Console.WriteLine(drinkMachine.Count);

            foreach (KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Key);
            }

            foreach (KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Value);
            }
        }

        public class Shape
        {
            private int sides;

            public Shape()
            {
                
            }

            public Shape(int sides)
            {
                this.sides = sides;
            }

            public int Sides
            {
                get { return this.sides; }
                set { this.sides = value; }
            }
        }
        
        //Example of Derived Class
        public class Rectangle : Shape
        {
            private double area;

            public Rectangle(double area)
            {
                this.area = area;
            }

            public double Area
            {
                get { return this.area; }
                set { this.area = value; }
            }

        }
    } 
}

