using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Repository.Implimentations
{
    public abstract class RepositoryBase
    {
        protected SqlConnection connection = null;
        protected SqlCommand command = null;

        public RepositoryBase()
        {
            connection = new
                SqlConnection("Data Source=LAPTOP-ANQRVFID;Initial Catalog=FoodManagement;Integrated Security=True");//your connection string
            command = new SqlCommand
            {
                Connection = connection
            };
        }
    }
}
