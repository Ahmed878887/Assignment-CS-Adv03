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


    }
}
}
