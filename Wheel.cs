using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithms.Shell
{
    public class Wheel : Node, INode
    {
        public Wheel() : base(InventoryType.Wheel) { }
        public override int Calculate()
        {
            var frame = Children.SingleOrDefault(i => i.Type == InventoryType.Frame);
            var tube = Children.SingleOrDefault(i=>i.Type == InventoryType.Tube);
            /*
             * Wheel is combination of 1 frame + 2 tube
             */
            return Math.Min(frame.Count, (int)(tube.Count / 2));
        }
    }
}
