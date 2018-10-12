using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestListNode
{
    public class Node
    {
        private string name;
        public Node next;

        public Node (string name)
        {
            this.name = name;
            this.next = null;
        }

        public string Name
        {
            get { return name; }
        }
    }
}
