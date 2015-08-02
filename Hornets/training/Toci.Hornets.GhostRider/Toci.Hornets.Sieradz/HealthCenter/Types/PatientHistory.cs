using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Toci.Hornets.Sieradz.HealthCenter.Types
{
    public class PatientHistory
    {
        public Dictionary<DateTime, PatientVisit> patientHistory;
    }
}