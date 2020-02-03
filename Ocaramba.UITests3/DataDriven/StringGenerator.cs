using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocaramba.UITests3.DataDriven
{
    static class StringGenerator
    {
        public static readonly string smallLetters = "abcdefghijklmnopqrstuvwxyz";
        public static readonly string capitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static readonly string digits = "0123456789";
        public static readonly string specialCharacters = "!#$%&\'\"()*+,-./:;<=>?@[\\]^_`{|}~";
        public static readonly string space = " ";

        public static Random random = new Random();

        public static string GenerateString(int lenght, params string[] subsets)
        {
            StringBuilder characters = new StringBuilder();
            foreach (string s in subsets)
            {
                characters.Append(s);
            }
            string charSet = characters.ToString();

            StringBuilder generatedString = new StringBuilder();
            for (int i = 0; i < lenght; i++)
            {
                generatedString.Append(charSet[random.Next(charSet.Length)]);
            }
            return generatedString.ToString();
        }

        public static string GenerateAlphanumericString(int lenght, bool includeSpace)
        {
            if (includeSpace)
            {
                return GenerateString(lenght, smallLetters, capitalLetters, digits, space);
            }
            return GenerateString(lenght, smallLetters, capitalLetters, digits);
        }

        public static string GenerateEmailAddress()
        {
            return GenerateAlphanumericString(random.Next(6, 42), false) +
                "@" +
                GenerateAlphanumericString(random.Next(3, 42), false) +
                "." +
                GenerateAlphanumericString(random.Next(3, 42), false);
        }

    }
}
