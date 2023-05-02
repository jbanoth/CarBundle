using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Shell
{
    public class WheelBundleBuilder
    {
        private INode _frameNode;
        private INode _tubeNode;
        public WheelBundleBuilder AddTubes(int count)
        {
            _tubeNode = new Node(InventoryType.Tube) { Count = count };
            return this;
        }

        public WheelBundleBuilder AddFrames(int count)
        {
            _frameNode = new Node(InventoryType.Frame) { Count = count };
            return this;
        }

        public Wheel Build()
        {
            var wheel = new Wheel();
            wheel.Children.Add(_tubeNode);
            wheel.Children.Add(_frameNode);
            return wheel;
        }
    }
}
