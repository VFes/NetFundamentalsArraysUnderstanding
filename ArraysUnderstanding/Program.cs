﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysUnderstanding
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];//n

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            Console.WriteLine(numbers[1].ToString());


            int[] numbers2 = new int[] { 4, 8, 15, 16, 23, 42 };
            Console.WriteLine(numbers2[1].ToString());

            string[] names = new string[] { "Eddie", "Alex", "Michael", "David" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            string zig = "Mucho texto como ejemplo del contenido del string blabalblalbalblaba";
            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach(char zigChar in charArray)
                Console.Write(zigChar);

            Console.ReadLine();

            Console.ReadLine();

        }
    }
}
