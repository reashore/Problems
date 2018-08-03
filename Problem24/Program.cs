using System;
using System.Collections.Generic;

namespace Problem24
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        // https://stackoverflow.com/questions/756055/listing-all-permutations-of-a-string-integer

        private static void Main()
        {
            Console.WriteLine("Problem 24");

            //*********************************

            List<int> input = new List<int> { 0, 1, 2 };
            IEnumerable<List<int>> permutations = Permutate(input);

            foreach (List<int> permutation in permutations)
            {
                string permutationString = "";

                foreach(int item in permutation)
                {
                    permutationString += item + ", ";
                }

                Console.WriteLine(permutationString);
            }


            //*********************************


            const string value = "012";
            char[] valueArray = value.ToCharArray();
            const int firstIndex = 0;
            int lastIndex = valueArray.Length - 1;
            //Permute(valueArray, 0, 2);
            Permute(valueArray, firstIndex, lastIndex);


            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Permute(char[] array, int i, int n)
        {
            if (i == n)
            {
                Console.WriteLine(array);
            }
            else
            {
                int j;
                for (j = i; j <= n; j++)
                {
                    Swap(ref array[i], ref array[j]);
                    Permute(array, i + 1, n);
                    Swap(ref array[i], ref array[j]); //backtrack
                }
            }
        }

        private static void Swap(ref char a, ref char b)
        {
            char tmp = a;
            a = b;
            b = tmp;
        }

        //*********************
        // https://stackoverflow.com/questions/2710713/algorithm-to-generate-all-possible-permutations-of-a-list

        private static IEnumerable<List<T>> Permutate<T>(IReadOnlyList<T> input)
        {
            if (input.Count == 2) 
            {
                yield return new List<T>(input);
                yield return new List<T> { input[1], input[0] };
            }
            else
            {
                foreach (T elem in input) 
                {
                    List<T> rlist = new List<T>(input); 
                    rlist.Remove(elem); 

                    foreach (List<T> retlist in Permutate(rlist))
                    {
                        retlist.Insert(0, elem); 
                        yield return retlist;
                    }
                }
            }
        }
    }
}
