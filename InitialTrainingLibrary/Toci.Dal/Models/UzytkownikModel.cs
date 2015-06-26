using Toci.Db.DbVirtualization;
using Toci.Db.Interfaces;

namespace Toci.Dal.Models
{
    public class UzytkownikModel : Model
    {
         public const string NAZWA = "nazwa";
         public const string HASLO = "haslo";

         public UzytkownikModel() : base("uzytkownik")
        {
        }

        public string Nazwa
        {
            get
            {
                return (string)Fields[NAZWA].GetValue();
            }
            set
            {
                SetValue(NAZWA, value);
            }
        }

        public string Haslo
        {
            get
            {
                return (string)Fields[HASLO].GetValue();
            }
            set
            {
                SetValue(HASLO, value);
            }
        }

        protected override IModel GetInstance()
        {
            return new UzytkownikModel();
        }
    }
}