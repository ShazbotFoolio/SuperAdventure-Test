using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Engine
{
    public static class RandomNumberGenerator
    {
        private static readonly RNGCryptoServiceProvider 
            generator = new RNGCryptoServiceProvider();

        public static int NumberBetween(int min, int max)
        {
            byte[] randomNumber = new byte[1];

            generator.GetBytes(randomNumber);

            double asciiValueOfRandomCharacter = Convert.ToDouble(randomNumber[0]);

            double multiplier =
            //Math.Max(0, asciiValueOfRandomCharacter / 255d) - 0.00000000001d; //This line was incorrect. Tue 07/30/201915:37:56.73 // was causing some weird problems with negative numbers sometimes showing up when calculating.
            Math.Max(0, (asciiValueOfRandomCharacter/255d) - 0.00000000001d); //this should fix. //Tue 07/30/201915:39:19.58

            int range = max - min + 1;

            double randomValueInRange = Math.Floor(multiplier * range);

            return (int)(min + randomValueInRange);
        }

    }
}
