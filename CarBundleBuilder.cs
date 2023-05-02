using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Shell
{
    public class CarBundleBuilder
    {
        private INode _engineNode;
        private INode _batteryNode;
        private INode _bodyNode;
        private INode _mirrorNode;
        private WheelBundleBuilder _wheelBundleBuilder = new WheelBundleBuilder();
        public CarBundleBuilder AddEngine(int count)
        {
            _engineNode = new Node(InventoryType.Tube) { Count = count };
            return this;
        }

        public CarBundleBuilder AddBattery(int count)
        {
            _batteryNode = new Node(InventoryType.Tube) { Count = count };
            return this;
        }

        public CarBundleBuilder AddBody(int count)
        {
            _bodyNode = new Node(InventoryType.Tube) { Count = count };
            return this;
        }

        public CarBundleBuilder AddMirrors(int count)
        {
            _mirrorNode = new Node(InventoryType.Tube) { Count = count };
            return this;
        }

        public CarBundleBuilder AddTubes(int count)
        {
            _wheelBundleBuilder.AddTubes(count);
            return this;
        }

        public CarBundleBuilder AddFrames(int count)
        {
            _wheelBundleBuilder.AddFrames(count);
            return this;
        }

        public INode Build()
        {
            var car = new Car();
            car.Children.Add(_bodyNode);
            car.Children.Add(_batteryNode);
            car.Children.Add(_engineNode);
            car.Children.Add(_mirrorNode);
            var wheel = _wheelBundleBuilder.Build();
            car.Children.Add(wheel);
            return car;
        }
    }
}
