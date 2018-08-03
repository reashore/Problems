using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Problem18
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 18");

            List<List<int>> triangle = LoadTriangle();
            Test(triangle);
            //int maxPathSum = Solve(triangle);
            //Console.WriteLine($"maxPathSum = {maxPathSum}");

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Test(IReadOnlyList<List<int>> triangle)
        {
            int depth = 0;
            int index = 0;
            int value = GetNodeValue(triangle, depth, index);
            Debug.Assert(value == 75);

            depth = 1;
            index = 0;
            value = GetNodeValue(triangle, depth, index);
            Debug.Assert(value == 95);

            depth = 1;
            index = 1;
            value = GetNodeValue(triangle, depth, index);
            Debug.Assert(value == 64);
        }

        private static List<List<int>> LoadTriangle()
        {
            const string triangleString = "75 " +
                                          "95  64 " +
                                          "17  47  82 " +
                                          "18  35  87  10 " +
                                          "20  04  82  47  65 " +
                                          "19  01  23  75  03  34 " +
                                          "88  02  77  73  07  63  67 " +
                                          "99  65  04  28  06  16  70  92 " +
                                          "41  41  26  56  83  40  80  70  33 " +
                                          "41  48  72  33  47  32  37  16  94  29 " +
                                          "53  71  44  65  25  43  91  52  97  51  14 " +
                                          "70  11  33  28  77  73  17  78  39  68  17  57 " +
                                          "91  71  52  38  17  14  91  43  58  50  27  29  48 " +
                                          "63  66  04  68  89  53  67  30  73  16  69  87  40  31 " +
                                          "04  62  98  27  23  09  70  98  73  93  38  53  60  04  23";

            List<int> triangleList = ParseTriangle(triangleString);
            List<List<int>> triangle = ConvertToRaggedArray(triangleList);

            return triangle;
        }

        private static List<int> ParseTriangle(string triangleString)
        {
            // Parse triangle string to List<int>

            string[] delimiters = { " ", "  " };
            string[] triangleArray = triangleString.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            List<int> triangleList = new List<int>();

            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (string valueString in triangleArray)
            {
                int value = Convert.ToInt32(valueString);
                triangleList.Add(value);
            }

            return triangleList;
        }

        private static List<List<int>> ConvertToRaggedArray(IReadOnlyCollection<int> triangleList)
        {
            // Convert to ragged array with one row for each level of triangle

            const int treeDepth = 15;
            int skip = 0;
            List<List<int>> triangle = new List<List<int>>();

            for (int depth = 1; depth <= treeDepth; depth++)
            {
                var take = depth;
                List<int> triangleLevel = triangleList.Skip(skip).Take(take).ToList();
                triangle.Add(triangleLevel);
                skip += take;
            }

            return triangle;
        }

        //private static int Solve(List<List<int>> triangle)
        //{
        //    int maxPathSum = 0;
        //    const int depth = 15;

        //    //int sum = GetPathSum(triangle, depth);



        //    return maxPathSum;
        //}

        //private static int GetPathFromRoot(List<List<int>> triangle, int depth)
        //{
        //    int sum = 0;
        //    //int maxSum = 0;
        //    //int index = 0;

        //    //Tuple<int, int> root = new Tuple<int, int>(depth, index);

        //    // depth, index
        //    // 1, (1, 0)
        //    // 2, (2, 0) (2, 1)
        //    // 3, (3, 0) (3, 1) (3, 2) 

        //    // 

        //    return sum;
        //}

        //private static int GetMaxPathSum(List<List<int>> triangle)
        //{
        //    int sum = 0;
        //    int maxSum = 0;

        //    for (int depth = 0; depth < 15; depth++)
        //    {
        //        for (int index = 0; index < depth; index++)
        //        {
        //            sum += triangle[depth][index];

        //             // get children of node (0, 0)

        //        }

        //        if (sum > maxSum)
        //        {
        //            maxSum = sum;
        //        }
        //    }

        //    return maxSum;
        //}

        //private static void GetChildren(List<List<int>> triangle, int depth, int index)
        //{

        //}

        private static int GetNodeValue(IReadOnlyList<List<int>> triangle, int depth, int index)
        {
            int value = triangle[depth][index];

            return value; 
        }
    }
}
