namespace Toci.Hornets.GhostRider.TrainingSeven.Exceptions
{
    public class BusinessLogic
    {
        public void BusinesLogicOperation()
        {
            DbModel model = new DbModel();

            try
            {
                model.DbOperation();
            }
            catch (DatabaseProjectException ex)
            {
                throw new BusinessLogicProjectException("dsaf", ex, "_dbsauhfgsdhfgbsi");
            }
        }
    }
}