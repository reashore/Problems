using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem18
{
    public class Triangle
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

        public long FindMaxPathSum(Node node)
        {
            long nodeValue = GetNodeValue(node);
            List<Node> children = GetChildren(node);

            // if node has no children, then return
            if (children.Count == 0)
            {
                return nodeValue;
            }

            long maxPathSum = 0;

            foreach (Node child in children)
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

        private List<Node> GetChildren(Node node)
        {
            int depth = node.Depth;
            int index = node.Index;
            List<Node> children = new List<Node>();

            // leaf nodes return empty child list
            if (depth + 1 >= MaxDepth)
            {
                return children;
            }

            for (int n = 0; n < 2; n++)
            {
                int childDepth = depth + 1;
                int childIndex = index + n;

                Node child = new Node(childDepth, childIndex);

                children.Add(child);
            }

            return children;
        }

        private int GetNodeValue(Node node)
        {
            int depth = node.Depth;
            int index = node.Index;

            int value = _triangle[depth][index];

            return value;
        }

        #endregion
    }
}