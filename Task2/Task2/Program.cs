using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Takes in the users input
            int input = 0;
            //Loop untill user input 1 of the 3 options
            while (input != 3)
            {
                Console.Clear();//Clears the screen
                Console.WriteLine("Please choose from the following options:");
                Console.WriteLine("Press 1 to find the area of a circle.");
                Console.WriteLine("Press 2 to find the area of a square.");
                Console.WriteLine("Press 3 to exit.");
                //Checks if its a valid input
                bool check = int.TryParse(Console.ReadLine(), out input);
                if (!check)
                {
                    while (!check)//loops until a number is input
                    {
                        Console.Clear();//Clears the screen.
                        Console.WriteLine("There was a problem with your input, please try again. ");
                        Console.WriteLine("Press 1 to find the area of a circle.");
                        Console.WriteLine("Press 2 to find the area of a square.");
                        Console.WriteLine("Press 3 to exit.");
                        check = int.TryParse(Console.ReadLine(), out input);
                    }
                }
                //Call the Circle class and methods
                if (input == 1)
                    Circle.GetCircleValues();
                //Call the Square class and methods
                else if (input == 2)
                    Square.GetSquareValues();
                //Exit
                else if (input == 3)
                    break;
            }
        }
    }
    public class Circle
    {
        public static void GetCircleValues ()
        {
            //Variable to hold the circle diameter
            float diameter;

            //Ask the user for the circle diameter
            Console.WriteLine("Please enter the diameter of ther circle: ");

            //Using TryParse which returns a boolean showing whether the input was a number or not which is 
            //then used to display an error and loop until a valid input is input.
            bool check = float.TryParse(Console.ReadLine(), out diameter);
            if (!check)//if check = flase
                {
                while (!check)
                {
                    Console.Clear();//Clears the screen.
                    Console.WriteLine("There was a problem with your input, please enter the diameter: ");
                    check = float.TryParse(Console.ReadLine(), out diameter);
                }
            }

            //Calls the method to display the area
            CalcCircleArea(diameter);

            //Exiting msg
            Console.WriteLine("Please press enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        static void CalcCircleArea(float diameter)
        {
            //Get the radius
            float radius = diameter / 2;
            //Area = pi * radius squared
            double area = Math.PI * (radius * radius);
            //Dislplay the result
            Console.WriteLine($"The area of your circle is: {area}");
        }
    }
    public class Square
    {
        public static void GetSquareValues()
        {
            //Variable to hold the square side length
            float side;

            //Ask the user for the square side length
            Console.WriteLine("Please enter the length of the sides of your square: ");

            //Using TryParse which returns a boolean showing whether the input was a number or not which is 
            //then used to display an error and loop until a valid input is input.
            bool check = float.TryParse(Console.ReadLine(), out side);
            if (!check)
            {
                while (!check)
                {
                    Console.Clear();//Clears the screen.
                    Console.WriteLine("There was a problem with your input, please enter the length: ");
                    check = float.TryParse(Console.ReadLine(), out side);
                }
            }

            //Calls the method to display the area
            CalcSquareArea(side);

            Console.WriteLine("Please press enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        static void CalcSquareArea(float length)
        {
            Console.WriteLine("The area of your square is: " + (length * length));
        }
    }
    /********************************************************************************************/
    /*There are a number of things i could have done better in this app, what could you improve.*/
    /********************************************************************************************/
}
