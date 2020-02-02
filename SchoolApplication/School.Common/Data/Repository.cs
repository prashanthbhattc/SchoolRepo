using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

namespace Infrastructure.Data
{
   public abstract class Repository:IDisposable
    {
       public Database DataBase
       {
           set;
           get;
       }
       public Repository()
       {
          
           //DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
           DataBase = DatabaseFactory.CreateDatabase();
       }

       public Repository(string databaseName)
       {

           //DatabaseFactory.SetDatabaseProviderFactory(new DatabaseProviderFactory());
           DataBase = DatabaseFactory.CreateDatabase(databaseName);
       }



       public void Dispose()
       {
           DataBase = null;
       }
    }


}
