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

namespace ChatSP
{
    /// <summary>
    /// Логика взаимодействия для Registratio.xaml
    /// </summary>
    public partial class Registratio : Page
    {
        public Registratio()
        {
            InitializeComponent();
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {

            if (Log.Text == "")
            {
                MessageBox.Show("Укажите ваш будущий логин");
            }

            else if (Pass.Password == "")
            {
                MessageBox.Show("Укажите ваш пароль");
            }

            else
            {
                using (ChatEntities db = new ChatEntities())
                {
                    User users= new User();
                    
                    users.Login = Log.Text;
                    users.Password = Pass.Password;


                    db.User.Add(users);
                    db.SaveChanges();
                }
            }



          /*  User user = new User();
            user.Lgin = Tname.Text;
            user.Password = Passwords.Password;*/
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.main.Content = new Login();
        }

        private void Tname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
