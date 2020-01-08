using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS_Einfach_Verkettete_Liste_001
{
    public class Node
    {
        public Node next;
        public Object data;
    }

    // see also https://stackoverflow.com/questions/3823848/creating-a-very-simple-linked-list
    public class LinkedList
    {
        private Node head/* = null*/;

        public void PrintAllNodes()
        {
            Node current = head;
            while(current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void AddLast(Object data)
        {
            Node toAdd = new Node();            // mit null.
            toAdd.data = data;
            toAdd.next = null;

            // Insert 1. object
            if (head == null)
            {
                // head.next = toAdd.next;      // ERROR: kein Objekt !
                head = toAdd;
            }
            else
            {
                // Insert further objects at the end
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;     // Der Knoten zeigt jetzt auf den nächsten Knoten
                }
                current.next = toAdd;           // ?!?
                // ? current = toAdd;
            }
        }

        public void AddFirst(Object data)
        {
            Node toAdd = new Node();            // mit null.
            toAdd.data = data;

            // Insert 1. object
            if (head == null)
            {
                // head.next = toAdd.next;      // ERROR: kein Objekt !
                head = toAdd;
                //toAdd.next = null;
            }
            else
            {
                // Insert further objects to the beginning
                // ? toAdd = head.next;
                // ? toAdd.next = head.next;
                toAdd.next = head;              // ?!?
                head = toAdd;                   // Reihenfolge entscheidend !
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add Last:");
            LinkedList myList1 = new LinkedList();
            myList1.AddLast("1");
            myList1.AddLast("2");
            myList1.AddLast("3");
            myList1.AddLast("4");
            myList1.AddLast("5");
//            myList1.PrintAllNodes();

            myList1.AddFirst("10");
            myList1.AddFirst("11");
            myList1.AddFirst("12");
            myList1.PrintAllNodes();

            Console.ReadLine();
        }
    }
}
