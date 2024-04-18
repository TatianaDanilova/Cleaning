using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ionov4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=DESKTOP-4HJV1J2;Initial Catalog=Cleaning;Integrated Security=True";

        public int CheckName()
        {
            int idUser = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("CheckName", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@name", System.Data.SqlDbType.NVarChar, 100).Value = FI.Text;
                command.Parameters.Add("@pass", System.Data.SqlDbType.NVarChar, 100).Value = Parol.Text;
                command.Parameters.Add("@user_id", SqlDbType.Int).Direction = ParameterDirection.Output;

                connection.Open();
                command.ExecuteNonQuery();

                object idUserObj = command.Parameters["@user_id"].Value;
                if (idUserObj != DBNull.Value)
                {
                    idUser = Convert.ToInt32(idUserObj);
                }
            }
            return idUser;
        }
        private void GO(object sender, RoutedEventArgs e)
        {

            int userId = CheckName();
            if (userId != 0)
            {
                

                Window5 g = new Window5(); 
                g.Show();
                this.Close();
                AppSettings.UserId = userId;
            } 
            else
            {
                MessageBox.Show("Введите верные данные.");
            }
        }
    }
}
