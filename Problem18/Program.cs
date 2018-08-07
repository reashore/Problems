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
            
            List<List<int>> triangle = LoadTriangle();
            //Test(triangle);

            long maxPathSum = Solve(triangle);
            Console.WriteLine($"maxPathSum = {maxPathSum}");

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Test(IReadOnlyList<List<int>> triangle)
        {
            //int depth = 0;
            //int index = 0;
            //Tuple<int, int> root = Tuple.Create(depth, index);
            //int value = GetNodeValue(triangle, root);

            //depth = 1;
            //index = 0;
            //Tuple<int, int> node10 = Tuple.Create(depth, index);
            //value = GetNodeValue(triangle, root);

            //depth = 1;
            //index = 1;
            //Tuple<int, int> node11 = Tuple.Create(depth, index);
            //value = GetNodeValue(triangle, root);

            // depth is 1-based, index is 0-based, fix

            // GetChildren(0, 0) -> (1, 0) (1, 1)
            Tuple<int, int>  node = Tuple.Create(0, 0);
            List<Tuple<int, int>> children = GetChildren(node);
            PrintChildren(children);

            // GetChildren(1, 0) -> (2, 0) (2, 1)
            node = Tuple.Create(1, 0);
            children = GetChildren(node);
            PrintChildren(children);

            // GetChildren(1, 1) -> (2, 1) (2, 2)
            node = Tuple.Create(1, 1);
            children = GetChildren(node);
            PrintChildren(children);

            // GetChildren(2, 0) -> (3, 0) (3, 1)
            node = Tuple.Create(2, 0);
            children = GetChildren(node);
            PrintChildren(children);

            // GetChildren(2, 1) -> (3, 1) (3, 2)
            node = Tuple.Create(2, 1);
            children = GetChildren(node);
            PrintChildren(children);

            // GetChildren(2, 2) -> (3, 2) (3, 3)
            node = Tuple.Create(2, 2);
            children = GetChildren(node);
            PrintChildren(children);

            // GetChildren(10, 0) -> empty list
            node = Tuple.Create(10, 0);
            children = GetChildren(node);
            PrintChildren(children);

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

        private static long Solve(List<List<int>> triangle)
        {
            const int depth = 0;
            const int index = 0;
            Tuple<int, int> root = Tuple.Create(depth, index);

            long maxPathValue = FindMaxPathValue(triangle, root);

            return 0;
        }

        // Create Triangle class so that triangle is an instance variable
        private static long FindMaxPathValue(List<List<int>> triangle, Tuple<int, int> node)
        {
            long nodeValue = GetNodeValue(triangle, node);
            List<Tuple<int, int>> children = GetChildren(node);

            // if node has no children, then stop
            if (children.Count == 0)
            {
                return nodeValue;
            }

            long maxPathValue = nodeValue;

            foreach (Tuple<int, int> child in children)
            {
                long pathValue = nodeValue + FindMaxPathValue(triangle, child);

                if (pathValue > maxPathValue)
                {
                    maxPathValue = pathValue;
                }
            }

            return maxPathValue;
        }

        private static List<Tuple<int, int>> GetChildren(Tuple<int, int> node)
        {
            List<Tuple<int, int>> children = new List<Tuple<int, int>>();

            int depth = node.Item1;
            int index = node.Item2;

            #region Comments
            //    // depth, index
            //    // 1, (1, 0)
            //    // 2, (2, 0) (2, 1)
            //    // 3, (3, 0) (3, 1) (3, 2) 

            // node,    skip
            // (0, 0)   0       

            // (1, 0)   0    
            // (1, 1)   1      

            // (2, 0)   0      
            // (2, 1)   1       
            // (2, 2)   2   

            // GetChildren(0, 0) -> (1, 0) (1, 1)

            // GetChildren(1, 0) -> (2, 0) (2, 1)
            // GetChildren(1, 1) -> (2, 1) (2, 2)

            // GetChildren(2, 0) -> (3, 0) (3, 1)
            // GetChildren(2, 1) -> (3, 1) (3, 2)
            // GetChildren(2, 2) -> (3, 2) (3, 3)

            // GetChildren(depth, index) -> (depth + 1, index) (depth + 1, index + 1)
            #endregion

            for (int n = 0; n < 2; n++)
            {
                int childDepth = depth + 1;
                int childIndex = index + n;

                Tuple<int, int> child = Tuple.Create(childDepth, childIndex);

                children.Add(child);
            }

            // return empty list when at bottom of triangle
            const int maxDepth = 2;
            if (depth >= maxDepth)
            {
                return new List<Tuple<int, int>>();
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
}
