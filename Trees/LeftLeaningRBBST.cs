using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class LeftLeaningRBBST
    {
        private static bool RED = true;
        private static bool BLACK = false;

        public static string search(char k, RedBlackNode root)
        {
            RedBlackNode node = root;

            while (node != null)
            {
                int cmp = k.CompareTo(node.Key);
                if (k < 0)
                    node = node.Left;
                else if (k > 0)
                    node = node.Right;
                else
                    return node.Value;
            }

            return null;
        }

        public static RedBlackNode insert(RedBlackNode node, char k, string val)
        {
            if (node == null)
                return new RedBlackNode(k, val, RED);

            int cmp = k.CompareTo(node.Key);

            if (cmp < 0)
                node.Left =  insert(node.Left, k, val);
            else if (cmp > 0)
                node.Right = insert(node.Right, k, val);
            else
                node.Value = val;

            if (!isRedNode(node.Left) && isRedNode(node.Right))
                node = LeftRotate(node);

            if (isRedNode(node.Left) && isRedNode(node.Left.Left))
                node = RightRotate(node);

            if (isRedNode(node.Left) && isRedNode(node.Right))
                FlipColors(node);

            return node;
        }
        private static bool isRedNode(RedBlackNode node)
        {
            if (node == null)
                return false;

            return node.Color == RED;
        }

        private static RedBlackNode LeftRotate(RedBlackNode h)
        {
            RedBlackNode x = h.Right;
            h.Right = x.Left;
            x.Color = h.Color;
            h.Color = RED;
            x.Left = h;
            return x;
        }

        private static RedBlackNode RightRotate(RedBlackNode h)
        {
            RedBlackNode x = h.Left;
            h.Left = x.Right;
            x.Right = h;
            x.Color = h.Color;
            h.Color = RED;
            return x;
        }

        private static void FlipColors(RedBlackNode h)
        {
            h.Left.Color = BLACK;
            h.Right.Color = BLACK;
            h.Color = RED;
        }
    }
}
