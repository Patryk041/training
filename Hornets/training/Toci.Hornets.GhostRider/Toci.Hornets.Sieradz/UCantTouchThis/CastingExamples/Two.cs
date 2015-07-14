namespace Toci.Hornets.Sieradz.UCantTouchThis.CastingExamples
{
    public class Two : One
    {
        public Two()
        {
            Three = 12.12;
            Four = 'G';
        }

        public double Three { get; set; }
        public char Four { get; set; }
         
    }
}