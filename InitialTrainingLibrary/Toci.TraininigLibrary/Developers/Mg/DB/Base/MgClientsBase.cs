using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Mg.DB.Interface;

namespace Toci.TraininigLibrary.Developers.Mg.DB.Base
{
   public abstract class MgClientsBase : IMgDbClient

    {
       protected string UserName { get; private set; }
       protected string Password { get; private set; }
       protected string DbName { get; private set; }
       protected string DbAddress { get; private set; }

      protected MgClientsBase(string userName,string password, string dbName, string dbAddress) 
       {
           this.UserName = userName;
           this.Password = password;
           this.DbName = dbName;
           this.DbAddress = dbAddress;
       }

       public abstract DataSet GetData(string query);


       public abstract int SetData(string query);

    }
}
