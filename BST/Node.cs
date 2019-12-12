using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node()
        {
            
        }
        public Node(int item)
        {
            data = item;
        }
        public void ChangePosition(Node node)
        {
            if (node == null)
                return;
            ChangePosition(node.left);
            ChangePosition(node.right);
            Console.WriteLine(" " + node.data);

        }
    }
}
