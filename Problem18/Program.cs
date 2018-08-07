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

            Triangle triangle = LoadTriangle();
            long maxPathSum= Solve(triangle);
            Console.WriteLine($"maxPathSum = {maxPathSum}");        // 1074

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static Triangle LoadTriangle()
        {
            const int maxDepth = 15;
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

            Triangle triangle = new Triangle(triangleString, maxDepth);

            return triangle;
        }

        private static long Solve(Triangle triangle)
        {
            const int depth = 0;
            const int index = 0;
            Tuple<int, int> root = Tuple.Create(depth, index);

            long maxPathSum = triangle.FindMaxPathSum(root);

            return maxPathSum;
        }
    }

    internal class Triangle
    {
        #region Constructors, Properties, and Fields

        private List<List<int>> _triangle;

        private int MaxDepth { get; }

        public Triangle(string triangleString, int maxDepth)
        {
            MaxDepth = maxDepth;
            LoadTriangle(triangleString);
        }

        #endregion

        public long FindMaxPathSum(Tuple<int, int> node)
        {
            long nodeValue = GetNodeValue(node);
            List<Tuple<int, int>> children = GetChildren(node);

            // if node has no children, then return
            if (children.Count == 0)
            {
                return nodeValue;
            }

            long maxPathSum = 0;

            foreach (var child in children)
            {
                long childMaxPathSum = FindMaxPathSum(child);

                if (childMaxPathSum > maxPathSum)
                {
                    maxPathSum = childMaxPathSum;
                }
            }

            return nodeValue + maxPathSum;
        }

        #region Private Methods

        private void LoadTriangle(string triangleString)
        {
            List<int> triangleList = ParseTriangleToList(triangleString);
            ConvertToRaggedArray(triangleList);
        }

        private static List<int> ParseTriangleToList(string triangleString)
        {
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

        private void ConvertToRaggedArray(IReadOnlyCollection<int> triangleList)
        {
            // Convert to ragged array with one row for each level of triangle

            int skip = 0;
            _triangle = new List<List<int>>();

            for (int depth = 1; depth <= MaxDepth; depth++)
            {
                var take = depth;
                List<int> triangleRow = triangleList.Skip(skip).Take(take).ToList();
                _triangle.Add(triangleRow);
                skip += take;
            }
        }

        private List<Tuple<int, int>> GetChildren(Tuple<int, int> node)
        {
            int depth = node.Item1;
            int index = node.Item2;
            List<Tuple<int, int>> children = new List<Tuple<int, int>>();

            // leaf nodes return empty child list
            if (depth + 1 >= MaxDepth)
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

        private int GetNodeValue(Tuple<int, int> node)
        {
            int depth = node.Item1;
            int index = node.Item2;

            int value = _triangle[depth][index];

            return value;
        }

        #endregion
    }
}
