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
    /// Логика взаимодействия для Page_addCategory.xaml
    /// </summary>
    public partial class Page_addCategory : Page
    {
        Categories category = new Categories();
        public Page_addCategory(Categories selectedCategory)
        {
            InitializeComponent();
            if(selectedCategory != null)
            {
                category = selectedCategory;
            }

            select_category_type.ItemsSource = homeaccountEntities.context().category_type.ToList();
            DataContext = category;

        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frame.GoBack();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            if(select_category_type.SelectedItem == null)
            {
                MessageBox.Show("Выберити доход или расход", "Внимание",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            } else if(name.Text == "")
            {
                MessageBox.Show("Напишите название категории", "Внимание",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            } else
            {
                try
                {
                    var category = new Categories();
                    homeaccountEntities.context().Categories.Add(category);
                    category.category_type = (category_type)select_category_type.SelectedItem;
                    category.name = name.Text;
                    homeaccountEntities.context().SaveChanges();
                    MessageBox.Show("Категория добавлена");
                    AppFrame.frame.GoBack();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
        }
    }
}
