namespace Toci.Hornets.Bytom.Common.DrHouse
{
	public abstract class Patient
	{
		public int Age { get; set; }
		public string Name { get; set; }
		public Gender Gender { get; set; }
	}

	public enum Gender
	{
		Male, Female, Other
	}
}
