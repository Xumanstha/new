using System;
using System.ComponentModel;
using System.Xml.Schema;

namespace logic
{
    internal class Program
    {
        static void swap(int a, int b)
        {
            Console.WriteLine($"Before \n a={a} \n b={b}");
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After:\n a={a}\n b={b}");
            Console.ReadLine();
        }
        static void IsEven(int a, out bool b)
        {
            b = a % 2 == 0;
        }
        static void Calculate(int a, int b, out int c)
        {

            c = a + b;

        }

        //static int compare(int x,int y)
        //{
        //    int g;
        //    g = Math.Max(x, y);
        //    return g;
        //}
        static void Main(string[] args)
        {
            //int a,b;
            //Console.WriteLine("Give any two numbers");
            //a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"The maximum number is {Math.Max(a, b)}");
            //Console.ReadLine();
            //if(a>b)
            //{
            //    Console.WriteLine($"The greatest number is {a}");
            //}
            //else
            //{
            //    Console.WriteLine($"The greatest number is {b}");
            //}
            //Console.ReadLine();
            //compare(a, b);
            //Console.WriteLine($"The greatest number is {compare(a, b)}");
            //Console.ReadLine();
            //int result;
            //Calculate(a, b, out result);
            //Console.WriteLine("The sum is" + result);
            //bool result;
            //IsEven(a,out result);
            //Console.WriteLine($"The
            //statement is {result}");
            //Console.ReadLine();


            //swap(a, b);
            //Console.ReadLine();
            int number;
            int[] num = new int[5];
            Console.WriteLine("Enter the numbers for aray");
            for (int i = 0; i < 5; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(num[i]);
            }
            number = num[0];

            for (int j = 0; j <num.Length-1; j++)
            {
                number = Math.Max(number, num[j]);
                }
            Console.WriteLine("The greatest number in array is " + number);
            Console.ReadLine();
        }
    }
}
    


