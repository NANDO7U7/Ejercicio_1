using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using laboratorio_6.Properties;
using System.Configuration;
using System.Data.SqlClient;

namespace laboratorio_6.DALL
{
   public class database
    {
        public static string getStrConnection ()
        {
            return Settings.Default.empleadosConnectionString;
        }

        public SqlConnection getConnection()
        {
            SqlConnection Con = new SqlConnection(getStrConnection());
            return Con;

        }

    }
}
