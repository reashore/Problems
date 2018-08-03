using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem24
{
    // https://stackoverflow.com/questions/2710713/algorithm-to-generate-all-possible-permutations-of-a-list

    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 24");

            List<int> sequence = new List<int> { 0, 1, 2 };
            IEnumerable<List<int>> permutations = Permutate(sequence);
            //var orderedPermutations = permutations.OrderBy(n => n);

            foreach (List<int> permutation in permutations)
            {
                string permutationString = "";

                foreach(int item in permutation)
                {
                    permutationString += item + ", ";
                }

                Console.WriteLine(permutationString);
            }

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static IEnumerable<List<T>> Permutate<T>(IReadOnlyList<T> sequence)
        {

            if (sequence.Count == 2) 
            {
                yield return new List<T>(sequence);
                yield return new List<T> { sequence[1], sequence[0] };
            }
            else
            {
                foreach (T element in sequence) 
                {
                    List<T> rList = new List<T>(sequence); 
                    rList.Remove(element); 

                    foreach (List<T> retList in Permutate(rList))
                    {
                        retList.Insert(0, element); 
                        yield return retList;
                    }
                }
            }
        }

        #region OldCode

        // https://stackoverflow.com/questions/756055/listing-all-permutations-of-a-string-integer


        //const string value = "012";
        //char[] valueArray = value.ToCharArray();
        //const int firstIndex = 0;
        //int lastIndex = valueArray.Length - 1;
        ////Permute(valueArray, 0, 2);
        //Permute(valueArray, firstIndex, lastIndex);


        //private static void Permute(char[] array, int i, int n)
        //{
        //    if (i == n)
        //    {
        //        Console.WriteLine(array);
        //    }
        //    else
        //    {
        //        int j;
        //        for (j = i; j <= n; j++)
        //        {
        //            Swap(ref array[i], ref array[j]);
        //            Permute(array, i + 1, n);
        //            Swap(ref array[i], ref array[j]); //backtrack
        //        }
        //    }
        //}

        //private static void Swap(ref char a, ref char b)
        //{
        //    char tmp = a;
        //    a = b;
        //    b = tmp;
        //}


        #endregion
    }
}
