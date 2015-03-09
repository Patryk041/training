using System.Reflection;

namespace InitialTrainingLibrary.TrainingFour.Reflection.PreTest
{
    public class ReflectFlower
    {
        public void FillFlower()
        {
            Flower flower = new Flower();

            flower.Colour = "Red";
            //flower.Type 

            PropertyInfo flowerTypeInfo = flower.GetType().GetProperty("Type", BindingFlags.NonPublic | BindingFlags.Instance);

            flowerTypeInfo.SetValue(flower, "Rose");

            PropertyInfo flowerQuantityInfo = flower.GetType().GetProperty("Quantity", BindingFlags.NonPublic | BindingFlags.Instance);

            flowerQuantityInfo.SetValue(flower, 8);
        }
    }
}
