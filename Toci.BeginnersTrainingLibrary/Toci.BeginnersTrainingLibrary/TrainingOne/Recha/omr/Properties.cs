namespace Toci.BeginnersTrainingLibrary.TrainingOne.Recha.omr
{
    public abstract class Properties
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public bool CannotBeNull { get; set; }

        protected Properties(string name, string type, bool cannotBeNull)
        {
            Name = name;
            Type = type;
            CannotBeNull = cannotBeNull;
        }
    }
}
