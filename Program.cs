﻿using System;
// using WeatherUtilities = MyUtilities.WeatherUtilities;
using MyUtilities;

namespace Application1
{
    class CheckComfort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Where should we go in May?");
            WeatherUtilities.Report("San Francisco", WeatherUtilities.FahrenheitToCelsius(65), 73);
            WeatherUtilities.Report("Denver", WeatherUtilities.FahrenheitToCelsius(77), 55);
            WeatherUtilities.Report("Bologna", 23, 65); 
        }
    }
}
