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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Warehouse.xaml
    /// </summary>
    public partial class Warehouse : Window
    {
        public Warehouse()
        {
            InitializeComponent();
        }
        private void Button_return_Click(object sender, RoutedEventArgs e)
        {
            LK lk = new LK();
            lk.Show();
            this.Close();
        }
    }
}
