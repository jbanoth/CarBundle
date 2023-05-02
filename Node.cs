using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Shell
{
    public interface INode
    {
        int Calculate();
        InventoryType Type { get; }
        int Count { get; }
    }

    public class Node : INode
    {
        public Node(InventoryType inventoryType)
        {
            Type = inventoryType;
            Children = new List<INode>();
        }

        public int Count { get; set; }
        public IList<INode> Children { get; set; }

        public InventoryType Type { get; }

        public virtual int Calculate()
        {
            return Count;
        }
    }
}
