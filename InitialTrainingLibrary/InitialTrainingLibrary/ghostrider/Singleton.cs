using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.ghostrider
{
    public class Singleton<T> where T : new()
    {
        private static T instance;

        protected Singleton()
        {
            
        }

        public static T GetInstance()
        {
            if (instance == null)
            {
                instance = new T();
            }

            return instance;
        }
    }
}
