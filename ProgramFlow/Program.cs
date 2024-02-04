// See https://aka.ms/new-console-template for more information
using ProgramFlow;
using System;
using System.Collections.Generic;
namespace WiredBrainSurveys.Repotrs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide any input: ");
            var input = Console.ReadLine();

            //List
            ListExample.method1();

            //double respondRate;
            //double overallScore;
            //double unansweredCont;
            //respondRate = (Q1Results.NumberResponded / Q1Results.NumberSuryed) * 100;
            //overallScore = (Q1Results.ServiceScore + Q1Results.PriceScore + Q1Results.FoodScore + Q1Results.CoffeeScore) / 4;
            //unansweredCont = Q1Results.NumberSuryed - Q1Results.NumberResponded;

            //Logical comparision
            bool isCoffeeScoreLower = Q1Results.CoffeeScore < Q1Results.FoodScore;
            Console.WriteLine();
            Console.WriteLine("LOGICAL CPMPARISON RESULT: " + isCoffeeScoreLower);

            //if else
            ListExample.ifElseExample(isCoffeeScoreLower);

            //switch
            SwitchExample.method1();

            //switch expression for value assign
            switchExpression.method1();

            //switch with when
            SwitchWhen.method1();



        }
    }
}
