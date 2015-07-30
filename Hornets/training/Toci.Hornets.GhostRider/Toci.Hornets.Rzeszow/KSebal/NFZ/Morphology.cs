using System;
using System.Collections.Generic;
using System.Configuration;
using Toci.Hornets.GhostRider.NFZ.Przychodnia.Base.Interface;
using Toci.Hornets.GhostRider.NFZ.Przychodnia.Base.Types;
using Toci.Hornets.GhostRider.NFZ.Przychodnia.ExaminationManagement.Interfaces;
using Toci.Hornets.Rzeszow.KSebal.TrainingFourHomework;

namespace Toci.Hornets.Rzeszow.KSebal.NFZ
{   
    
    public class Morphology: IExamination<double>
    {
        private Examination _data;
        private Dictionary<string, double> _resultDictionary;

        public Morphology(Examination data)
        {    
            _resultDictionary=new Dictionary<string, double>();
            _data = data;
        }

        public Morphology(Examination data, Dictionary<string,double> morphology )
        {
            _data = data;
            _resultDictionary = morphology;
        }

        public Examination GetExaminationData()
        {
            return _data;
        }

        public Dictionary<string, double> GetResultDictionary()
        {
            return _resultDictionary;
        }

        public void AddBloodExam(string name,double value)
        {
            _resultDictionary.Add(name,value);
        }

        public bool ChangeValue(string name, double value)
        {
            if (!_resultDictionary.ContainsKey(name)) return false;
            _resultDictionary[name] = value;
            return true;
        }

        public void changeExaminationData(Examination newData)
        {
            _data = newData;
        }

    }


 }
