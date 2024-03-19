// public class Node
// {
//     public int data;
//     public Node? next;
//     public Node(int data)
//     {
//         this.data = data;
//         this.next = null;
//     }
// }

// public class LinkedList
// {
//     public Node? head; 
//     public Node? last;
//     public Node? current;

//     public LinkedList()
//     {
//         this.head = null;
//     }

//     public void Append(int data)
//     {
//         Node newNode = new Node(data);

//         if(head is null) head = newNode;

//         else
//         {
//             Node current = head;
//             while (current.next != null) current = current.next;
//             current.next = newNode;
//         }
//     }

//     public void PrintList()
//     {
//         Node? current = head;
//         while (current != null)
//         {
//             Console.WriteLine(current.data);
//             current = current.next;
//         }
//     }
// }

// public class Program
// {
//     public static void Main()
//     {
//         LinkedList linkedList = new LinkedList();
//         linkedList.Append(1);
//         linkedList.Append(2);
//         linkedList.Append(3);
//         linkedList.PrintList();
//     }

// }



public class Program
{
    public static void Main()
    {
        LinkedList link_list = new LinkedList();
        link_list.Append(1);
        link_list.Append(2);
        link_list.Append(3);
        link_list.PrintList();
    } 
}

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
    public Node? current;

    public LinkedList()
    {
        this.head = null;
    }

    public void Append(int data)
    {
        Node new_node = new Node(data);
        
        if (this.head is null)
        {
            this.head = new_node;
        }
        else
        {
            this.current = this.head;
            while (this.current.next is not null)
            {
                this.current = this.current.next;
            }
            this.current.next = new_node;
        }
    }

    //inserting a node at a specific position

    public void Insert(int data, int index)
    {
        // check if index is less than 0
        if (index < 0)
        {
            System.Console.WriteLine("index out of range");
            return;
        }

        // create new node
        Node new_node = new Node(data);

        // insert at 0
        if(index == 0)
        {
            new_node.next = head;
            head = new_node;
        }
        else
        {
            Node current = head;
            int count = 1;

            while (current != null && count < index)
            {
                current = current.next
                count++;
            }   
            if (current == null)
            {
                System.Console.WriteLine("Index out of range");
                return;
            } 
            new_node.next = current.next;
            current.next = new_node;
        }
    }

    public void PrintList()
    {
        this.current = this.head;
        while (this.current is not null)
        {
            System.Console.WriteLine(this.current.data);
            this.current = this.current.next;
        }
    }
}