using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class ExceptionHandlingExample
    {
        public static void implementationExample()
        {
            try
            {
                Console.WriteLine("Input First Element");
                var b = Console.ReadLine();
                Console.WriteLine("Input Second Element");
                var a = Console.ReadLine();
                int result = int.Parse(b) / int.Parse(a);


                String? s = new string("abc");
                s = null;
                if (s == null)
                {
                    Console.WriteLine("Yes this string is null");
                    //throw new NullReferenceException("Custom NullRef");
                }
                //Console.WriteLine(s.Length);
                //throw new ArgumentNullException("Custom exception NullRef");

                int num1 = 20;
                int num2 = 20;

                if (num1 == num2)
                {
                    throw new Exception(" Both numbers are equal");
                }
                else if (num1 > num2)
                {
                    throw new Exception(" num1 is greater");
                }
                else
                {
                    throw new Exception(" num2 is greater");
                }


            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Zero division erroe: " + ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Null refrence error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Others" + ex.Message);
                Console.WriteLine("Termination code");

            }
            finally
            {
                Console.WriteLine("All is Well finally block is executing");
            }
        }
    }
}
