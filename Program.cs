using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;
using System.Linq;

namespace Algorithms.Shell
{
    class Program
    {
        static void Main(string[] args)
        {
            var carBuilder = new CarBundleBuilder();
            carBuilder.AddEngine(25);
            carBuilder.AddMirrors(150);
            carBuilder.AddBattery(30);
            carBuilder.AddTubes(60);
            carBuilder.AddFrames(25);
            carBuilder.AddBody(50);
            var cars = carBuilder.Build();
            int value =  cars.Calculate();
        }
    }
}
