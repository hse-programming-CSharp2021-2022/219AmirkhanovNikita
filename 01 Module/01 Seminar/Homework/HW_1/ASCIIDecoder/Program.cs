using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            byte code;
            if(byte.TryParse(Console.ReadLine(),out code))
                Console.WriteLine((char)code);
        }
    }
}
