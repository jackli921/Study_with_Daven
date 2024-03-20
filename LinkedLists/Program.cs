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
        link_list.Insert(4, 1);
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

    // need to check if index is out of range or smaller than 0

    // need to check if head is null and index is 0, we make new node the head

    // traverse the existing linklist to one before the index
    // connect the tail of the current list to new_node.next
    // connect current.next to new_node
    public void Insert(int data, int index)
    {
        // if index is smaller than 0
        if (index < 0)
        {
            System.Console.WriteLine("Index out of range");
            return;
        }

        // make new node
        Node new_node = new Node(data);

        // if linklist is empty
        if (this.head is null)
        {
            head = new_node;
            return;
        }

        // if index is 0 and list is not empty
        if (index == 0)
        {
            new_node.next = this.head;
            this.head = new_node;
            return;
        }

        // inserting within linkedlist that's not empty nor inserting at the head 
        this.current = this.head;
        var count = 0;
        
        while (current.next != null && count < index - 1)
        {
            current = current.next;
            count++;
        }

        if (count != index -1)
        {
            System.Console.WriteLine("Index out of range");
        }

        new_node.next = current.next;
        current.next = new_node;
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