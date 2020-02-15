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
    public class FoodItemRepository : RepositoryBase, IFoodItemRepository
    {
        
        /// <summary>
        /// this is constructor
        /// </summary>
        public FoodItemRepository()
        {
            
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
                command.Parameters.Add(
                    new SqlParameter("@CategoryId", foodItem.category.Id));

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
                    command.Parameters.Clear();
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
                command.CommandText = "Sp_GetAllFoodItem";//create your sp and add here

                command.CommandType = CommandType.StoredProcedure;


                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    items.Add(new FoodItem
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Name = reader["FoodName"].ToString(),
                        category = new Category
                        {
                            Id = Convert.ToInt32(reader["Categoryid"]),
                            Name = reader["categoryname"].ToString()
                        }
                    });
                }

            }

            catch (Exception )
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
                    command.Parameters.Clear();
                    connection.Close();
                }
            }
        }



    }
}