namespace Cars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Tesla : Car
    {
        public int Cameras { get; set; } = 4;
        public int Sensors { get; set; } = 87;
        public string AiVersion { get; set; } = "Dumdum mk. 1";
        
        public Tesla()
        {
            Manufacturer = "Tesla";
        }

        public void ActivateAI()
        {
            if (AiVersion == "Dumdum mk. 1") Console.WriteLine("Ai goes \"Errr.... doh?\".");
            else Console.WriteLine("AI online.");
        }
        public void DeactivateAI()
        {
            if (AiVersion == "Dumdum mk. 1") Console.WriteLine("Ai goes \"Errr.... buh-bye?\".");
            else Console.WriteLine("AI offline.");
        }
        public void SelfTest()
        {
            if (Cameras > 0 && Sensors > 0 && !String.IsNullOrEmpty(AiVersion))
            {
                if (AiVersion == "Dumdum mk. 1") Console.WriteLine("Cameras and sensors OK, AI is operating but for your own safety should be updated.");
                else Console.WriteLine("Cameras and sensors OK, AI system integrity OK.");
            }
            else Console.WriteLine("Self check failed, please call for assistance.");
        }
        public void UpdateFirmware()
        {
            AiVersion = "Dumdum mk. 2";
            Console.WriteLine("Firmware updated to " + AiVersion + ".");
        }
    }
}
