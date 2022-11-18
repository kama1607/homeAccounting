using System;
using home_accounting.Model;
using home_accounting.View;
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
    /// Логика взаимодействия для Page_accounting.xaml
    /// </summary>
    public partial class Page_accounting : Page
    {
        public Page_accounting()
        {
            InitializeComponent();
            datagrid.ItemsSource = homeaccountEntities.context().accounting.ToList();
            types_categories.SelectedValuePath = "id";
            types_categories.DisplayMemberPath = "name";
            types_categories.ItemsSource = homeaccountEntities.context().category_type.ToList();
        }

        private void add_account_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frame.Navigate(new Pages.Page_addAccount(null));
        }

        private void delete_account_Click(object sender, RoutedEventArgs e)
        {
            var removeItems = datagrid.SelectedItems.Cast<home_accounting.Model.accounting>().ToList();

            if(MessageBox.Show($"Вы действительно хотите удалить эти {removeItems.Count()} данные?",
                    "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                try
                {
                    homeaccountEntities.context().accounting.RemoveRange(removeItems);
                    homeaccountEntities.context().SaveChanges();
                    MessageBox.Show("Данные удалены !");

                    datagrid.ItemsSource = homeaccountEntities.context().accounting.ToList();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

        }

        private void search_category_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchCategory = search_category.Text;
            List<home_accounting.Model.accounting> accountings = homeaccountEntities.context().accounting.ToList();
            accountings =accountings.Where(a => a.Categories.name.ToLower().Contains(searchCategory.ToLower())).ToList();
            datagrid.ItemsSource = accountings.ToList(); 
        }

        private void edit_account_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frame.Navigate(new Pages.Page_addAccount((sender as Button).DataContext as home_accounting.Model.accounting));
            var editedItem = datagrid.SelectedItems.Cast<home_accounting.Model.accounting>().ToList();
            homeaccountEntities.context().accounting.RemoveRange(editedItem);
            homeaccountEntities.context().SaveChanges();
        }

        private void types_categories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int category = Convert.ToInt32(types_categories.SelectedValue);
            datagrid.ItemsSource = homeaccountEntities.context().accounting.Where(x => x.category_type_id == category).ToList();
        }
    }
}
