using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            BSTree bst = new BSTree();
            bst.Add(11);
            bst.Add(22);
            bst.Add(23);
            bst.Add(14);

            bst.Search(23);
            Console.ReadLine();
        }
    }
    }

