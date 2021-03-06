﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AnythingToAnything
{
    class AnyToAny
    {
        static char GetChar(int i)
        {
            if (i >= 10) return (char)('A' + i - 10);
            else return (char)('0' + i);
        }

        static int GetNumber(string s, int i)
        {
            if (s[i] >= 'A') return s[i] - 'A' + 10;
            else return s[i] - '0';
        }
        static string Base10ToBaseX(int d, int x)
        {
            string h = String.Empty;

            for (; d != 0; d /= x) h = GetChar(d % x) + h;

            return h;
        }

        static int BaseXToBase10(string h, int x)
        {
            int d = 0;

            for (int i = h.Length - 1, p = 1; i >= 0; i--, p *= x)
                d += GetNumber(h, i) * p;

            return d;
        }

        static string BaseXToBaseY(string n, int x, int y)
        {
            return Base10ToBaseX(BaseXToBase10(n, x), y);
        }

        static void Main()
        {
            Console.WriteLine("Enter number: ");
            string number = Console.ReadLine();
            Console.WriteLine("Enter based system: ");
            int firstSystem = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter desired system: ");
            int secondSystem = int.Parse(Console.ReadLine());
            Console.WriteLine(BaseXToBaseY(number, firstSystem, secondSystem));
        }
    }
}

