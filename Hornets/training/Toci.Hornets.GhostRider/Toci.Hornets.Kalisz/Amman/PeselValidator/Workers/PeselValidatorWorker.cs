namespace Toci.Hornets.Kalisz.Amman.PeselValidator.Workers
{
    public class PeselValidatorWorker
    {
        static public bool IsValid(string psl)
        {
            return ChksumValidator.Check(psl);
        }
    }
}