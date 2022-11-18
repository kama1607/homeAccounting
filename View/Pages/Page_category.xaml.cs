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
    /// Логика взаимодействия для Page_category.xaml
    /// </summary>
    public partial class Page_category : Page
    {
        public Page_category()
        {
            InitializeComponent();
            datagrid.ItemsSource = homeaccountEntities.context().Categories.ToList();
            types_categories.SelectedValuePath = "id";
            types_categories.DisplayMemberPath = "name";
            types_categories.ItemsSource = homeaccountEntities.context().category_type.ToList();

        }

        private void edit_category_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frame.Navigate(new Pages.Page_addCategory((sender as Button).DataContext as home_accounting.Model.Categories));
            var editedCategory = datagrid.SelectedItems.Cast<home_accounting.Model.Categories>().ToList();
            homeaccountEntities.context().Categories.RemoveRange(editedCategory);
            homeaccountEntities.context().SaveChanges();



        }

        private void add_category_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frame.Navigate(new Pages.Page_addCategory(null));
        }

        private void search_category_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchCategory = search_category.Text;
            List<home_accounting.Model.Categories> categories = homeaccountEntities.context().Categories.ToList();
            categories = categories.Where(a => a.name.ToLower().Contains(searchCategory.ToLower())).ToList();
            datagrid.ItemsSource = categories.ToList();
        }

        private void types_categories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int category = Convert.ToInt32(types_categories.SelectedValue);
            datagrid.ItemsSource = homeaccountEntities.context().Categories.Where(x => x.type_id == category).ToList();
        }
    }
}
