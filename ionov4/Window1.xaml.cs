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
using System.Windows.Shapes;

namespace ionov4
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }


        //кнопка добавить одежду
        private void edith_clothing(object sender, RoutedEventArgs e)
        {
            string types = "Одежда";
            Manager manager = new Manager();
            manager.AddThing(types, NameTextBox.Text, MaterialTextBox.Text, Convert.ToInt32(PriceTextBox.Text), ColorTextBox.Text);
            Window5 window1 = new Window5();
            window1.Show();
            this.Close();
        }

        //кнопка добавить обувь
        private void edith_footwear(object sender, RoutedEventArgs e)
        {
            string types = "Обувь";
            Manager manager = new Manager();
            manager.AddThing(types, NameWTextBox.Text, MaterialWTextBox.Text, Convert.ToInt32(PriceWTextBox.Text), ColorWTextBox.Text);
            Window5 window1 = new Window5();
            window1.Show();
            this.Close();
        }
    }
}
