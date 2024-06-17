using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        MainWindow.main.Content = new Registratio();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {



            if (Log.Text == "")
            {
                MessageBox.Show("Введите ваш логин");
            }
            else if (Pass.Password == "")
            {
                MessageBox.Show("Введите ваш пароль");
            }
            else if (Roless.Text == "")
            {
                MessageBox.Show("Введите ваш ID");
            }



            string LoginUser = Log.Text;
            string PasswordUser = Pass.Password;
           /// int Roles = Convert.ToInt32(Roless.Text);
            

                var Userin = AppConnect.modelOdb.User.FirstOrDefault(x => x.Login == LoginUser && x.Password == PasswordUser);

                    if (Userin == null)
                    {
                        MessageBox.Show("Вы ввели что-то неправильно", "Erro", MessageBoxButton.OK);
                    } 
                    else
                    {
                        MessageBox.Show("Вы ввели ВСЁ правильно", "Entrance", MessageBoxButton.OK);

                        MainWindow.main.Content = new MainPage1();
                        

                       
                    }
                
               


            

           
            
        }
    }
}
