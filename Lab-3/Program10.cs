﻿using System;
using System.Collections;
namespace Lab_3
{
    internal class Program10
    {
        public void CaseChange()
        {
            Console.Write("Enter Character : ");
            Char c = Convert.ToChar(Console.ReadLine());

            Char newChar = c.ToString().ToUpper().ToCharArray()[0];
            Console.WriteLine("Changed Character : " + newChar);
        }
    }
}
