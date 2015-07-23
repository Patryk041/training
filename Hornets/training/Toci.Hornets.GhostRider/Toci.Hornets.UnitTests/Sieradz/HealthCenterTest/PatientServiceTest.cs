using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.HealthCenter.Abstracts;

namespace Toci.Hornets.UnitTests.Sieradz.HealthCenterTest
{
    [TestClass]
    public class PatientServiceTest
    {
        private PatientService _patientService;

        [TestInitialize]
        public void Init()
        {
            _patientService = new PatientService();
        }

        [TestMethod]
        public void GetAllPatientsTest()
        {
            var patientsList = _patientService.GetPatients();

            Assert.IsTrue(patientsList.Any());
        }
    }
}
