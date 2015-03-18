using System.Collections.Generic;
using System.ComponentModel;
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

                var fieldName = field.Name.GetPropertyName();
                if(_mgQueryDictionary.ContainsKey(fieldName)) field.SetValue(mgModel,_mgQueryDictionary[fieldName.ToUpper()]);
                

            }
            return mgModel;
        }
    }
}