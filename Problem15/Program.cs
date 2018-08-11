using System;
using System.Collections.Generic;
using Common;

namespace Problem15
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Problem 15");

            Test();

            const int gridSize = 25;
            var result = Utilities.TimeFunction(Solve, gridSize);
            long numberGridPaths = result.Item1;
            TimeSpan timeSpan = result.Item2;
            Console.WriteLine($"numberGridPaths = {numberGridPaths}, timeSpan = {timeSpan.TotalMinutes}");

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void Test()
        {
            Grid grid = new Grid(1);

            Tuple<int, int> node = Tuple.Create(0, 0);
            var children = grid.GetChildren(node);
            int count = children.Count;
            Utilities.Assert(count == 2);

            node = Tuple.Create(0, 1);
            children = grid.GetChildren(node);
            count = children.Count;
            Utilities.Assert(count == 1);

            node = Tuple.Create(1, 0);
            children = grid.GetChildren(node);
            count = children.Count;
            Utilities.Assert(count == 1);

            node = Tuple.Create(1, 1);
            children = grid.GetChildren(node);
            count = children.Count;
            Utilities.Assert(count == 0);

            Tuple<int, int> root = Tuple.Create(0, 0);
            long numberGridPaths = grid.GetNumberGridPaths(root);
            Utilities.Assert(numberGridPaths == 2);

            grid = new Grid(2);

            root = Tuple.Create(0, 0);
            numberGridPaths = grid.GetNumberGridPaths(root);
            Utilities.Assert(numberGridPaths == 6);
        }

        private static long Solve(int gridSize)
        {
            Grid grid = new Grid(gridSize);
            Tuple<int, int> startNode = Tuple.Create(0, 0);

            long numberGridPaths = grid.GetNumberGridPaths(startNode);

            return numberGridPaths;
        }
    }

    internal class Grid
    {
        private int GridSize { get; }

        public Grid(int gridSize)
        {
            GridSize = gridSize;
        }

        public long GetNumberGridPaths(Tuple<int, int> node)
        {
            List<Tuple<int, int>> children = GetChildren(node);
            long numberGridPaths = 0;

            if (children.Count == 0)
            {
                return 1;
            }

            foreach (Tuple<int, int> child in children)
            {
                numberGridPaths += GetNumberGridPaths(child);
            }

            return numberGridPaths;
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        public List<Tuple<int, int>> GetChildren(Tuple<int, int> node)
        {
            List<Tuple<int, int>> children = new List<Tuple<int, int>>();
            int row = node.Item1;
            int col = node.Item2;
            Tuple<int, int> child;

            // if at bottom-right, return empty list
            if (row == GridSize && col == GridSize)
            {
                return children;
            }

            if (col < GridSize)
            {
                child = Tuple.Create(row, col + 1);
                children.Add(child);
            }

            // ReSharper disable once InvertIf
            if (row < GridSize)
            {
                child = Tuple.Create(row + 1, col);
                children.Add(child);
            }

            return children;
        }
    }
}
