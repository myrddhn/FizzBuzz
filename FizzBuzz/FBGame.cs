using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class FBGame
    {
        public List<String> fbList{ get; }

        public FBGame()
        {
            fbList = new List<string>();
            for (int n = 1; n <= 20; n++)
                fbList.Add(((n % 3 == 0) && (n % 5 == 0)) ? "FizzBuzz" : (n % 3 == 0) ? "Fizz" : (n % 5 == 0 ?  "Buzz" : n.ToString()));
        }
    }
}
