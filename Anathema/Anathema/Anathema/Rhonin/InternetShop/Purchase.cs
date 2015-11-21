namespace Anathema.Rhonin.InternetShop
{
    public class Purchase
    {
        public int Count()
        {
            return 0;
        }

        public double Price()
        {
            return 0.1;
        }

        public string Name()
        {
            return "Proc";
        }

        public Discount Discount()
        {
            return new Discount();
        }

        public bool IsDiscount()
        {
            return true;
        }

        public int ProductId()
        {
            return 122;
        }
    }
}