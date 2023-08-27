﻿using System;
using System.Globalization;

namespace LeitorNumInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];
            for (int i = 0; i < n; i++)

            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double som = 0.0;
            for (int i = 0;i < n; i++)
            {
                som += vect[i];
            }

            double avg = som / n;

            Console.WriteLine("AVAREGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}