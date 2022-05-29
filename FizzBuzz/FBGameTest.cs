using System;

namespace FizzBuzz
{
    class FBGameTest
    {
        static void Main(string[] args)
        {
            foreach (String s in new FBGame().fbList)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
