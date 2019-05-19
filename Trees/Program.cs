using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            RedBlackNode root = null;
            root = LeftLeaningRBBST.insert(root, 'S', "1");
            root = LeftLeaningRBBST.insert(root, 'E', "2");
            root = LeftLeaningRBBST.insert(root, 'A', "3");
            root = LeftLeaningRBBST.insert(root, 'R', "4");
            root = LeftLeaningRBBST.insert(root, 'C', "5");
            root = LeftLeaningRBBST.insert(root, 'H', "6");
            root = LeftLeaningRBBST.insert(root, 'E', "7");
            root = LeftLeaningRBBST.insert(root, 'X', "8");
            root = LeftLeaningRBBST.insert(root, 'A', "9");
            root = LeftLeaningRBBST.insert(root, 'M', "10");
            root = LeftLeaningRBBST.insert(root, 'P', "11");
            root = LeftLeaningRBBST.insert(root, 'L', "12");
            root = LeftLeaningRBBST.insert(root, 'E', "13");

            Console.WriteLine(IsBST.fnIsBST(root));
            Console.Read();

        }
    }
}
