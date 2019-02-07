using System;
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

            Test();

            const int gridSize = 20;
            var result = Utilities.TimeFunction(Solve, gridSize);
            ulong numberGridPaths = result.Item1;
            TimeSpan timeSpan = result.Item2;
            // numberGridPaths = 137846528820, timeSpan = 11.0657929098611
            WriteLine($"numberGridPaths = {numberGridPaths}, timeSpan = {timeSpan.TotalHours}");

            WriteLine("Done");
            ReadKey();
        }

        private static void Test()
        {
            Grid grid = new Grid(1);

            Node node = new Node(0, 0);
            List<Node> children = grid.GetChildren(node);
            int count = children.Count;
            Utilities.Assert(count == 2);

            node = new Node(0, 1);
            children = grid.GetChildren(node);
            count = children.Count;
            Utilities.Assert(count == 1);

            node = new Node(1, 0);
            children = grid.GetChildren(node);
            count = children.Count;
            Utilities.Assert(count == 1);

            node = new Node(1, 1);
            children = grid.GetChildren(node);
            count = children.Count;
            Utilities.Assert(count == 0);

            Node root = new Node(0, 0);
            ulong numberGridPaths = grid.GetNumberGridPaths(root);
            Utilities.Assert(numberGridPaths == 2);

            grid = new Grid(2);
            numberGridPaths = grid.GetNumberGridPaths(root);
            Utilities.Assert(numberGridPaths == 6);

            WriteLine("Tests done");
        }

        private static ulong Solve(int gridSize)
        {
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

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        public List<Node> GetChildren(Node node)
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
