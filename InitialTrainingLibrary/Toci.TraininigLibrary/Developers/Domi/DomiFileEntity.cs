using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;
using Toci.TraininigLibrary.Common.Interfaces.FileParser;

namespace Toci.TraininigLibrary.Developers.Domi
{
   public class DomiFileEntity : FileEntityBase
    {


       public override string ToString()    // po co nam dwie te same metody, które zwracają dokładnie to samo? 
       {
           return string.Format("{0} {1} {2} {3}", Name, Surname, Date, Account);
       }

       public override string GetLine()
       {

           return string.Format("{0},{1},{2},{3}", Name, Surname, Date, Account); 
       }

       public string GetName(string name)
       {
           Name = name; 
           return Name;
       }

       public string GetSurname(string surname)
       {
           Surname = surname;
           return Surname;
       }

       public DateTime GetDate(string dateTime)
       {
           Date = Convert.ToDateTime(dateTime);  
           return Date;
       }

       public string GetAccount(string account)
       {
           Account = account; 
           return Account;
       }
   }
}
