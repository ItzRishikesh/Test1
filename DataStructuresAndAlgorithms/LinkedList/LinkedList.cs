using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.LinkedList
{
    public class LinkedList
    {
       
        //This is the Start node of the linked list chain
        Node? head = null;
        public void AddToLast(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            if (head is null)
            {
               
                head = newItem;
                head.next = null;
            }
            else
            {
                Node current = head;
                while (current.next is not null)
                {
                    current=current.next;
                }
                current.next = newItem;
                current.next = null;
            }
        }
        public void AddToFirst(object data)
        {
            Node newItem = new Node();
            newItem.data = data;
            newItem.next = head;
            head = newItem;
        }
        public void ReadAll()
        {
            Node? current = head;
            while (current?.next is not null)
            {
                Console.WriteLine(current.data);

                current = current.next;
            }
        }
    }
}
