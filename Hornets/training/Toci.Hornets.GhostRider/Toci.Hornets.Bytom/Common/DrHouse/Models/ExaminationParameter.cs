namespace Toci.Hornets.Bytom.Common.DrHouse.Models
{
	public class ExaminationParameter : ISicknessIndicator
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public int Id { get; set; }
		public Unit Unit { get; set; }
		public ReferenceRange ReferenceRange { get; set; }
		public decimal Result { get; set; }
	}
}
