using System;

namespace C43_G05_ADV01
{
    #region Question 1

    
        #region Requirement 1: Define the Range<T> class
        public class Range<T> where T : IComparable<T>
        {
            #region Requirement 2: Fields and Constructor
            private T _min;
            private T _max;

            public Range(T min, T max)
            {
                if (min.CompareTo(max) > 0)
                {
                    throw new ArgumentException("Minimum value cannot be greater than maximum value.");
                }

                _min = min;
                _max = max;
            }
            #endregion

            #region Requirement 3: IsInRange(T value)
            public bool IsInRange(T value)
            {
                return value.CompareTo(_min) >= 0 && value.CompareTo(_max) <= 0;
            }
            #endregion

            #region Requirement 4: Length()
            public T Length()
            {
                dynamic min = _min;
                dynamic max = _max;
                return max - min;
            }
            #endregion

            #region Requirement 5: Properties for Min and Max
            public T Min => _min;
            public T Max => _max;
            #endregion
        }
        #endregion
    

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Range<int> range = new Range<int>(5, 15);

            Console.WriteLine($"Min: {range.Min}, Max: {range.Max}");

            int value = 10;
            Console.WriteLine($"Is {value} in range? {range.IsInRange(value)}");

            Console.WriteLine($"Length of range: {range.Length()}");
        }
    }
}
