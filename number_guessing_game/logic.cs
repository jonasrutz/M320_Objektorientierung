using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_guessing_game
{
    internal class logic
    {

        static internal int number_random()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 11);
            return randomNumber;
        }

    }
}
