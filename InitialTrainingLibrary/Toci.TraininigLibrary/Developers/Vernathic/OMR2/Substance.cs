namespace Toci.TraininigLibrary.Developers.Vernathic.OMR2
{
    public class Substance
    {
        public enum TypeOfSubstance
        {
            Coffee,
            Water,
            Milk,
            Sugar
        }

        public static TypeOfSubstance MyType { get; set; }

        public Substance(TypeOfSubstance typeOfSubstance)
        {
            MyType = typeOfSubstance;
        }

        public Substance()
        {
            
        }
    }
}