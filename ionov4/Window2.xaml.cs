using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace ionov4
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            LoadOrderDetails();
        }

        string connectionString = "Data Source=DESKTOP-4HJV1J2;Initial Catalog=Cleaning;Integrated Security=True";

        private void LoadOrderDetails()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sqlQuery = "SELECT thing_type AS 'Тип', [name] AS 'Название', material AS 'Материал', price AS 'Цена', color AS 'Цвет'\r\nFROM Things\r\n";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Создайте объект для чтения данных
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Создайте DataTable для хранения результатов запроса
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);

                        // Привяжите DataTable к DataGrid
                        ThingsDataGrid.ItemsSource = dataTable.DefaultView;
                    }
                }
            }
        }

        private void itemListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void back(object sender, RoutedEventArgs e)
        {
            Window5 window2 = new Window5();
            window2.Show();
            this.Close();
        }

        private void GridViewColumnHeader_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
