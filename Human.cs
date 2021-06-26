using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAProject
{
   public class Human
    {
        public static int X = 0;
        public static void Walk(string action)
        {
            Console.WriteLine(action + X );
        }
    }
}
