using Common;

namespace Problem15
{
    public static class Problem15
    {
        public static ulong Solve()
        {
            const int gridSize = 20;

            Grid grid = new(gridSize);
            Node startNode = new(0, 0);

            ulong numberGridPaths = grid.GetNumberGridPaths(startNode);

            return numberGridPaths;
        }
    }
}