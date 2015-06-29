using System;
using System.Collections.Generic;

namespace Toci.Hornets.Sieradz.UCantTouchThis.Underground1Task.RandomStringGenerator
{
    public static class UCTT_RandomStingGenerator
    {
        public const string PossibleCharacters = "abcdefghijklmnopqrstuvwxyz" +
                                                 "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                                                 "0123456789" +
                                                 "!@#$%^&*()-=_+[]{}\\|;:'\"<>,.?/*`~";
        private static Random _random = new Random();


        public static string GenerateRandomString(int stringLength)
        {
            //  Not the quickest solution but gives us control
            //  over possible characters compared to:
            //  System.IO.Path.GetRandomFileName() or GUID


            char[] resultCharacters = new char[stringLength];

            for (int i = 0; i < stringLength; i++)
            {
                resultCharacters[i] = PossibleCharacters[_random.Next(PossibleCharacters.Length)];
            }


            return new string(resultCharacters);

        }

        public static List<string[]> GenerateRandomStringPaitList(int numberOfPairs, int stringLength)
        {
            List<string[]> tmpList = new List<string[]>();

            for (int i = 0; i < numberOfPairs; i++)
            {
                tmpList.Add(new []{GenerateRandomString(stringLength), GenerateRandomString(stringLength)});
            }

            return tmpList;
        } 
    }
}