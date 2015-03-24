using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.Eacrm;

namespace Toci.TraininigLibrary.Developers.Mg.Departures.Helpers
{
    public class MgValidationInvoke<T> where T : DepartureEntity
   {
       private MgDepartureList<T> _list;
       private DepartureEntity _entity;
     //  private Dictionary<int, List<int>> _clientsList;
     //  private int _clientId;

       private delegate void Invoke();

       private MgValidationInvoke<T>.Invoke InvokeAllDelegate;

       public MgValidationInvoke(MgDepartureList<T> list, DepartureEntity entity)
       {
           _list = list;
           _entity = entity;
          // _clientsList = clientsList;
          // _clientId = clientId;

           InvokeAllDelegate += CountWeeks;
           InvokeAllDelegate += CheckReturnDate;
           InvokeAllDelegate += CheckDepartureInterval;
           InvokeAllDelegate += CheckStatus;
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

       public void InvokeAll()
        {
            InvokeAllDelegate();
        }

       //private void SectionIdCheck()
       //{
       //    MgDepartureValidationHelpers<T>.SectionIdCheck(_clientsList,_clientId);
       //}

    }
}
