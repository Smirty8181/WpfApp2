using System;
using System.Collections;
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
    /// Логика взаимодействия для LK.xaml
    /// </summary>
    public partial class LK : Window
    {
        AppContext db;
        public LK()
        {
            InitializeComponent();
            db = new AppContext();
        }
        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void Button_Delivery_Click(object sender, RoutedEventArgs e)
        {
            Delivery del = new Delivery();
            del.Show();
            this.Close();
        }

        private void Button_Warehouse_Click(object sender, RoutedEventArgs e)
        {
            Warehouse ware = new Warehouse();
            ware.Show();
            this.Close();
        }

        private void Button_Staff_Click(object sender, RoutedEventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
            this.Close();
        }

    }
}
