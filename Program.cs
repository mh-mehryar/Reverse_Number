using System;

namespace Revers_Number
{
    class Program
    {
                static void Main(string[] args)
        {
            
            int res = reversNum();
            Console.WriteLine("The Revers of Number you Entered is : "  + res);
        }
        public static int reversNum()
        {
            int num, reverse = 0, remain;
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                remain = num % 10;
                reverse = reverse * 10 + remain;
                num = num / 10;
            }
           
            return reverse;
        }
    }
}
