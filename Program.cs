using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {       
        static void Main(string[] args)
        {

            //3 FIZZ 5 BUZZ && BOTH FIZZBUZZ
            int num = 50;
            for(int i = 1; i <= num; i++){
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FIZZBUZZ");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("FIZZ");

                }
                else
                {
                    Console.WriteLine(i);
                }
            }



            //Console.WriteLine("Reverse string");
            //string str = "Hello World";
            //char[] chararr= str.ToCharArray();
            //int c = 0;
            //for(int i = chararr.Length-1; i >= 0; i--)
            //{
            //    chararr[c] = str[i];
            //    c++;
            //}

            //string reversestring = new string(chararr);
            //Console.WriteLine(reversestring);



            //Bubble sort 
            //int[] arr = { 1, 3, 9, 2, 5 };
            //int num = arr.Length;
            //for (int i = 0; i < num - 1; i++)
            //{
            //    for (int j = 0; j < num - i - 1; j++)
            //    {
            //        if (arr[j] > arr[j + 1])
            //        {
            //            int temp = arr[j];
            //            arr[j] = arr[j + 1];
            //            arr[j + 1] = temp;
            //        }
            //    }
            //}
            //for (int i = 0; i < num; i++)
            //{
            //    Console.WriteLine(" " + arr[i]);
            //}


            /*int n1, n2;
            Console.WriteLine("Enter the any number");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = n1 + n2; 
            n1 = n3 - n1;
            n2 = n3 - n2;
            Console.WriteLine("n1 => " + n1 + " n2 => " + n2);*/

            //wal sum 
            /*int num, sum = 0;
            Console.WriteLine("Enter any number");
            num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i<=num; i++)
            {
                Console.Write(" " + i);
                sum  += i;
            }
            Console.Write("\t sum "+ sum);
            Console.ReadLine();*/

            //Subtraction two matrix
            /*int n1, n2;
            Console.WriteLine("Enter the n1 & n2 matrix");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());

            int[,] A = new int[10, 10];
            Console.WriteLine("Enter the First matrix");
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] B = new int[10, 10];
            Console.WriteLine("Enter the Second matrix");
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[,] C = new int[10, 10];
            Console.WriteLine("Subtraction of two matrix");
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < n2; j++)
                {
                    C[i, j] = A[i, j] - B[i, j];
                    Console.WriteLine(C[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.Read();*/

            /* //Add two matrix 
             int n1, n2;
             Console.WriteLine("Add two matrix");
             n1 = Convert.ToInt32(Console.ReadLine());
             n2 = Convert.ToInt32(Console.ReadLine());
             int[,] a = new int[10, 10];
             Console.WriteLine("Enter the first matrix ");
             for(int i=0; i<n1; i++)
             {
                 for (int j = 0; j < n2; j++)
                 {
                     a[i,j] = Convert.ToInt32(Console.ReadLine()); 
                 }
             }
             int[,] b = new int[10, 10];
             Console.WriteLine("Enter the second matrix");
             for(int i = 0; i<n1; i++)
             {
                 for (int j=0; j<n2; j++)
                 {
                     b[i, j] = Convert.ToInt32(Console.ReadLine());
                 }
             }

             int[,] Sum = new int[10, 10];
             Console.WriteLine("Sum of two matrix");
             for(int i = 0; i<n1; i++)
             {
                 for(int j= 0; j <n2; j++)
                 {
                     Sum[i,j] = a[i,j] + b[i,j];
                     Console.WriteLine(Sum[i,j]+"\t");
                 }
                 Console.WriteLine();
             }
             Console.Read();*/


            /* string reversestring = "";
             Console.WriteLine("enter revers string");
             string str = Console.ReadLine();
             int length = str.Length-1;
             while (length >= 0)
             {
                 reversestring = reversestring + str[length];
                 length--;
             }
             Console.WriteLine("Reverse  String  Is  {0}", reversestring);
             Console.ReadLine();*/

            /*Console.WriteLine("Check Greatest number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("N1 is greatest number");
            }
            else if (n1 < n2)
            {
                Console.WriteLine("N2 is greatest number");
            }
            else
            {
                Console.WriteLine("N1 and N2 number are equal");
            }*/

            /*int a = 10, b = 20;
            int c = a + b;
             a = c - a ;
             b = c - b ;
            Console.WriteLine("a = "+a);
            Console.WriteLine("b = "+b);*/

            /*int number;
            Console.WriteLine("Print the number Positive or Negative number");
            number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if(number == 0)
            {
                Console.WriteLine("Number is 0");
            }
            else
            {
                Console.WriteLine("Number is Negative");
            }*/

            /*int i;
            Console.WriteLine("Print even or Odd number");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("This is Even number");
            }
            else
            {
                Console.WriteLine("This is Odd number");
            }*/

            /*int num = Convert.ToInt32(Console.ReadLine());
            for (int i = num; i >= 0; --i)
            {
                Console.WriteLine(i + " ");
            }*/

            /* int num;
             Console.WriteLine("Checked devided number");
             num = int.Parse(Console.ReadLine());
             for(int i = 1; i <=num; i++)
             {
                 if(i % 3== 0)
                 {
                     Console.WriteLine(i);
                 }
             }*/

            /* int num = 6;
             for (int i = num; i > 0; i--)
             {
                 Console.Write(i+" ");
             } */
        }
    }
}
