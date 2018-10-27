using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.	Compare and contrast the if single-selection statement and the while repetition statement.  How are these two statements similar?  How are they different? (2 Points).
//      The if and while statement are similar in that they both perform actions based on whether a condition is true or false; but they are different in that the if statememt
//      performs a single action if the condition is true, and the while statement continues to perform an action as long as the condition is true.
namespace CrozierLabW6
{
    //2.	Declare two int variables: 1) speedLimit and 2) speed.Assign values speedLimit=35 and speed = 42.Write an if statement that displays “SLOW NOW” if speed
    //      is greater than speedLimit. (2 points) 
    //class Program
    //{
    //static void Main(string[] args)
    //{
    //    int speedLimit;
    //    int speed;

    //    speedLimit = 35;
    //    speed = 42;

    //    if (speed > speedLimit) ;
    //    {
    //        Console.WriteLine("SLOW NOW");
    //    }
    //}
    //}


    //3.	if-else statement - Write a program that declares and assigns a value to a Boolean variable called isTrue.Use a condition to output “It is True!” 
    //      or “It is False!” based on the assigned value.Paste your code and screenshots of your program running with both true and false values(3 points).
    //      Example: bool isTrue = true;
    //               bool isTrue = false;

    //class Program
    //{
    //  static void Main(string[] args)
    //  {
    //      bool isTrue;
    //      bool isFalse;

    //      isTrue = true;
    //      isFalse = false;

    //      if (isTrue = true);
    //      {
    //          Console.WriteLine("It is True!");
    //      }

    //  }

    //}



    //  4.	if statement - Write a program that converts a Fahrenheit temperature to Celsius.  The user should be able to input the temperature at the Command prompt 
    //      and it should output the temperature.  In addition, you should output “It is cold” if the Fahrenheit value is less that 40 or it should output “It is hot” if 
    //      the temperature is over 90 (4 points). Code to read a value: double fahrenheit = Convert.ToDouble(Console.ReadLine()); 
    //      Code to convert: celsius  = (fahrenheit - 32d) * 5d / 9d;
    //class Program
    //{
    //    static void Main (String[] args)
    //    {
    //        double celsius;
    //        Console.Write("Enter Fahrenheit temperature : ");
    //        double fahrenheit = Convert.ToDouble(Console.ReadLine());
    //        celsius = (fahrenheit - 32) * 5 / 9;
    //        Console.WriteLine("The converted Celsius temperature is" + celsius);
    //        Console.ReadLine();
    //        if (fahrenheit < 40) 
    //        {
    //            Console.WriteLine("It is cold");

    //        }
    //        else
    //        {
    //            Console.WriteLine("It is hot");
    //        }                       
    //}
    //}


    //5.	Write a while loop that outputs values 1-10.  Increment by 1 (3 points).
    //class Program
    //{
    //    static void Main (String[] args)
    //    {
    //        int i;
    //        i = 1;

    //        while (i < 11) 
    //        {
    //            Console.WriteLine(i);
    //            i = i + 1;
    //        }
    //    }
    //}


    //6.	Write a while loop that outputs values 60 to 20.  Decrement by 1 (3 points)

    //class Program
    //{
    //    static void Main (String[] args)
    //    {
    //        int i;
    //        i = 60;

    //        while (i > 19)
    //        {
    //            Console.WriteLine(i);
    //            i = i - 1;
    //        }
    //    }
    //}


//7.	Create a while that outputs values 10-20 (3 points).

    class Program
    {
        static void Main (String[] args)
        {
            int i;
            i = 10;

            while(i < 21)
            {
                Console.WriteLine(i);
                i = i + 1;
            }
        }
    }       

}
