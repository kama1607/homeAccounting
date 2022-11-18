using System;
using home_accounting.Model;
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

namespace home_accounting.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page_addAccount.xaml
    /// </summary>
    public partial class Page_addAccount : Page
    {
        accounting account  = new accounting();
        public Page_addAccount(accounting selectedAccount)
        {
            InitializeComponent();
            if(selectedAccount != null)
            {
                account = selectedAccount;
            }
            select_type.SelectedValuePath = "id";
            select_type.DisplayMemberPath = "name";
            select_type.ItemsSource = homeaccountEntities.context().category_type.ToList();

            select_category.SelectedValuePath = "id";
            select_category.DisplayMemberPath = "name";

            DataContext = account;
        
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            if(datepick.SelectedDate == null)
            {
                MessageBox.Show("Выберите дату", "Внимание",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                
            } else if(select_type.SelectedValue == null)
            {
                MessageBox.Show("Выберите доход или расход", "Внимание",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if (select_category.SelectedValue == null)
            {
                MessageBox.Show("Выберите категорию", "Внимание",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if (summa.Text == "")
            {
                MessageBox.Show("Напишите сумму дохода или расхода", "Внимание",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                try
                {
                    var account = new accounting();
                    homeaccountEntities.context().accounting.Add(account);
                    account.date_add = Convert.ToDateTime(datepick.SelectedDate);
                    account.category_type = (category_type)select_type.SelectedItem;
                    account.Categories = (Categories)select_category.SelectedItem;
                    account.sum = summa.Text;
                    account.comment = comm.Text;
                    homeaccountEntities.context().SaveChanges();
                    MessageBox.Show("Данные успешно добавлены");
                    AppFrame.frame.GoBack();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
          AppFrame.frame.GoBack();
        }
            
        private void select_type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int category = Convert.ToInt32(select_type.SelectedValue);
            select_category.ItemsSource = homeaccountEntities.context().Categories.Where(x => x.type_id == category).ToList();
        }
    }
}
