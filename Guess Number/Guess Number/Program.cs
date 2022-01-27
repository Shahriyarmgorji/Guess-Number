using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_Number
{
    class Program
    {
        static int[] Input = new int[4];//Vared Kardan Adadd
        static Random Number = new Random();
        static int[] guessNumber = new int[4];//guessNumber
        public static string FullNane;

        static void allnumbers()
        {

            guessNumber[0] = Number.Next(1, 10);
            guessNumber[1] = Number.Next(0, 10);
            guessNumber[2] = Number.Next(0, 10);
            guessNumber[3] = Number.Next(0, 10);

            //sakht adad 4 raghami tasadofi
            //_________________________________________

        }
        static void get()
        {
            try
            {
                Input[0] = Convert.ToInt32(Console.ReadLine());
                Input[1] = Convert.ToInt32(Console.ReadLine());
                Input[2] = Convert.ToInt32(Console.ReadLine());
                Input[3] = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Wrong Number." + "\n");
            }
        }

        static void Main(string[] args)
        {
            #region Random
            for (;;)
            {
                if (guessNumber[0] == guessNumber[1] || guessNumber[0] == guessNumber[2] || guessNumber[0] == guessNumber[3] || guessNumber[1] == guessNumber[2] || guessNumber[1] == guessNumber[3] || guessNumber[2] == guessNumber[3])
                {
                    allnumbers();

                }
                else
                {
                    break;
                }
            }
            //sharte tekrari naboodan adad tasadofi
            //__________________________________________________________________________________
            #endregion

            get();
            for (;;)
            {
                Console.ResetColor();
                Console.Write(Input[0]);
                Console.Write(Input[1]);
                Console.Write(Input[2]);
                Console.WriteLine(Input[3]);
                Console.Write("=> ");

                if (Input[0] == 0)
                {
                    Console.WriteLine("Wrong Number");
                }

                if (Input[0] == guessNumber[0])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(Input[0]);

                }

                else if ((Input[0]) == guessNumber[1] | Input[0] == guessNumber[2] | Input[0] == guessNumber[3])
                {
                    //Console.Write(Input[0] = Convert.ToInt32(Console.ForegroundColor = ConsoleColor.Yellow));
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(Input[0]);

                }
                else if (Input[0] != guessNumber[0] | Input[0] != guessNumber[1] | Input[0] != guessNumber[2] | Input[0] != guessNumber[3])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(Input[0]);

                }
                //+++++++++++++++
                if (Input[1] == guessNumber[1])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(Input[1]);

                }
                else if (Input[1] == guessNumber[0] | Input[1] == guessNumber[2] | Input[1] == guessNumber[3])
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(Input[1]);

                }
                else if (Input[1] != guessNumber[0] | Input[1] != guessNumber[1] | Input[1] != guessNumber[2] | Input[1] != guessNumber[3])
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(Input[1]);

                }
                //+++++++++++++++
                if (Input[2] == guessNumber[2])
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(Input[2]);
                }
                else if (Input[2] == guessNumber[0] | Input[2] == guessNumber[1] | Input[2] == guessNumber[3])
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(Input[2]);
                }
                else if (Input[2] != guessNumber[0] | Input[2] != guessNumber[1] | Input[2] != guessNumber[2] | Input[2] != guessNumber[3])
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(Input[2]);

                }
                //+++++++++++++++
                if (Input[3] == guessNumber[3])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(Input[3]);

                }
                else if (Input[3] == guessNumber[0] | Input[3] == guessNumber[1] | Input[3] == guessNumber[2])
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(Input[3]);

                }
                else if (Input[3] != guessNumber[0] | Input[3] != guessNumber[2] | Input[3] != guessNumber[3] | Input[3] != guessNumber[1])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Input[3]);

                }


                if (Input[0] != guessNumber[0] | Input[1] != guessNumber[1] | Input[2] != guessNumber[2] | Input[3] != guessNumber[3])
                {
                    get();
                }
                else if (Input[0] == guessNumber[0] & Input[1] == guessNumber[1] & Input[2] == guessNumber[2] & Input[3] == guessNumber[3])
                {

                    Console.Write("\n" + "You Win ...! " + "\n" + "adad Nahayi :");
                    Console.Write(guessNumber[0]);
                    Console.Write(guessNumber[1]);
                    Console.Write(guessNumber[2]);
                    Console.Write(guessNumber[3]);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
