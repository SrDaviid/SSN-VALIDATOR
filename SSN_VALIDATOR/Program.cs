using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSN_VALIDATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                string SSN;
                SSN = Console.ReadLine();

                if (SSN.Length != 11)
                {
                    throw new Exception("The length is not correct");
                }

                string[] NumberInString = SSN.Split('-');

                int FirstPart = Convert.ToInt32(NumberInString[0]);
                if (FirstPart <= 0 || FirstPart == 666 || FirstPart >= 999)
                {
                    throw new Exception("Your SSN is not valid");
                }

                int SecondPart = Convert.ToInt32(NumberInString[1]);
                if (SecondPart <= 0 || SecondPart >= 100)
                {
                    throw new Exception("Your SSN is not valid");
                }

                int ThirdPart = Convert.ToInt32(NumberInString[2]);
                if (ThirdPart <= 0 || ThirdPart >= 10000)
                {
                    throw new Exception("Your SSN is not valid");
                }

                Console.WriteLine("Your SSN is correct");
            }

            catch(Exception error)
            {
                Console.WriteLine("Error: " + error.Message);
            }

            Console.ReadLine();


        }
    }
}
