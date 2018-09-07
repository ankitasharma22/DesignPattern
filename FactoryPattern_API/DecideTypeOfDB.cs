using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_API
{
    class DecideTypeOfDB
    {
        public void AccessUserChoiceOfDB(int dbType)
        {
            LogManager.Instance.WriteLog("---Deciding type of db---");
            IDatabase database;
            Constants constants = new Constants();

            if (dbType == 1)
                database = new FileDatabase();
            else if (dbType == 2)
                database = new DatabaseAccess();
            else 
                constants.Error(); 
        }
    }
}
