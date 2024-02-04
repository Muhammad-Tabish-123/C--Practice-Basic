using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndCollection
{
    internal class ArraysExample
    {
        int[,] MDArr = 
        {
            {0,1,2,3 },
            { 4,5,6,7},
            { 8,9,10,11 },
            { 12,13,14,15},
            { 16,17,18,19},
            { 20,21,22,23},
        };

        public ArraysExample() {
            Console.WriteLine(MDArr[0, 0]);
            Console.WriteLine(MDArr[5, 0]);
            showAll();
            Console.WriteLine("Number of rows "+ MDArr.GetLength(0));
            Console.WriteLine("Number of Column " + MDArr.GetLength(1));

            Console.WriteLine("\nJagged Array\n");

            int[][] MDArr2 =  {
            new[] {0,1,2,3 },
            new[] { 4,5,6,7,8,9},
            new[] { 10,11,12},
            };

            showAllJagges(MDArr2);
            MDArr2[0] = new[] { 0, 1, 2, 3, 4, 5 };
            MDArr2[1] = new[] { 0, 1, 2, };
            MDArr2[2] = new[] { 0};
            showAllJagges(MDArr2);

            Console.WriteLine(MDArr2.Rank);
            Console.WriteLine(MDArr.Rank);

            
        }
        void showAll()
        {
            Console.WriteLine("-------ShowingOutput--------------");
            foreach (var i in MDArr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n---------------------");
        }
        void showAllJagges(int[][] arr)
        {
            Console.WriteLine("-------ShowingOutput--------------");
            foreach (var i in arr)
            {
                foreach (var j in i) {
                    Console.Write(j + " ");
                }
            }
            Console.WriteLine("\n---------------------");
        }
    }
}
