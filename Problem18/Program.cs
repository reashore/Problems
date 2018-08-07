using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem18
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 18");

            // depth and index are 0-based
            const int maxDepth = 15;     
            List<List<int>> triangle = LoadTriangle2(maxDepth);

            Test(triangle, maxDepth);

            long maxPathSum= Solve(triangle, maxDepth);
            Console.WriteLine($"maxPathSum = {maxPathSum}");        // 1074

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Test(IReadOnlyList<List<int>> triangle, int maxDepth)
        {
            int depth = 0;
            int index = 0;
            Tuple<int, int> root = Tuple.Create(depth, index);
            int value = GetNodeValue(triangle, root);

            depth = 1;
            index = 0;
            Tuple<int, int> node10 = Tuple.Create(depth, index);
            value = GetNodeValue(triangle, root);

            depth = 1;
            index = 1;
            Tuple<int, int> node11 = Tuple.Create(depth, index);
            value = GetNodeValue(triangle, root);

            // GetChildren(0, 0) -> (1, 0) (1, 1)
            Tuple<int, int>  node = Tuple.Create(0, 0);
            List<Tuple<int, int>> children = GetChildren(node, maxDepth);
            PrintChildren(children);

            // GetChildren(1, 0) -> (2, 0) (2, 1)
            node = Tuple.Create(1, 0);
            children = GetChildren(node, maxDepth);
            PrintChildren(children);

            // GetChildren(1, 1) -> (2, 1) (2, 2)
            node = Tuple.Create(1, 1);
            children = GetChildren(node, maxDepth);
            PrintChildren(children);

            // GetChildren(2, 0) -> (3, 0) (3, 1)
            node = Tuple.Create(2, 0);
            children = GetChildren(node, maxDepth);
            PrintChildren(children);

            // GetChildren(2, 1) -> (3, 1) (3, 2)
            node = Tuple.Create(2, 1);
            children = GetChildren(node, maxDepth);
            PrintChildren(children);

            // GetChildren(2, 2) -> (3, 2) (3, 3)
            node = Tuple.Create(2, 2);
            children = GetChildren(node, maxDepth);
            PrintChildren(children);

            // GetChildren(maxDepth, 0) -> empty list
            node = Tuple.Create(maxDepth - 1, 0);
            children = GetChildren(node, maxDepth);
            PrintChildren(children);
        }

        private static List<List<int>> LoadTriangle0(int maxDepth)
        {
            const string triangleString = "3 " +
                                          "7 4 " +
                                          "2 4 6";

            List<int> triangleList = ParseTriangle(triangleString);
            List<List<int>> triangle = ConvertToRaggedArray(triangleList, maxDepth);

            return triangle;
        }

        private static List<List<int>> LoadTriangle1(int maxDepth)
        {
            const string triangleString = "3 " +
                                          "7 4 " +
                                          "2 4 6 " +
                                          "8 5 9 3";

            List<int> triangleList = ParseTriangle(triangleString);
            List<List<int>> triangle = ConvertToRaggedArray(triangleList, maxDepth);

            return triangle;
        }

        private static List<List<int>> LoadTriangle2(int maxDepth)
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
            List<List<int>> triangle = ConvertToRaggedArray(triangleList, maxDepth);

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

        private static List<List<int>> ConvertToRaggedArray(IReadOnlyCollection<int> triangleList, int maxDepth)
        {
            // Convert to ragged array with one row for each level of triangle

            int skip = 0;
            List<List<int>> triangle = new List<List<int>>();

            for (int depth = 1; depth <= maxDepth; depth++)
            {
                var take = depth;
                List<int> triangleRow = triangleList.Skip(skip).Take(take).ToList();
                triangle.Add(triangleRow);
                skip += take;
            }

            return triangle;
        }

        private static long Solve(List<List<int>> triangle, int maxDepth)
        {
            const int depth = 0;
            const int index = 0;
            Tuple<int, int> root = Tuple.Create(depth, index);

            long maxPathValue = FindMaxPathSum(triangle, root, maxDepth);

            return maxPathValue;
        }

        private static long FindMaxPathSum(List<List<int>> triangle, Tuple<int, int> node, int maxDepth)
        {
            long nodeValue = GetNodeValue(triangle, node);
            List<Tuple<int, int>> children = GetChildren(node, maxDepth);

            // if node has no children, then return
            if (children.Count == 0)
            {
                return nodeValue;
            }

            long maxPathSum = 0;

            foreach (var child in children)
            {
                long childMaxPathSum = FindMaxPathSum(triangle, child, maxDepth);

                if (childMaxPathSum > maxPathSum)
                {
                    maxPathSum = childMaxPathSum;
                }
            }

            return nodeValue + maxPathSum;
        }

        private static List<Tuple<int, int>> GetChildren(Tuple<int, int> node, int maxDepth)
        {
            int depth = node.Item1;
            int index = node.Item2;
            List<Tuple<int, int>> children = new List<Tuple<int, int>>();

            // return empty list at leaf nodes
            if (depth + 1 >= maxDepth)
            {
                return children;
            }

            for (int n = 0; n < 2; n++)
            {
                int childDepth = depth + 1;
                int childIndex = index + n;

                Tuple<int, int> child = Tuple.Create(childDepth, childIndex);

                children.Add(child);
            }

            return children;
        }

        private static void PrintChildren(List<Tuple<int, int>> nodes)
        {
            if (nodes.Count == 0)
            {
                Console.WriteLine("No children");
            }

            foreach (Tuple<int, int> node in nodes)
            {
                int depth = node.Item1;
                int index = node.Item2;

                Console.WriteLine($"({depth} , {index})");
            }

            Console.WriteLine();
        }

        private static int GetNodeValue(IReadOnlyList<List<int>> triangle, Tuple<int, int> node)
        {
            int depth = node.Item1;
            int index = node.Item2;

            int value = triangle[depth][index];

            return value;
        }
    }

    internal class Triangle
    {

    }
}
