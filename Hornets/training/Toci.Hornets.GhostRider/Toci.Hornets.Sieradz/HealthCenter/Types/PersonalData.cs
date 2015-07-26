using System;
using System.Xml.Serialization;
using Toci.Hornets.Sieradz.HealthCenter.Enums;

namespace Toci.Hornets.Sieradz.HealthCenter.Types
{
    [XmlRoot("PersonalData")]
    public class PersonalData
    {
       //[XmlElement("Wiek")]
       //public int Wiek { get; set; } Age jest poniżej, użyj go. Wiek użyty w DefaultPatientsloader.cs został zakomentowany.

        public static DateTime dateOfBirth;
        public static DateTime today = DateTime.Today;
        public int age 
        {
            get { return today.Year - dateOfBirth.Year; }
            set {}
        }
        public string name;
        public string surname;
        public string address;
        public string phoneNumber;
        public gender gen;


    }
}