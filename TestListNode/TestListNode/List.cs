using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTestListNode
{
    public class List
    {
        private Node first;

        public List()
        {
            first = null;
        }

        private bool IsEmpty()
        {
            return (first == null ? true : false);
        }

        public Node FindByName(string name)
        {
            Node result = null;

            if (!IsEmpty())
            {
                Node i = first;
                while (i.next != null)
                {
                    if (name.Equals(i.Name))
                        result = i;
                    i = i.next;
                }
                if (name.Equals(i.Name))
                    result = i;
            }

            return result;
        }

        public void AddAfterOf(string name, Node newNode)
        {
            if (!IsEmpty())
            {
                Node position = FindByName(name);

                if (position != null)
                {
                    newNode.next = position.next;
                    position.next = newNode;
                }
            }
        }

        public void AddFirst(Node newNode)
        {
            if (IsEmpty())
            {
                first = newNode;
            }
            else
            {
                newNode.next = first;
                first = newNode;
            }
        }

        public void DeleteFirst()
        {
            if (!IsEmpty())
            {
                if (first.next == null)
                {
                    first = null;
                }
                else
                {
                    first = first.next;
                }
            }
        }

        public void AddLast(Node newNode)
        {
            if (IsEmpty())
            {
                first = newNode;
            }
            else
            {
                Node i = first;
                while (i.next != null)
                    i = i.next;
                i.next = newNode;
            }
        }

        public void DeleteLast()
        {
            if (!IsEmpty())
            {
                if (first.next == null)
                {
                    first = null;
                }
                else
                {
                    Node i = first;
                    Node previous = null;
                    while (i.next != null)
                    {
                        previous = i;
                        i = i.next;
                    }
                    previous.next = null;
                }
            }
        }

        public void Show()
        {
            if(!IsEmpty())
            {
                Node i = first;
                while(i.next != null)
                {
                    Console.Write("{0}", i.Name);
                    i = i.next;
                }
                Console.Write("{0}", i.Name);
            }

            Console.WriteLine("");
        }
    }
}
