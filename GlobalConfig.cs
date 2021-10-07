using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Interface;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; } 

        public static void InitializeConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                // TODO - Create the SQL connection.
                SQLConnector sql = new SQLConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.Textfile)
            {
                // TODO - Createthe text connection.
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }


    }
}
