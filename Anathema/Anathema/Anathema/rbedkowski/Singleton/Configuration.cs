using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.rbedkowski.Singleton
{
    class Configuration
    {
        
        public string Lang { get; set; }
        public string Color { get; set; }
        
        private Configuration()
        {
           
        }

        private static class SingletonInstance
        {
            public  static Configuration Instance = new Configuration();
        }

        public static Configuration GetInstance()
        {
            return SingletonInstance.Instance;
        }
        
    }
}
