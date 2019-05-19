using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class IsBST
    {
        public static bool fnIsBST(RedBlackNode root)
        {
            int minRange = int.MinValue;
            int maxRange = int.MaxValue;

            return fnIsInRange(root, minRange, maxRange);
        }

        private static bool fnIsInRange(RedBlackNode node, int low, int high)
        {
            if (node == null)
                return true;

            if (node.Key > high || node.Key <= low)
                return false;

            return fnIsInRange(node.Left, low, node.Key) &&
                fnIsInRange(node.Right, node.Key, high);
        }
    }
}
