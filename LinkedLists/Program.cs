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
        link_list.Delete(0);
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

    // delete at index
    public void Delete(int index)
    {
        // if index is smaller than 0
        if(index < 0)
        {
            System.Console.WriteLine("index out of range");
            return;
        }
        
        if (head == null)
        {
            System.Console.WriteLine("Empty list, nothing to delete");
            return;
        }

        // if index is 0, we use current.next as the new head
            // if there is 1 or  more than 1 node in the remaining list
            // if the link list was size of 1 and there is nothing left after removing first

        if (index == 0)
        {
            // start at index 0
            this.current = this.head;
            
            // if there's nothing after the first node, then empty the link
            if (this.current.next == null)
            {
                this.head = null;
                return;
            }
            
            //if there are nodes after the first, make the next immediate node the hed 
            this.head = this.current.next;
            return;
        }
        
        // last scenario: removing a node between nodes
        // if the position being removed is the last one, then there's nothing to attach 

        // else, attach current.next with the node after the one at our index 

        this.current = this.head;
        int count = 0; 
        while (this.current.next != null && count < index - 1)
        {
            this.current = this.current.next;
            count++;
        }

        if (count != index -1 || current == null || current.next == null)
        {
            System.Console.WriteLine("index out of range");
            return;
        }

        this.current.next = this.current.next.next;
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