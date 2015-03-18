using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Mg.Departures.Helpers
{
   public class MgValidationInvoke<T> where T:MgDepartureEntity
   {
       private MgDepartureList<T> _list;
       private MgDepartureEntity _entity;
     //  private Dictionary<int, List<int>> _clientsList;
     //  private int _clientId;

       public delegate void Invoke();

       public Invoke InvokeAll;

       public MgValidationInvoke(MgDepartureList<T> list, MgDepartureEntity entity)
       {
           _list = list;
           _entity = entity;
          // _clientsList = clientsList;
          // _clientId = clientId;

           InvokeAll += CountWeeks;
           InvokeAll += CheckReturnDate;
           InvokeAll += CheckDepartureInterval;
           InvokeAll += CheckStatus;
          // InvokeAll += SectionIdCheck;
       }

       private void CountWeeks()
       {
           MgDepartureValidationHelpers<T>.CountWeeks(_entity);
       }

       private void CheckReturnDate()
       {
           MgDepartureValidationHelpers<T>.CheckReturnDate(_entity);
       }

       private void CheckDepartureInterval()
       {
           MgDepartureValidationHelpers<T>.CheckDepartureInterval(_list,_entity);
       }

       private void CheckStatus()
       {
           MgDepartureValidationHelpers<T>.CheckStatus(_list,_entity);
           
       }


       //private void SectionIdCheck()
       //{
       //    MgDepartureValidationHelpers<T>.SectionIdCheck(_clientsList,_clientId);
       //}

    }
}
