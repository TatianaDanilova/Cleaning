using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void EditThing_shoes(object sender, RoutedEventArgs e)
        {
            Window5 window4 = new Window5();
            window4.Show();
            this.Close();
        }
        private void EditThing_clothes(object sender, RoutedEventArgs e)
        {
            Window5 window4 = new Window5();
            window4.Show();
            this.Close();
        }

    }
}
