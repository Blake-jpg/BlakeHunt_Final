namespace BlakeHunt_Final
{
    public class Node
    {
        public Node next;
        public Object data;
    }
    public class LinkedList
    {
        private Node head;

        public void AllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
        public void AddNode(Object data)
        {
            Node add = new Node();
            add.data = data;
            Node current = head;
            while (current != null)
            {
                current = current.next;
            }
            current.next = add;
        }
    }
}