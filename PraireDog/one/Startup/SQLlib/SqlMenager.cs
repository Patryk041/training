using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SQLlib.SQL
{
    class SqlMenager : ISqlMenager
    {
        private SqlConnection Connection;
        private SqlDriver Driver;

        SqlMenager()
        {
            Connection = new SqlConnection();
            Driver = new SqlDriver();
        }


    }
}
