using System;

namespace decimalConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] a = Console.ReadLine().Split();
            int notation = int.Parse(a[1]) , decim = int.Parse(a[2]);
            if (notation != 10)
            {
                Console.Write(Convert.ToInt64(a[0],notation));
            }
            else 
            {
                Console.Write(Convert.ToString(int.Parse(a[0]), decim));
            }

        }
    }
}
