namespace Toci.Hornets.Bytom.Common.DrHouse.Types
{
	public class ExaminationParameter
	{
		public string Name { get; set; }
		public Unit Unit { get; set; }
		public ReferenceRange ReferenceRange { get; set; }
		public decimal Result { get; set; }
	}

	public class ReferenceRange
	{
		public decimal Min { get; set; }
		public decimal Max { get; set; }
	}
}
