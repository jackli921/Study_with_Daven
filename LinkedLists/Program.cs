public class Node
{
    public int data;
    public Node? next;
    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}

public class LinkedList
{
    public Node? head; 
    public Node? last;
    public Node? current;

    public LinkedList()
    {
        this.head = null;
    }

    public void Append(int data)
    {
        Node newNode = new Node(data);

        if(head is null) head = newNode;

        else
        {
            Node current = head;
            while (current.next != null) current = current.next;
            current.next = newNode;
        }
    }

    public void PrintList()
    {
        Node? current = head;
        while (current != null)
        {
            Console.WriteLine(current.data);
            current = current.next;
        }
    }
}

public class Program
{
    public static void Main()
    {
        LinkedList linkedList = new LinkedList();
        linkedList.Append(1);
        linkedList.Append(2);
        linkedList.Append(3);
        linkedList.PrintList();
    }

}