using System;
using System.Text;

namespace Лаборатоная.Classes
{
    public class ACipher : ICipher
    {
        public string Encode(string input)
        {
            char[] result = input.ToCharArray();
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = (char)(result[i] + 1);
            }
            return new string(result);
        }

        public string Decode(string input)
        {
            char[] result = input.ToCharArray();
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = (char)(result[i] - 1);
            }
            return new string(result);
        }
    }
}
