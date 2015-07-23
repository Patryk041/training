using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using Toci.Hornets.Sieradz.HealthCenter.Abstracts;
using Toci.Hornets.Sieradz.HealthCenter.PathHolders;

namespace Toci.Hornets.Sieradz.HealthCenter.Loaders
{
    public class XmlPatientsLoader : PatientsLoader
    {
        public override List<Patient> LoadPatients()
        {
            var serializer = new XmlSerializer(typeof(List<Patient>), new XmlRootAttribute("Patients"));
            var patients = new List<Patient>();

            using (var reader = new XmlTextReader(SieradzPatientsDataPathHolder.PatientsFilesPath + "Patients.xml"))
            {
                patients = (List<Patient>)serializer.Deserialize(reader);
            }

            return patients;
        }
    }
}