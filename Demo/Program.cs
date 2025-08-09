using System.Collections;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1   Q1
            //01-You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList)
            //without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.

            using System.Collections;

public static void ReverseArrayList(ArrayList list)
        {
            for (int i = 0; i < list.Count / 2; i++)
            {
                int oppositeIndex = list.Count - 1 - i;
                object temp = list[i];
                list[i] = list[oppositeIndex];
                list[oppositeIndex] = temp;
            }
        }

        #endregion
        #region Part1   Q2
        //You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.

        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evens = new List<int>();
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
            }
            return evens;
        }
        #endregion
        #region Part1   Q3
        //implement a custom list called FixedSizeList<T> with a predetermined capacity.
        //This list should not allow more elements than its capacity
        //and should provide clear messages if one tries to exceed it or access invalid indices.

        public class FixedSizeList<T>
        {
            private readonly T[] items;
            private int count;

            public FixedSizeList(int capacity)
            {
                if (capacity <= 0)
                    throw new ArgumentException("Capacity must be positive");

                items = new T[capacity];
                count = 0;
            }

            public void Add(T item)
            {
                if (count == items.Length)
                    throw new InvalidOperationException("List is full");

                items[count++] = item;
            }

            public T Get(int index)
            {
                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException("Invalid index");

                return items[index];
            }

            public int Capacity => items.Length;
            public int Count => count;
        }
        #endregion
        #region Part1   Q4
        //Given an array  consists of  numbers with size N and number of queries,
        //in each query you will be given an integer X,
        //and you should print how many numbers in array that is greater than  X.
        public static void CountGreaterThanX()
        {
            string[] firstLine = Console.ReadLine().Split();
            int n = int.Parse(firstLine[0]);
            int q = int.Parse(firstLine[1]);

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            for (int i = 0; i < q; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int count = 0;
                foreach (int num in arr)
                {
                    if (num > x) count++;
                }
                Console.WriteLine(count);
            }
        }
        #endregion
        #region Part1   Q5
        //Given a number N and an array of N numbers. Determine if it's palindrome or not.
        public static string IsPalindrome(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] != arr[arr.Length - 1 - i])
                {
                    return "NO";
                }
            }
            return "YES";
        }
        #endregion
    }
}
}
