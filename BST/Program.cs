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
            bst.Add(2);
            bst.Add(15);
            bst.Add(6);
            bst.Add(19);
            bst.Display();
            // bst.Search(5);
            bst.Search(2);
            Console.ReadLine();
        }
    }
    }

