using Toci.Dal.Models;
using Toci.Db.Interfaces;

namespace TrainingTen.Logic.Login
{
    public class LoginLogic : Logic
    {
        public bool Login(string user, string password)
        {
            IModel model = new UzytkownikModel() { Nazwa = user, Haslo = password};
            model.SetWhere(UzytkownikModel.NAZWA);
            model.SetWhere(UzytkownikModel.HASLO);
            var result = model.GetDataRowsList(DbHandle.GetData(model));

            return result.Count > 0;
        }
    }
}