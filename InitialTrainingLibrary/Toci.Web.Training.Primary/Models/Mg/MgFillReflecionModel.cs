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

            const char propertySignOne = '<';
            const char propertySignTwo = '>';

            foreach (var field in fields)
            {

                var start = field.Name.IndexOf(propertySignOne) + 1;
                var amount = field.Name.IndexOf(propertySignTwo) - start;
                var fieldName = field.Name.Contains(propertySignOne.ToString()) ? field.Name.Substring(start, amount) : field.Name;
                field.SetValue(mgModel,_mgQueryDictionary[fieldName.ToUpper()]);
           

            }
            return mgModel;
        }
    }
}