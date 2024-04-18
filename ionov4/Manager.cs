using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ionov4
{
    internal class Manager
    {
        public void AddThing(string type, string name, string material, int price, string color)
        {
            string connectionString = "Data Source=DESKTOP-4HJV1J2;Initial Catalog=Cleaning;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("AddThing", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@thing_type", System.Data.SqlDbType.NVarChar, 100).Value = type;
                    cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar, 100).Value = name;
                    cmd.Parameters.Add("@material", System.Data.SqlDbType.NVarChar, 100).Value = material;
                    cmd.Parameters.Add("@price", System.Data.SqlDbType.Int).Value = price;
                    cmd.Parameters.Add("@color", System.Data.SqlDbType.NVarChar, 100).Value = color;
                    cmd.Parameters.Add(new SqlParameter("@user_id", System.Data.SqlDbType.Int)).Value = AppSettings.UserId;

                    cmd.ExecuteNonQuery();
                }
                try
                {
                    MessageBox.Show($"{type} успешно добавлена");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");

                }

            }
        }
        
        public void DeleteThing(string name)
        {
            string connectionString = "Data Source=DESKTOP-4HJV1J2;Initial Catalog=Cleaning;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("DeleteThing", connection))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar, 100).Value = name;

                    cmd.ExecuteNonQuery();
                }
                try
                {
                    MessageBox.Show($"{name} успешно удалено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");

                }

            }
        }
    }
}
