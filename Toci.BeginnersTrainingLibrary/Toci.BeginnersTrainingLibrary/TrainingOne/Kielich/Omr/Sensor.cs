namespace Toci.BeginnersTrainingLibrary.TrainingOne.Kielich.Omr
{
    public class Sensor : Device
    {
        public bool IsScanning(bool scan)
        {
            return scan;
        }

        public bool IsRecording(bool record)
        {
            return record;
        }

        public override bool SetConnection(bool connection)
        {
            return Connection = connection;
        }
    }
}
