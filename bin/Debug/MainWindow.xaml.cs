using System;
using home_accounting;
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

namespace home_accounting
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, RoutedEventArgs e)
        {
            string login = txt_login.Text.Trim();
            string password = psb_pass.Password.Trim();

            if(txt_login.Text == "")
            {
                    MessageBox.Show("Заполните поле логина",
                    "Внимание", MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            } 
            else if(psb_pass.Password == "")
            {
                    MessageBox.Show("Заполните поле пароля",
                    "Внимание", MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
            else if(txt_login.Text != "admin")
            {
                    MessageBox.Show("Неверный логин",
                    "Внимание", MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
            
            else if(psb_pass.Password != "admin")
            {
                    MessageBox.Show("Неверный пароль",
                    "Внимание", MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }

            else
            {
                this.Hide();
                Menu menu = new Menu();
                menu.Show();
                this.Close();
            }

        }
    }
}
