using System.Collections.Generic;
using System.Linq;
using Common;

namespace Problem24
{
    public static class Problem24
    {
        public static string Solve()
        {
            const string sequenceString = "0123456789";
            List<int> sequence = Utilities.ConvertNumericStringToList(sequenceString);
            List<List<int>> permutations = Permutate(sequence).ToList();
            List<List<int>> orderedPermutations = permutations.OrderBy(Utilities.ConvertListToString).ToList();
            //Print(orderedPermutations);

            const int index = 999999;
            List<int> millionthPermutation = orderedPermutations[index];
            string millionthPermutationString = Utilities.ConvertListToString(millionthPermutation);
            return millionthPermutationString;
        }

        private static IEnumerable<List<T>> Permutate<T>(IReadOnlyList<T> sequence)
        {

            if (sequence.Count == 2) 
            {
                yield return new(sequence);
                yield return new() { sequence[1], sequence[0] };
            }
            else
            {
                foreach (T element in sequence) 
                {
                    List<T> rList = new(sequence); 
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
        //        WriteLine(ToString(permutation));
        //    }
        //}
    }
}