namespace Problem18
{
    public class Node
    {
        public Node(int depth, int index)
        {
            Depth = depth;
            Index = index;
        }

        public int Depth { get; }
        public int Index { get; }
    }
}