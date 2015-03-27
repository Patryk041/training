using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.TrainingFour.Reflection.Training
{
    public class ReflectKobieta
    {
        public void tests()
        {
            Kobieta kobieta = new Kobieta();
            Kobieta beata = new Kobieta();

            var methods = kobieta.GetType().GetMethods(BindingFlags.NonPublic);

            foreach (var method in methods)
            {
                //method.Invoke()
            }

            var constructors = kobieta.GetType().GetConstructors();

            var fields = kobieta.GetType().GetFields(BindingFlags.GetField);

            FieldInfo privateField = kobieta.GetType().GetField("ToCoNaPrawdeCzuje", BindingFlags.NonPublic | BindingFlags.Instance);
            privateField.SetValue(kobieta, "kocha");

            
        }
    }
}
