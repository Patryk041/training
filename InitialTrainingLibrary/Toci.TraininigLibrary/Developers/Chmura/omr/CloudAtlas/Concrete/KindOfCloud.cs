using System.Collections.Generic;
using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Interface;

namespace Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Concrete
{
    public class KindOfCloud : IKindOfCloud
    {
        private List<ICloudType> _matchedCloudTypes;
        private List<ICloudSubType> _matchedCloudSubTypes;
        private List<IPhenomenon> _matchedPhenomenons;
        private string _name;
        private string _details;
        private string _baseShape;
        private string _additionalCharacteristics;
        public string Name
        {
            get { return _name; }
        }

        public string Details
        {
            get { return _details; }
        }

        public string BaseShape
        {
            get { return _baseShape; }
        }

        public string AdditionalCharacteristics
        {
            get { return _additionalCharacteristics ?? "No extra characteristic"; }
            set { _additionalCharacteristics = value; }
        }
        public KindOfCloud(string fullName, string details, string baseShape, List<ICloudType> matchedTypes,
            List<ICloudSubType> matchedSubTypes, List<IPhenomenon> matchedPhenomeons)
        {
            this._name = fullName;
            this._details = details;
            this._baseShape = baseShape;
            this._matchedCloudTypes = matchedTypes;
            this._matchedCloudSubTypes = matchedSubTypes;
            this._matchedPhenomenons = matchedPhenomeons;
        }
        public KindOfCloud(string fullName, string details, string baseShape, List<ICloudType> matchedTypes,
            List<ICloudSubType> matchedSubTypes, List<IPhenomenon> matchedPhenomeons, string extras)
        {
            this._name = fullName;
            this._details = details;
            this._baseShape = baseShape;
            this._matchedCloudTypes = matchedTypes;
            this._matchedCloudSubTypes = matchedSubTypes;
            this._matchedPhenomenons = matchedPhenomeons;
            this._additionalCharacteristics = extras;
        }

        public List<ICloudType> GetMathedCloudTypes()
        {
            return _matchedCloudTypes;
        }

        public List<ICloudSubType> GetMathedCloudSubTypes()
        {
            return _matchedCloudSubTypes;
        }

        public List<IPhenomenon> GetMathedPhenomeons()
        {
            return _matchedPhenomenons;
        }
        
    }
}