using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SQLlib.SQL
{
    public class SqlMenager : ISqlMenager
    {
        private SqlConnection Connection;
        private SqlDriver Driver;

        public SqlMenager()
        {
            
            Driver = new SqlDriver(Connection);
            Driver.CreateTable("banki_tabela");
            Driver.Insert(new string[] { "a"},"banki_tabela");
            Driver.SelectTable("banki_tabela");
        }


    }
}
