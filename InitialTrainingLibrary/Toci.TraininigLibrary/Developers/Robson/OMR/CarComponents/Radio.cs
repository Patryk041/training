using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Robson.OMR.Interfaces;

namespace Toci.TraininigLibrary.Developers.Robson.OMR.CarComponents
{
    public class Radio : IUpdateable, IDescriptionable
    {
        protected bool MP3Compatibility { get; private set; }
        protected bool CDCompatibility { get; private set; }
        protected int MaxVolume { get; private set; }
        protected float LowestFrequency { get; private set; }
        protected float HighestFrequency { get; private set; }
        protected string Description { get; private set; }
        protected string MadeBy { get; private set; }
        public bool IsOn { get; set; }

        protected float CurrentFrequency;
        protected int CurrentVolume;

        public Radio(bool hasMP3, bool hasCD, int maxVolume, float minFreq, float maxFreq, string manufacturer)
        {
            MP3Compatibility = hasMP3;
            CDCompatibility = hasCD;
            MaxVolume = maxVolume;
            LowestFrequency = minFreq;
            HighestFrequency = maxFreq;
            MadeBy = manufacturer;
        }
        public float GetFrequency()
        {
            return this.CurrentFrequency;
        }
        public int ChangeFrequency(float frequency)
        {
            if (frequency > HighestFrequency) return 1;
            if (frequency < LowestFrequency) return -1;
            CurrentFrequency = frequency;
            return 0;
        }
        public int GetVolume()
        {
            return this.CurrentVolume;
        }
        public void MusicLouder(int value)
        {
            if(CurrentVolume + value > MaxVolume)
            {
                return;
            }
            else
            {
                CurrentVolume += value;
            }
        }
        public void MusicTurnDown(int value)
        {
            if(CurrentVolume - value < 0)
            {
                return;
            }
            else
            {
                CurrentVolume -= value;
            }
        }
        public void SetDescription(string description)
        {
            Description = description;
        }

        public string GetSpecification()
        {
            string mp3 = MP3Compatibility ? "Has MP3 player,\n" : string.Empty;
            string cd = CDCompatibility ? "Has CD player,\n" : string.Empty;

            return string.Format("Radio specification:\n" + mp3 + cd + 
                "Maximum volume: {0},\nLowest accessible frequency: {1},\nHighest accessible frequency: {2},\nDescription: {3}", MaxVolume, LowestFrequency, 
                HighestFrequency, Description
                );
        }

        public string GetProducer()
        {
            return string.Format("Info about the manufacturer:\nThe radio was made by: {0}", MadeBy);
        }
    }
}
