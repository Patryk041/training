using System;
using System.Collections.Generic;
using Microsoft.SqlServer.Server;
using Toci.Hornets.GhostRider.GhostRider;
using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.GhostRider.TrainingFour.ExtensionMethods
{
    public static class PerformTransfersExtensions
    {

        public static PerformTransfers SendCustomTransfer(this PerformTransfers objPerformTransfers, string whatever)
        {
            //objPerformTransfers;

            objPerformTransfers.Test++;

            return objPerformTransfers;
        }

        public static void RunMeAsDelegate(this MyExampleOfHomework obj, string parameter, PerformTransfers fdw)
        { // 3
            
        }

        public static IEnumerable<string> ShowHowLinqWorks(this string[] text, string item2, Func<string, string, string> testDelegate)
        {
            foreach (var item in text)
            {
                yield return testDelegate(item, item2);
//                if (testDelegate(item, item2))
//                {
//                    yield return item;
//                }
            }

            //return null;
        }

        public static bool IsPalindrom( string text)
        {
            return true;
        }

        public static T GenericExtMethod<T>(this T obj) where T : PerformTransfers, ITelephoneCommunication
        {
            //obj.TransferAll();
            //obj.TransferAll();
            return default(T);//null;
        }
    }
}