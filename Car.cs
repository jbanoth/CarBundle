using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithms.Shell
{
    public class Car : Node, INode
    {
        public Car() : base(InventoryType.Car)
        {
        }

        public override int Calculate()
        {
            /*
             * Car has
             * 1 Engine
             * 2 Batteries
             * 4 Wheels
             * 1 Body
             * 6 Mirrors
             */
            //var engineCount = Children.FirstOrDefault(i => i.Type == InventoryType.Engine).Calculate();
            //var bodyCount = Children.FirstOrDefault(i => i.Type == InventoryType.Body).Calculate();
            //var batteriesCount = Children.FirstOrDefault(i => i.Type == InventoryType.Batteries).Calculate();
            //var wheelCount = Children.FirstOrDefault(i => i.Type == InventoryType.Wheel).Calculate();
            var min = int.MaxValue;
            foreach (var node in Children)
            {
                switch (node.Type)
                {
                    case InventoryType.Wheel:
                        min = Math.Min(min, node.Calculate() / 4);
                        break;
                    case InventoryType.Mirror:
                        min = Math.Min(min, node.Calculate() / 6);
                        break;
                    default:
                        min = Math.Min(min, node.Calculate());
                        break;
                }
            }
            return min;
        }
    }
}
