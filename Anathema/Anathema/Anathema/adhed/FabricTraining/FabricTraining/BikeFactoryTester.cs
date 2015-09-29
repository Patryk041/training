using System;
using System.Runtime.CompilerServices;

namespace FabricTraining
{
    public class BikeFactoryTester
    {
        public static void Main()
        {
            BikeFactory factory = new BikeFactory();

            IBike roadBike = factory.GetBike("RoadBike");
            roadBike.FrameSize = 54;

            Console.WriteLine(roadBike.Description + " with " + roadBike.FrameSize);

            IBike anotherBike = factory.GetBike("RoadBike");

            Console.WriteLine(anotherBike.Description + " with " + anotherBike.FrameSize);

            Console.ReadLine();
        } 
    }
}