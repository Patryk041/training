using System;
using System.Collections.Generic;
using System.IO;

namespace Toci.Hornets.GhostRider.TrainingSeven.Using
{
    public class DisposableManager : IDisposable
    {
        public void test()
        {
            //IDisposable 

            //using (var lista = new List<int>())
            using (var strr = new StreamReader("C:/dsfafgdgdss/"))
            {
                strr.ReadToEnd();

                //GC.Collect();
                //strr.c
            }

           // strr
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            GC.SuppressFinalize(this);
            GC.SuppressFinalize(this);
            GC.SuppressFinalize(this);
            GC.SuppressFinalize(this);
            GC.SuppressFinalize(this);
            GC.SuppressFinalize(this);
            GC.SuppressFinalize(this);
            GC.SuppressFinalize(this);
            GC.SuppressFinalize(this);
            GC.SuppressFinalize(this);
            GC.SuppressFinalize(this);
            GC.SuppressFinalize(this);
            GC.SuppressFinalize(this);
            GC.SuppressFinalize(this);
            GC.SuppressFinalize(this);
            GC.SuppressFinalize(this);
            GC.SuppressFinalize(this);
            GC.SuppressFinalize(this);
            GC.SuppressFinalize(this);
            GC.SuppressFinalize(this);
            GC.SuppressFinalize(this);
            GC.SuppressFinalize(this);
            //throw new NotImplementedException();
        }
    }
}