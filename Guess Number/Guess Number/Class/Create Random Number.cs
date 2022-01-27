using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_Number
{
    class Create_Random_Number
    {
        static Random Number = new Random();
        static int[] RandNumber = new int[4];//RandNumber
        public string[] Input;

        public void RndNumber()
        {
            RandNumber[0] = Number.Next(1, 10);
            RandNumber[1] = Number.Next(0, 10);
            RandNumber[2] = Number.Next(0, 10);
            RandNumber[3] = Number.Next(0, 10);
        }
        public void CreateNumber()
        {
            #region Random
            for (;;)
            {
                if (RandNumber[0] == RandNumber[1] || RandNumber[0] == RandNumber[2] || RandNumber[0] == RandNumber[3] || RandNumber[1] == RandNumber[2] || RandNumber[1] == RandNumber[3] || RandNumber[2] == RandNumber[3])
                {
                    RndNumber();

                }
                else
                {
                    break;
                }
            }
            //sharte tekrari naboodan adad tasadofi
            //__________________________________________________________________________________
            #endregion
        }

        public void Get()
        {
            Input = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToString);
            byte FirstDigit = byte.Parse(Input[0]);
            byte SecondDigit = byte.Parse(Input[1]);
            byte ThirdDigit = byte.Parse(Input[2]);
            byte FourthDigit = byte.Parse(Input[3]);
        }
    }
}
