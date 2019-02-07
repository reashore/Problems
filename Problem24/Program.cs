using System.Collections.Generic;
using System.Linq;
using static Common.Utilities;
using static System.Console;

namespace Problem24
{
    // https://stackoverflow.com/questions/2710713/algorithm-to-generate-all-possible-permutations-of-a-list

    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 24");

            const string sequenceString = "0123456789";
            List<int> sequence = ConvertNumericStringToList(sequenceString);
            List<List<int>> permutations = Permutate(sequence).ToList();
            List<List<int>> orderedPermutations = permutations.OrderBy(ConvertListToString).ToList();
            //Print(orderedPermutations);

            const int index = 999999;
            List<int> millionthPermutation = orderedPermutations[index];
            string millionthPermutationString = ConvertListToString(millionthPermutation);
            WriteLine(millionthPermutationString);      // 2783915460

            WriteLine("Done");
            ReadKey();
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

        //private static void Print(List<List<int>> permutations)
        //{
        //    foreach (List<int> permutation in permutations)
        //    {
        //        Console.WriteLine(ToString(permutation));
        //    }
        //}
    }
}
