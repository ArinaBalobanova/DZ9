﻿using System;


namespace Лаборатоная.Classes
{
    public interface ICipher
    {
        string Encode(string input);
        string Decode(string input);
    }
}
