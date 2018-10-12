using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestListNode
{
    enum OPT
    {
        ADD_NODE_FIRST = 1,
        ADD_NODE_LAST,
        DEL_FIRST_NODE,
        DEL_LAST_NODE,
        SHOW_LIST,
        ADD_AFTER_OF,
        FIND_BY_NAME,
        QUIT_PROGRAM
    };

    class Program
    {
        static void Main(string[] args)
        {
            OPT option = OPT.ADD_NODE_FIRST;

            int inputInt = 0;
            int valuesCount = 0;
            string keyNode = "5";

            List values = new List();

            do
            {
                ShowMenu();
                string inputString = Console.ReadLine();
                Int32.TryParse(inputString, out inputInt);
                option = (OPT)inputInt;

                switch (option)
                {
                    case OPT.ADD_NODE_FIRST:
                        ++valuesCount;
                        values.AddFirst(new Node(valuesCount.ToString()));
                        break;
                    case OPT.ADD_NODE_LAST:
                        ++valuesCount;
                        values.AddLast(new Node(valuesCount.ToString()));
                        break;
                    case OPT.DEL_FIRST_NODE:
                        values.DeleteFirst();
                        break;
                    case OPT.DEL_LAST_NODE:
                        values.DeleteLast();
                        break;
                    case OPT.SHOW_LIST:
                        values.Show();
                        break;
                    case OPT.ADD_AFTER_OF:
                        ++valuesCount;
                        values.AddAfterOf(keyNode, new Node(valuesCount.ToString()));
                        break;
                    case OPT.FIND_BY_NAME:
                        if (values.FindByName(keyNode) != null)
                            Console.WriteLine("Found!");
                        else
                            Console.WriteLine("Opps! Not found");
                        break;
                }
            } while (option != OPT.QUIT_PROGRAM);
        }

        static void ShowMenu()
        {
            Console.WriteLine("Sample List");
            Console.WriteLine("-----------");
            Console.WriteLine("1. Add node first");
            Console.WriteLine("2. Add node last");
            Console.WriteLine("3. Del first node");
            Console.WriteLine("4. Del last node");
            Console.WriteLine("5. Show list");
            Console.WriteLine("6. Add after of");
            Console.WriteLine("7. Find by name");
            Console.WriteLine("8. Quit");
            Console.WriteLine(": ");
        }
    }
}
