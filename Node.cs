namespace Queue
{
    class Node
    {
        public int Data { get; set; }
        public Node(int number)
        {
            Data = number;
        }
        public Node Next { get; set; }
    }
}
