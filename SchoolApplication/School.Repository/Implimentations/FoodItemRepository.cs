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
    public class FoodItemRepository : IFoodItemRepository
    {
        private SqlConnection connection = null;
        private SqlCommand command = null;
        /// <summary>
        /// this is constructor
        /// </summary>
        public FoodItemRepository()
        {
            connection = new
                SqlConnection("Data Source=LAPTOP-ANQRVFID;Initial Catalog=FoodManagement;Integrated Security=SSPI");//your connection string
            command = new SqlCommand
            {
                Connection = connection
            };
        }

        /// <summary>
        /// create the food item
        /// </summary>
        /// <param name="foodItem"></param>
        /// <returns></returns>
        public bool Create(FoodItem foodItem)
        {
            try
            {
                connection.Open();
                command.CommandText = "Sp_InsertFoodItem";//create your sp and add here

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@FoodName", foodItem.Name));

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
        /// delete the food item
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {

            try
            {
                connection.Open();
                command.CommandText = "Sp_DeleteFoodItem";//create your sp and add here

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@Foodid", id));

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
        /// get all the food items
        /// </summary>
        /// <returns></returns>
        public List<FoodItem> Get()
        {
            List<FoodItem> items = new List<FoodItem>();

            try
            {
                connection.Open();
                command.CommandText = "Sp_GetAllFoodItem ";//create your sp and add here

                command.CommandType = CommandType.StoredProcedure;


                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    items.Add(new FoodItem
                    {
                        Id = Convert.ToInt32(reader["FoodId"]),
                        Name = reader["FoodName"].ToString(),
                        category = new Category
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString()
                        }
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
        /// update the food item
        /// </summary>
        /// <param name="id"></param>
        /// <param name="foodItem"></param>
        /// <returns></returns>
        public bool Update(int id, FoodItem foodItem)
        {
            try
            {
                connection.Open();
                command.CommandText = "Sp_UpdateFoodItem ";//create your sp and add here

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(
                    new SqlParameter("@FoodId", id));
                command.Parameters.Add(
                    new SqlParameter("@FoodName", foodItem.Name));

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