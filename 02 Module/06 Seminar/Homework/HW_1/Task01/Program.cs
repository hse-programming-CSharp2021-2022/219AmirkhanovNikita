using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

namespace Task01
{

    class RandomException : Exception
    {
        public RandomException()
        {
        }

        public RandomException(string message) : base(message)
        {
        }

        public RandomException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RandomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ЧИсло от 1 до 10");
            try
            {
                int c = int.Parse(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        int b = 0;
                        int a = 1 / b;
                        break;
                    case 2:
                        var txt = File.ReadAllText("lulz");
                        break;
                    case 3:
                        string x = null;
                        x.Split();
                        break;
                    case 4:
                        var d = new Dictionary<string, string>();
                        var dd = d["no"];
                        break;
                    case 5:
                        var e = new int[1];
                        var ee = e[1];
                        break;
                    case 6:
                        var dirs = Directory.GetFiles("no path aaaa");
                        break;
                    case 7:
                        var xtx = File.ReadAllText(null);
                        break;
                    case 8:
                        var arr = new int[1];
                        dynamic val = "a";
                        arr[0] = val;
                        break;
                    case 9:
                        var ergfrg = TimeZoneInfo.FindSystemTimeZoneById("4t34gt4");
                        break;
                    case 10:
                        throw new RandomException("rnd");
                        break;
                }
                
                
                
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Я поймал {ex.GetType()}");
            }
        }
    }
}
