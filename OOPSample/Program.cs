﻿using System;
using OOPSample.Sample3;

namespace OOPSample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SampleRunner.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
