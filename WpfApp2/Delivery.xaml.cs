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
    /// Логика взаимодействия для Delivery.xaml
    /// </summary>
    public partial class Delivery : Window
    {
        public Delivery()
        {
            InitializeComponent();

        }

        private void Button_Order_click(object sender, RoutedEventArgs e)
        {
            string drag = Drag.Text.Trim();
            string date = Date.Text.Trim();

            if (drag.Length < 1)
            {
                Drag.ToolTip = "Введите наимонования лекарства ";
                Drag.Background = Brushes.Red;
            }
            else if (!Date.SelectedDate.HasValue)
            {
                MessageBox.Show("Выберите дату");       
            }
            else
            {
                Drag.ToolTip = "";
                Drag.Background = Brushes.Transparent;
                Date.ToolTip = "";
                Date.Background = Brushes.Transparent;

                Order order = new Order();
                order.Show();
                this.Close();
            }
        }
               

           
    

        private void Button_return_click(object sender, RoutedEventArgs e)
        {
            LK lk = new LK();
            lk.Show();
            this.Close();
        }
    }
}
