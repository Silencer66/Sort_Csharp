using System;
using System.Collections.Generic;
using System.Linq;
using BasicAlgorithmLibrary;

namespace Sort_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            List<int> lst = new List<int>() {8, 7, 6, 5, 4, 3, 2, 1 };
            BasicAlgorithm<int> algorithm = new MergeSort<int>(lst);
            
            Console.WriteLine();
            Console.Write("Исходный список: ");
            foreach (var item in lst)
            {
                Console.Write(item + " ");   
            }
            
            Console.WriteLine();
            Console.Write("Отсортированный слиянием: ");
            algorithm.MakeSort();
            foreach (var item in algorithm.Items)
            {
                Console.Write(item+ " ");
            }

            List<string> lst3 = new List<string>() { "Bob", "Adam", "Clint", "Jake", "Tony", "Flint", "Drake", "Alex" };
            Console.WriteLine();
            Console.Write("Исходный список: ");
            foreach (var item in lst3)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.Write("Отсортированный слиянием: ");
            BasicAlgorithm<string> algorithm3 = new MergeSort<string>(lst3);
            algorithm3.MakeSort();
            foreach (var item in algorithm3.Items)
            {
                Console.Write(item + " ");
            }

            List<int> lst1 = new List<int>() { 5, 5, 5, 5, 5, 5, 5, -4 };
            Console.WriteLine();
            Console.Write("Исходный список: ");
            foreach (var item in lst1)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.Write("Отсортированный пузырьком: ");
            BasicAlgorithm<int> algorithm1 = new BublesSort<int>(lst1);
            algorithm1.MakeSort();
            foreach (var item in algorithm1.Items)
            {
                Console.Write(item + " ");
            }

            List<int> lst2 = new List<int>() { 8, 7, 7, 5, 4, 3, 2, -1 };
            Console.WriteLine();
            Console.Write("Исходный список: ");
            foreach (var item in lst2)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.Write("Отсортированный вставками: ");
            BasicAlgorithm<int> algorithm2 = new InsertSort<int>(lst2);
            algorithm2.MakeSort();
            foreach (var item in algorithm2.Items)
            {
                Console.Write(item + " ");
            }
        }
    }
}
