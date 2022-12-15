using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListDS
{
    internal class linkedlist
    {
        internal node head;
        public void Add(int id)
        {
            node Node = new node(id);
            if (this.head == null)
            {
                this.head = Node;
            }
            else
            {
                node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                    temp.next = Node;
                }

            }
            Console.WriteLine("{0} is inserted into the Linked List ", Node.id);
        }
    }
}
