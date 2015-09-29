using System;

namespace FabricTraining
{
    public class BikeFactoryTester
    {
        public static void Main()
        {
            BikeFactory factory = new BikeFactory();
            IBike roadBike = factory.GetBike("RoadBike");

            Console.WriteLine(roadBike.Description);
        } 
    }
}