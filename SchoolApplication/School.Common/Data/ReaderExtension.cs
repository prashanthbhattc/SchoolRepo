using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
   public static class ReaderExtension
    {

       public static T GetValue<T>(this IDataReader reader,object obj)
       {
            if (typeof(DBNull) != obj.GetType())
            {
               return (T) Convert.ChangeType(obj, typeof(T));
                
            }
            return default(T);
       }

       
       
    }
}
