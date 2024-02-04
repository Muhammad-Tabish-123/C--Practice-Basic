// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel;

namespace Generics
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] intArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            string[] stringArr = { "Alpha", "Beta", "Cyan", "btn--danger" };
            char[] charArr = { 'a', 'b', 'c', 'd', 'e' };

            //G1
            Console.WriteLine("-----------------Generic looping--------------------");
            ForForEach objFor = new ForForEach();
            objFor.GenericMethodCall(intArr);
            objFor.GenericMethodCall(stringArr);
            objFor.GenericMethodCall(charArr);


            //G2
            Console.WriteLine("-----------------Generic comparision method--------------------");
            Comparison objComp =new Comparison();
            objComp.GenericMethodCall();

            //G class
            Console.WriteLine("-----------------Generic classes--------------------"); 
            GenericClass<int> objInt = new GenericClass<int>();
            objInt.isEqula(10, 10);
            objInt.isEqula(10, 15);
            objInt.showVlaues(intArr);
            GenericClass<string> objStr = new GenericClass<string>();
            objStr.isEqula("10", "10");
            objStr.isEqula("10", "15");
            objStr.showVlaues(stringArr);


            //G3
            Console.WriteLine("-----------------Generic Add Method--------------------");
            GenericAdd objAdd =new GenericAdd();
            objAdd.GenericMethodCall();

        }

        





    }
}