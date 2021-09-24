namespace Cars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class SecretServiceCar:Car
    {
        public bool IsBulletProof { get; set; } = true;
        public int BombSensors { get; set; } = 3;
        public bool EggProofWindows { get; set; } = true;

        public void SelfExplode()
        {
            Console.WriteLine("Why would you want to blow up the secret service car, seriously?");
        }
        public void SelfCheck()
        {
            int errorCode = 0;
            if (BombSensors < 1) errorCode++;
            if (!IsBulletProof) errorCode += 2;
            if (!EggProofWindows) errorCode += 4;

            if (errorCode == 0) Console.WriteLine("System check OK.");
            else Console.WriteLine("Self check failed, please service the vehicle, Error Code: "+errorCode);
        }
        public void PlaySpotify()
        {
            Console.Beep();
            Console.WriteLine("Be-dum be-dum ba-da");
        }
    }
}
