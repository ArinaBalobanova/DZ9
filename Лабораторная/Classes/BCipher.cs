using System;
using System.Text;

namespace Лаборатоная.Classes
{
    public class BCipher : ICipher
    {
        public string Encode(string input)
        {
            char[] result = input.ToCharArray();
            for (int i = 0; i < result.Length; i++)
            {
                if (char.IsLetter(result[i]))
                {
                    int offset = char.IsUpper(result[i]) ? 'А' : 'а';
                    result[i] = (char)(offset + (31 - (result[i] - offset)));
                }
            }
            return new string(result);
        }

        public string Decode(string input)
        {
            return Encode(input);
        }
    }
}