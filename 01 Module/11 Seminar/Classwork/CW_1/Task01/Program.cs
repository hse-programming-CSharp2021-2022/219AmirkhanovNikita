using System;
using System.IO;
using System.Text;
using System.Linq;

namespace Task01
{
    class Program
    {
        
        static void Print(int[] arr)
        {
            foreach (var item in arr)
                Console.Write($"{item} ");
            Console.WriteLine();
        }

        static int countEven(int[] arr) => arr.Where(x => x % 2 == 0).Count();

        static int countOdd(int[] arr) => arr.Where(x => x % 2 != 0).Count();

        static void Main(string[] args)
        {
            string path = @"Data.txt";
            var rnd = new Random();
            Console.Write("Rows count: ");
            if (!uint.TryParse(Console.ReadLine(), out uint rows))
                return;
            // Создаем файл с данными
            if (File.Exists(path))
            {
                var lines = new string[rows];
                for (int i = 0; i < rows; i++)
                {
                    var sb = new StringBuilder();
                    for (int j = 0; j < 5; j++)
                    {
                        sb.Append(rnd.Next(10, 100));
                        if (j != 4)
                            sb.Append(' ');
                    }
                    lines[i] = sb.ToString();
                }
                
                File.WriteAllLines(path, lines, Encoding.UTF8);
            }

            // Open the file to read from
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                string[] stringValues = new string[lines.Length * 5];
                for (int i = 0; i < lines.Length; i++)
                {
                    var elems = lines[i].Split(' ');
                    for (int j = 0; j < 5; j++)
                    {
                        stringValues[i * 5 + j] = elems[j];
                    }
                }
                int[] arr = StringArrayToIntArray(stringValues);
                foreach (int i in arr)
                    Console.Write(i + " ");
                Console.WriteLine();
                // обрабатываем элементы массива
                // TODO2: Создать два массива по исходному
                // в первый поместить индексы чётных элементов, во второй - нечётных
                var even = new int[countEven(arr)];
                var odd = new int[countOdd(arr)];
                int ce = 0;
                int co = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        even[ce] = i;
                        ce++;
                    }
                    else
                    {
                        odd[co] = i;
                        co++;
                    }
                }
                // TODO3: Заменяем все нечётные числа исходного массива нулями
                for (int i = 0; i < co; i++)
                {
                    arr[odd[i]] = 0;
                }
                Print(arr);
            }
        } // end of Main()
        // преобразование массива строк в массив целых чисел
        public static int[] StringArrayToIntArray(string[] str)
        {
            int[] arr = null;
            if (str.Length != 0)
            {
                arr = new int[0];
                foreach (string s in str)
                {
                    int tmp;
                    if (int.TryParse(s, out tmp))
                    {
                        Array.Resize(ref arr, arr.Length + 1);
                        arr[arr.Length - 1] = tmp;
                    }
                } // end of foreach (string s in str)      
            }
            return arr;
        } // end of Strin
    }
}
