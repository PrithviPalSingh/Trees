using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public enum Color
    {
        RED,
        BLACK
    }

    class RedBlackNode
    {
        public RedBlackNode Left { get; set; }
        public RedBlackNode Right { get; set; }
        public bool Color { get; set; }
        public char Key { get; set; }
        public string Value { get; set; }

        public RedBlackNode(char key, string val, bool color)
        {
            this.Key = key;
            this.Value = val;
            this.Color = color;
        }
    }
}
