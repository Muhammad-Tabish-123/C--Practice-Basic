// See https://aka.ms/new-console-template for more information
using System;
using System.Numerics;
using MyUtilites;
namespace GettingStarted
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicTypes.BasicTpesMethod();
            // Console.WriteLine("Hello World");

            Console.WriteLine("Namespace import/usage->mutifile");
            MyUtilites.WeatherUtilites.Report("San Francisco", WeatherUtilites.FahrenheitToCelecius(65), 73); //55.5  //117f
            WeatherUtilites.Report("Denver", WeatherUtilites.FahrenheitToCelecius(77), 55); //42.65 //138.6f
            WeatherUtilites.Report("Bologona", 23, 65); //22

            
        }

    }

}



