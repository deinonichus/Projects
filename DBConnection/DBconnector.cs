using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace DBConnection {
    class DBconnector {
        string databaseName = "";
        string databaseUser = "";
        string databasePassword = "";

        public DBconnector (string tDatabaseName, string tDatabaseUser, string tDatabasePassword) {
            databaseName = tDatabaseName;
            databaseUser = tDatabaseUser;
            databasePassword = tDatabasePassword;

        }

    }
}
