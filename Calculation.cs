using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Server
{
    class Program
    {


        static void Main(string[] args)
        {
            //asking for room size
            Console.WriteLine("Hello! And welcome to your Floor-Size Finder!");

            //L shaped?
            while (true) {
                Console.WriteLine("Is your room L shaped? (y/n)");
                string shape = Console.ReadLine();
                Console.WriteLine("");

                if (shape == "y")
                { 

                    //if so then put in lengths and widths.
                    Console.WriteLine("Okay! First then Give me the Length and Width of your two longest walls!");
                    Console.WriteLine("");

                    Console.WriteLine("Length");
                    string length1 = Console.ReadLine();
                    Console.WriteLine("");

                    Console.WriteLine("Width");
                    string width1 = Console.ReadLine();
                    Console.WriteLine("");

                    Console.WriteLine("Now the Length and Width of the two Smaller walls.");
                    Console.WriteLine("");

                    Console.WriteLine("Length");
                    string length2 = Console.ReadLine();
                    Console.WriteLine("");

                    Console.WriteLine("Width");
                    string width2 = Console.ReadLine();
                    Console.WriteLine("");

                    //change strings to int
                    int lengthFirst = int.Parse(length1);
                    int lengthSecond = int.Parse(length2);
                    int WidthFirst = int.Parse(width1);
                    int WidthSecond = int.Parse(width2);

                    //put it into a meathod
                    RoomL(lengthFirst, lengthSecond, WidthFirst, WidthSecond);
                    break;


                } else if (shape == "n")
                {
                    Console.WriteLine("Okay! Now Give me the Length and Width of your walls!");
                    Console.WriteLine("");

                    Console.WriteLine("Length");
                    string length3 = Console.ReadLine();
                    Console.WriteLine("");

                    Console.WriteLine("Width");
                    string width3 = Console.ReadLine();
                    Console.WriteLine("");

                    int lengthThird = int.Parse(length3);
                    int WidthThird = int.Parse(width3);

                    RoomN(lengthThird, WidthThird);
                    break;
                }
                else
                {
                    Console.WriteLine("How about you try that again?");
                    Console.WriteLine("");
                    continue;
                };
            }
            
            
        }
        static void RoomL(int lX, int lY, int wX, int wY)
        {
            int mathTotal = (lX * wX) - (lY * wY);
            Console.WriteLine("Your total space area " + mathTotal);

        }
        static void RoomN(int lZ, int wZ)
        {
            Console.WriteLine("Your total space area " + (lZ*wZ));
        }
    }
}

