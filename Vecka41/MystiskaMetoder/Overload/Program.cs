namespace Overload
{
    using System;
    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AdderaSymboler("abc"));
            Console.WriteLine(AdderaSymboler(43589656));
        }
        static public int AdderaSymboler(string text)
        {
            text=text.ToLower();
            text.Trim();
            int sum  =  0;
            
            for(int i=0; i< text.Length; i++)
            {
                int charValue = (int)text[i] - 96;
                sum   +=   charValue;
                Console.WriteLine(charValue);
            }

            return sum;
        }

        static public int AdderaSymboler(int tal)
        {
            string strTal = tal.ToString();
            int sum = 0;
            for(int i=0; i<strTal.Length; i++)
            {
                sum += int.Parse(strTal[i].ToString());
            }
            return sum;
        }
    }
}
                    