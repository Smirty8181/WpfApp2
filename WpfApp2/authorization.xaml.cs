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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для authorization.xaml
    /// </summary>
    public partial class authorization : Window
    {
        public authorization()
        {
            InitializeComponent();

            DoubleAnimation da = new DoubleAnimation();
            da.From = 0;
            da.To = 300;
            da.Duration = TimeSpan.FromSeconds(1.5);
            enter.BeginAnimation(Button.WidthProperty, da);
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            string login = TBlogin.Text.Trim();
            string pass = PassBox.Password.Trim();

            if (login.Length < 5 || login.Length > 14)
            {
                TBlogin.ToolTip = "Размер Логина от 5 до 14 символов.";
                TBlogin.Background = Brushes.Red;
            }
            else if (pass.Length < 5 || pass.Length > 14)
            {
                PassBox.ToolTip = "Размер Пароля от 5 до 14 символов.";
                PassBox.Background = Brushes.Red;
            }
            else
            {
                TBlogin.ToolTip = "";
                TBlogin.Background = Brushes.Transparent;
                PassBox.ToolTip = "";
                PassBox.Background = Brushes.Transparent;

                User authUser = null;
                using (AppContext db = new AppContext())
                {
                    authUser = db.Users.Where(b => b.login == login && b.password == pass).FirstOrDefault();
                }
                if (authUser != null)
                {

                    LK lK = new LK();
                    lK.Show(); 
                    this.Close();
                }
                else
                    MessageBox.Show("Логин или пароль введены неправильно");


            }
        }
        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            MainWindow reg = new MainWindow();
            reg.Show();
            this.Close();

        }
    }
}
