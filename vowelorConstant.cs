﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5problems
{
    class VowelOrConstants
    {
        public void check()
        {
            Console.WriteLine("Enter an Alphabet");

            char ch = Convert.ToChar(Console.ReadLine());
            ch = char.ToLower(ch);

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("Given aplphabate is an Vowel");

            }
            else
            {
                Console.WriteLine("Given aplphabate is an Constants");
            }
        }
    }
}

