using System;

namespace ovn6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] temp = new int[20];
            Array.Copy(digits, temp, digits.Length);
            digits = temp;
            int num = 11;
            for (int i = 10; i < 15; i++)
            {
                digits[i] = num;
                num++;
            }
            temp[18] = 666;
            foreach (int digit in digits)
            {
                Console.Write(digit + ", ");
            }
            Console.WriteLine("");
            foreach (int digit in temp)
            {
                Console.Write(digit + ", ");
            }
        }
    }
}
