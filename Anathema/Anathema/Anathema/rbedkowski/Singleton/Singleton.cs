using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.rbedkowski.Singleton
{
    public class Singleton
    {
        private static Singleton _Instance = null;

        public string Lang;
        public string Color;

        private Singleton() { }
        static Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new Singleton();
                return _Instance;
            }
        }
           

    }
}
