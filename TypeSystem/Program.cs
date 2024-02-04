// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using TypeSystem;

namespace BethyPieShopHRM
{
    class Program
    {
        static void Main(string[] args)
        {


            //Console.ReadLine();
            bool a;
            int b;
            //Console.ReadLine();
            
            //methods
            DataTypeMethods.DataType();

            //Date and Time
            TypeSystem.DateTime.Method1();


            //Conversion
            Conversions.method1();



            /////////////////////////////////////////
            //String Module
            Strings.Method1();

            //String builder
            TypeSystem.StringBuilder.Method1();

            

            //////////////////////////////////////////////////////////////////
            //Method module
            UserDefinedMethods.Method1();

            //Parsing
            Parsing.Simple();
            Parsing.Tryparse();
            Parsing.DateParsing();

            ////////////////////////////////////////////////////////////////
            ///Value type and refrence type

            //Enumeration
            Enumeration.EnumerationImplementation();

            //Structs
            Structs.Method1();


            ////////////////////////////////////////////////////////////////
            ///Interfaces


        }











    }

    
}