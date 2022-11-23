using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVP_Projekat_VukA_NRT2020
{
    public static class Utils
    {
        internal static int keyEncrypt = 3;
        internal static char Cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);


        }

        internal static string Encrypt(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += Cipher(ch, key);

            return output;
        }

        internal static string Decrypt(string input, int key)
        {
            return Encrypt(input, 26 - key);
        }
    }
}
