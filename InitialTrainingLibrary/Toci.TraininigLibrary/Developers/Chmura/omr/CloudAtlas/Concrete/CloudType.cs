using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Interface;

namespace Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Concrete
{
    public class CloudType : ICloudType
    {
        private string _name;
        private string _shape;
        private string _details;

        public string Name
        {
            get { return _name; }
        }

        public string Shape
        {
            get { return _shape; }
        }

        public string GetCharacteristic()
        {
            return string.Format("Cloud is {0} with shape of {1}", _details, _shape);
        }

        public CloudType(string name, string shape, string details)
        {
            this._name = name;
            this._shape = shape;
            this._details = details;
        }
    }
}