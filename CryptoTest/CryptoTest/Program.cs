namespace CryptoTest
{
    using System;
    using System.IO;
    using System.Security.Cryptography;
    using System.Text;

    internal class Program
    {   
        static void Main(string[] args)
        {
            LoginHandler myUsers = new();
            User user= new User();

            myUsers.Run();
        }

        

        
        public static bool CompareByteArrays(byte[] array1, byte[] array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
            