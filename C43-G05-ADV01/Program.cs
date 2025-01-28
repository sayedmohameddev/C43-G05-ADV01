using System;
using System.Collections.Generic;

namespace C43_G05_ADV01
{
    //#region Question 1

    
    //    #region Requirement 1: Define the Range<T> class
    //    public class Range<T> where T : IComparable<T>
    //    {
    //        #region Requirement 2: Fields and Constructor
    //        private T _min;
    //        private T _max;

    //        public Range(T min, T max)
    //        {
    //            if (min.CompareTo(max) > 0)
    //            {
    //                throw new ArgumentException("Minimum value cannot be greater than maximum value.");
    //            }

    //            _min = min;
    //            _max = max;
    //        }
    //        #endregion

    //        #region Requirement 3: IsInRange(T value)
    //        public bool IsInRange(T value)
    //        {
    //            return value.CompareTo(_min) >= 0 && value.CompareTo(_max) <= 0;
    //        }
    //        #endregion

    //        #region Requirement 4: Length()
    //        public T Length()
    //        {
    //            dynamic min = _min;
    //            dynamic max = _max;
    //            return max - min;
    //        }
    //        #endregion

    //        #region Requirement 5: Properties for Min and Max
    //        public T Min => _min;
    //        public T Max => _max;
    //        #endregion
    //    }
    //#endregion


    //#endregion

    
   
   
    internal class Program
    {
        //#region Question 2
        //public static void ReverseArrayList<T>(List<T> list)
        //{
        //    int left = 0;
        //    int right = list.Count - 1;

        //    while (left < right)
        //    {
        //        T temp = list[left];
        //        list[left] = list[right];
        //        list[right] = temp;

        //        left++;
        //        right--;
        //    }
        //}
        //#endregion

        #region Question 3
        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }

            return evenNumbers;
        }
        #endregion
        static void Main(string[] args)
        {

            //Range<int> range = new Range<int>(5, 15);

            //Console.WriteLine($"Min: {range.Min}, Max: {range.Max}");

            //int value = 10;
            //Console.WriteLine($"Is {value} in range? {range.IsInRange(value)}");

            //Console.WriteLine($"Length of range: {range.Length()}");


            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            //Console.WriteLine("Original List (Int):");
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}

            //ReverseArrayList(numbers);

            //Console.WriteLine("\nReversed List (Int):");
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}

            //Console.WriteLine(); 

            //List<string> words = new List<string> { "Hello", "World", "C#", "Generics" };

            //Console.WriteLine("Original List (String):");
            //for (int i = 0; i < words.Count; i++)
            //{
            //    Console.Write(words[i] + " ");
            //}

            //ReverseArrayList(words);

            //Console.WriteLine("\nReversed List (String):");
            //for (int i = 0; i < words.Count; i++)
            //{
            //    Console.Write(words[i] + " ");
            //}


            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Original List:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            List<int> evenNumbers = GetEvenNumbers(numbers);

            Console.WriteLine("\nEven Numbers List:");
            foreach (int even in evenNumbers)
            {
                Console.Write(even + " ");
            }


        }
    }
}
