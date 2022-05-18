using System;

namespace decimalConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("변환할수? 변환할수의진수? 어떤진수로변환?");
            string[] a = Console.ReadLine().Split();
            int notation = int.Parse(a[1]), decim = int.Parse(a[2]);

            Console.Write("결과 : {0}", Convert.ToString(Convert.ToInt32(a[0], notation), decim));

        }
    }
}
