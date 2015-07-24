namespace Toci.Hornets.GhostRider.NFZ.Przychodnia.Pacjenct.Interface
{
    public interface IAddress
    {
         string City { get; set; }
         string Postcode { get; set; }

         string Street { get; set; }
         int HouseNumber { get; set; }

         string Province { get; set; }
         string Country { get; set; }
         
    }
}