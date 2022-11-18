using System;
using home_accounting.View.Pages;
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

namespace home_accounting
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
            AppFrame.frame = frm;
        }

        private void open_account_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frame.Navigate(new View.Pages.Page_accounting());
        }

        private void category_open_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frame.Navigate(new View.Pages.Page_category());
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
