using School.Entities;
using School.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Repository.Implimentations
{
    public class CategoryRepository : ICategoryRepository
    {

        private SqlConnection connection = null;
        private SqlCommand command = null;
        /// <summary>
        /// 
        /// </summary>
        public CategoryRepository()
        {
            connection = new
                SqlConnection("Data Source=DESKTOP-2B954VK;Initial Catalog=FoodManagement;Integrated Security=True");//your connection string
            command = new SqlCommand
            {
                Connection = connection
            };
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public bool Create(Category category)
        {
            try
            {
                connection.Open();
                command.CommandText = "Sp_InsertCategory";//create your sp and add here

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@CategoryName", category.Name));

                var rowsAffected = command.ExecuteNonQuery();
                connection.Close();
                var result = rowsAffected > 1 ? true : false;
                return result;
            }

            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            try
            {
                connection.Open();
                command.CommandText = "Sp_Name";//create your sp and add here

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@id", id));

                var rowsAffected = command.ExecuteNonQuery();
                connection.Close();
                var result = rowsAffected > 1 ? true : false;
                return result;
            }

            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IList<Category> Get()
        {
            List<Category> items = new List<Category>();

            try
            {
                connection.Open();
                command.CommandText = "Sp_Name";//create your sp and add here

                command.CommandType = CommandType.StoredProcedure;


                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    items.Add(new Category
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        
                    });
                }

            }

            catch (Exception)
            {
                return null;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
            return items;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="category"></param>
        /// <returns></returns>
        public bool Update(int id, Category category)
        {
            try
            {
                connection.Open();
                command.CommandText = "Sp_Name";//create your sp and add here

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@name", category.Name));

                var rowsAffected = command.ExecuteNonQuery();
                connection.Close();
                var result = rowsAffected > 1 ? true : false;
                return result;
            }

            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }


        
    }
}
