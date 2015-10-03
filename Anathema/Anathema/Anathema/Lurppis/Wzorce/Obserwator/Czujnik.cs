using System.Collections.Generic;
using Anathema.Lurppis.Wzorce.Obserwator.Interface;

namespace Anathema.Lurppis.Wzorce.Obserwator
{
    public class Czujnik : IObserwatorzy
    {
        private List<IObserwator> _listaObserwatorow = new List<IObserwator>(); 

        public int JakasWlasciwosc { get; set; }

        private int _temperatura;

        public void DodajObserwator(IObserwator o)
        {
            _listaObserwatorow.Add(o);
        }

        public void UsunObserwator(IObserwator o)
        {
            _listaObserwatorow.Remove(o);
        }

        public void PowiadomObserwator()
        {
            foreach (var item in _listaObserwatorow)
            {
                item.AktualizacjaDanych();
            }
        }

        public int PobierzTemperature()
        {
            return _temperatura + 15; 
        }

        public void DodajPomiar(int wartosc)
        {
            _temperatura = wartosc;
        }
    }
}