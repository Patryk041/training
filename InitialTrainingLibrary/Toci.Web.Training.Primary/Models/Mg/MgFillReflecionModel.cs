using System.Collections.Generic;
using System.Reflection;

namespace Toci.Web.Training.Primary.Models.Mg
{
    public class MgFillReflecionModel
    {
        private Dictionary<string, string> _mgQueryDictionary; 
        public MgFillReflecionModel(Dictionary<string,string> mgQueryDictionary)
        {

            this._mgQueryDictionary = mgQueryDictionary;
        }

        public MgReflectionModel GetFilledMgReflectionModelModel()
        {
            MgReflectionModel mgModel = new MgReflectionModel();
            var fields= mgModel.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var field in fields)
            {
                var start = field.Name.IndexOf('<')+1;
                var amount = field.Name.IndexOf('>')-start;
                var fieldName = field.Name.Substring(start, amount);
                field.SetValue(mgModel,_mgQueryDictionary[fieldName.ToUpper()]);
           

            }
            return mgModel;
        }
    }
}