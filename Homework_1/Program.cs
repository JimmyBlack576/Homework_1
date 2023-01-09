using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tTask 1 \n");

            int[] A = new int[5];
            for(int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < A.Length; i++)
            {
                Console.Write($" {A[i]} ");
            }
            Console.WriteLine($"\nMax: {A.Max()} ");
            Console.WriteLine($"\nMin: {A.Min()} ");
            Console.WriteLine($"\nSum: { A.Where(i => i % 2 == 0).Sum()}");


            int[,] B = new int[3,4]; 

            Random rand = new Random();

            for(int i = 0; i < B.GetLength(0); i++)
            {
                for(int j = 0; j < B.GetLength(1); j++)
                {
                    B[i,j] = rand.Next(-10,10);
                }
            }

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write(B[i,j] + "\t");
                }
                Console.WriteLine();
            }

            int maxval = 0;
            int minval =0;
            int sum = 0;
            int prod = 0;
            int sum_even = 0;
            foreach(int i in B)
            {
                maxval = maxval<i ? i: maxval;
                minval = minval>i ? i: minval;
                sum += i;
                prod*=i;
            }

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (j % 2 != 0)
                    {
                        sum_even += B[i,j];
                    }
                }
                
            }
            Console.WriteLine($"\n Max B: {maxval} " +
                $"\n Min B: {minval}"+
                $"\n Sum B: {sum}" +
                $"\n Prod B: {prod}" +
                $"\n Sum even B: {sum_even}");
            //Console.WriteLine(B.GetEnumerator();
            //Console.WriteLine(B.Where(i => i % 2 == 0).Sum());

            Console.ReadLine();
        }
    }
}
