using System;
using System.Xml.Serialization;
using Toci.Hornets.Sieradz.HealthCenter.Interfaces;
using Toci.Hornets.Sieradz.HealthCenter.Types;

namespace Toci.Hornets.Sieradz.HealthCenter.Abstracts
{
    [Serializable]
    [XmlRoot("Patient")]
    public class Patient : IPatient
    {
        private PatientHistory _patientHistory;
        private PersonalData _personalData;

        [XmlElement("PatientHistory")]
        public PatientHistory PatientHistory 
        {
            get
            {
                return _patientHistory;
            }
            set
            {
                if (_patientHistory != value)
                    _patientHistory = value;
            }
        }

        [XmlElement("PersonalData")]
        public PersonalData PersonalData
        {
            get
            {
                return _personalData;
            }
            set
            {
                if (_personalData != value)
                    _personalData = value;
            }
        }
    }
}