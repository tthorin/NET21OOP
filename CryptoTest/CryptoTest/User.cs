namespace CryptoTest
{
    using System;

    public class User
    {
        public string Name { get; set; } = "";
        public byte[] Salt { get; set; } 
        public byte[] Password { get; set; }

        public override string ToString()
        {
            return $"{Name} {Convert.ToBase64String(Salt)} {Convert.ToBase64String(Password)}";
        }
    }
}