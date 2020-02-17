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
    public class CategoryRepository : RepositoryBase,ICategoryRepository
    {

        
        /// <summary>
        /// 
        /// </summary>
        public CategoryRepository()
        {
            
        }
        /// <summary>
        /// this is used to create category
        /// </summary>
        /// <param name="category">this is catgory</param>
        /// <returns>if saved true else fasle</returns>
        public bool Create(Category category)
        {
            try
            {
                
                command.CommandText = "Sp_InsertCategory";//create your sp and add here

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@CategoryName", category.Name));

                command.Parameters.Add(
                    new SqlParameter("@Discount", category.Discount));
                connection.Open();
                var rowsAffected = command.ExecuteNonQuery();
                connection.Close();
                var result = rowsAffected > 1 ? true : false;
                return result;
            }

            catch (Exception )
            {
                return false;
            }
            finally
            {
                if (connection != null)
                {
                    command.Parameters.Clear();
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
                command.CommandText = "Sp_DeleteCategory";//create your sp and add here

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@id", id));

                var rowsAffected = command.ExecuteNonQuery();
                connection.Close();
                var result = rowsAffected > 1 ? true : false;
                return result;
            }

            catch (Exception )
            {
                return false;
            }
            finally
            {
                if (connection != null)
                {
                    command.Parameters.Clear();
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
                command.CommandText = "Sp_GetAllCategory";//create your sp and add here

                command.CommandType = CommandType.StoredProcedure;


                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                   
                    items.Add(new Category
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["Name"].ToString(),
                        Discount=Convert.ToInt32(reader["Discount"])
                        
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
                    command.Parameters.Clear();
                    connection.Close();
                }
            }
            return items;
        }

        public IList<Category> Get(CategoryFilter filter)
        {
            List<Category> items = new List<Category>();

            try
            {
                connection.Open();
                command.CommandText = "Sp_GetAllCategoryFilter";//create your sp and add here

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@CategoryName", filter.Name));

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
                    command.Parameters.Clear();
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
                command.CommandText = "Sp_UpdateCategory";//create your sp and add here

                command.CommandType = CommandType.StoredProcedure;
                 command.Parameters.Add(
                    new SqlParameter("@Id", id));
                command.Parameters.Add(
                    new SqlParameter("@name", category.Name));
                command.Parameters.Add(
                   new SqlParameter("@Discount", category.Discount));
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
                    command.Parameters.Clear();
                    connection.Close();
                }
            }
        }


        
    }
}