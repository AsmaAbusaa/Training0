using System;
namespace TrainingLeetCode
{
    class Program
    {                         ////////////   Testing  /////////

        static void Main(string[] args)
        { 
            ////////////   Question NO ONE   /////////

            Console.WriteLine("ONE");
            int[] arr = { 1, 2, 3, 4 };
            Console.WriteLine(Class1.ContainsDuplicate(arr));

            int[] arr1 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            Console.WriteLine(Class1.ContainsDuplicate(arr1));

            int[] arr2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(Class1.ContainsDuplicate(arr2));

            int[] arr3 = { 1, 2, 10, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(Class1.ContainsDuplicate(arr3));

            ////////////   Question NO TWO   /////////
            
            Console.WriteLine();
            Console.WriteLine("Two");
            int[] arr4 = { 1, 2, 10, 4, 5, 6, 7, 8, 9, 10 };
            int[] T = Class1.TwoSum(arr4, 11);
            for (int i = 0; i < T.Length; i++)
            {
                Console.Write(T[i] + " ");
            }
            Console.WriteLine("\n");

            ////////////   Question NO THREE   /////////
            
            int[] prices = { 7, 1, 5, 3, 6, 4};
            Console.WriteLine("Three");
            Console.WriteLine(Class1.MaxProfit(prices));

            ////////////   Question NO FOUR   /////////
           
            int[] nums1 = { 2, 0 };
            int m = 1, n = 1;
            int[] nums2 = { 1 };
            Console.WriteLine("\nFour");
            Class1.Merge(nums1, m, nums2, n);
            Console.WriteLine();

           ////////////   Question NO FIVE   /////////

            Console.WriteLine("\nFive");
            int[] No1 = { 1};
            int[] No2 = {1 };
            
          int[] temp =Class1.Intersect(No1, No2);

            for (int x = 0; x < temp.Length; x++)
            {
                 Console.Write( temp[x]+" ");
            }


        }
        

        

      
    }
}