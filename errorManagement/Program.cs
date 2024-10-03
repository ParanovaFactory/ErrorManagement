using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace errorManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //	int num = Convert.ToInt32(Console.ReadLine());
            //	Console.WriteLine(num * 2);
            //}
            //catch (Exception Error)
            //{
            //	Console.WriteLine(Error.ToString());
            //}

            //try
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(Math.Pow(num,3));
            //}
            //catch (ArgumentNullException error1)
            //{
            //    Console.WriteLine("Value was not entered");
            //}
            //catch (FormatException error2)
            //{
            //    Console.WriteLine("Value not to be correct format");
            //}
            //catch (OverflowException error3)
            //{
            //    Console.WriteLine("Value is out of the bounds");
            //}

            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Math.Pow(num, 3));
            }
            catch (ArgumentNullException error1)
            {
                Console.WriteLine("Value was not entered");
                Console.WriteLine(error1.ToString());
            }
            catch (FormatException error2)
            {
                Console.WriteLine("Value not to be correct format");
                Console.WriteLine(error2.ToString());
            }
            catch (OverflowException error3)
            {
                Console.WriteLine("Value is out of the bounds");
                Console.WriteLine(error3.ToString());
            }
            finally 
            { 
                Console.WriteLine("Finnaly arguments");
            }
        }
    }
}
