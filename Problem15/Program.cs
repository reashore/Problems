using System.Collections.Generic;
using Common;
using static System.Console;

namespace Problem15
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            WriteLine("Problem 15");

            ulong answer = Solve();
            WriteLine($"numberGridPaths = {answer}");

            WriteLine("Done");
            ReadKey();
        }

        public static ulong Solve()
        {
            const int gridSize = 20;

            Grid grid = new Grid(gridSize);
            Node startNode = new Node(0, 0);

            ulong numberGridPaths = grid.GetNumberGridPaths(startNode);

            return numberGridPaths;
        }
    }

    public class Grid
    {
        private int GridSize { get; }

        public Grid(int gridSize)
        {
            GridSize = gridSize;
        }

        public ulong GetNumberGridPaths(Node node)
        {
            List<Node> children = GetChildren(node);
            ulong numberGridPaths = 0;

            if (children.Count == 0)
            {
                return 1;
            }

            foreach (Node child in children)
            {
                numberGridPaths += GetNumberGridPaths(child);
            }

            return numberGridPaths;
        }

        private List<Node> GetChildren(Node node)
        {
            List<Node> children = new List<Node>();
            int row = node.Row;
            int col = node.Col;
            Node child;

            if (col < GridSize)
            {
                child = new Node(row, col + 1);
                children.Add(child);
            }

            // ReSharper disable once InvertIf
            if (row < GridSize)
            {
                child = new Node(row + 1, col);
                children.Add(child);
            }

            // if at bottom-right, return empty list

            return children;
        }
    }
}
