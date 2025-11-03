using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk05_a1_lidl
{
    internal class ChatBot: IPublish
    {
        public void Publiziere(string text)
        {
            Console.WriteLine($"{text}");
        }
    }
}
