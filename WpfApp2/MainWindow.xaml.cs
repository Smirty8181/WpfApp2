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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        AppContext db;
       
        public MainWindow()
        {
            InitializeComponent();

            db = new AppContext();

            DoubleAnimation da = new DoubleAnimation();
            da.From = 0;
            da.To = 300;
            da.Duration = TimeSpan.FromSeconds(1.5);
            RegButton.BeginAnimation(Button.WidthProperty, da);
            


        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = TBlogin.Text.Trim();
            string pass = PassBox.Password.Trim();
            string pass2 = PassBox2.Password.Trim();
            string email = TBEmail.Text.Trim().ToLower();

            if (login.Length < 5 || login.Length > 14 )
            {
                TBlogin.ToolTip = "Размер Логина от 5 до 14 символов.";
                TBlogin.Background = Brushes.Red;
            }
            else  if(pass.Length <  5 || pass.Length > 14)
            {
                PassBox.ToolTip = "Размер Пароля от 5 до 14 символов.";
                PassBox.Background = Brushes.Red;
            }
            else if (pass != pass2)
            {
                PassBox2.ToolTip = "Пароли не совпадают.";
                PassBox2.Background = Brushes.Red;
            }

            else if (!email.Contains("@") || !email.Contains("."))
            {
                TBEmail.ToolTip = "Введите электронную почту";
                TBEmail.Background = Brushes.Red;
            }
            else
            {
                TBlogin.ToolTip = "";
                TBlogin.Background = Brushes.Transparent;
                PassBox.ToolTip = "";
                PassBox.Background = Brushes.Transparent;
                PassBox2.ToolTip = "";
                PassBox2.Background = Brushes.Transparent;
                TBEmail.ToolTip = "";
                TBEmail.Background = Brushes.Transparent;

                User user = new User(login, pass, email);

                db.Users.Add(user);
                db.SaveChanges();

                authorization auth = new authorization();
                auth.Show();
                this.Close();
            }
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            authorization auth = new authorization();
            auth.Show();
            this.Close();
        }



    }
}
