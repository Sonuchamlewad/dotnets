﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class3
    {
        public static void Main(string[] args)
            {
                Console.Write("Enter a number: ");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                for (int i = n; i >= 0; i--)
                {
                    for (int j = 1; j <= i; j++)
                        Console.Write("*");
                    Console.WriteLine("");
                }

                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                        Console.Write("*");
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
    }
