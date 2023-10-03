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
using System.Windows.Shapes;

namespace FinalVicenteManuelAngeles
{
    public partial class addProduct : Window
    {
        private NorthwindTableAdapters.ProductsTableAdapter productsTableAdapter;
        private Northwind.ProductsDataTable tblProducts;

        private NorthwindTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private Northwind.CategoriesDataTable tblCategories;

        public addProduct()
        {
            InitializeComponent();
            productsTableAdapter = new NorthwindTableAdapters.ProductsTableAdapter();
            tblProducts = new Northwind.ProductsDataTable();

            categoriesTableAdapter = new NorthwindTableAdapters.CategoriesTableAdapter();
            tblCategories = new Northwind.CategoriesDataTable();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tblCategories = categoriesTableAdapter.GetCategory();

            categoryCombo.ItemsSource = tblCategories;
            categoryCombo.DisplayMemberPath = "CategoryName";
            categoryCombo.SelectedValuePath = "CategoryID";
        }
        private void btnAddProd_Click(object sender, RoutedEventArgs e)
        {
            if (categoryCombo.SelectedValue != null)
            {
                if (categoryCombo.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Choose a Category");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtProdName.Text))
                {
                    MessageBox.Show("Please Enter a Name");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    MessageBox.Show("Please Enter a Name");
                    return;
                }

                int categoryId = (int)(categoryCombo.SelectedValue);
                string prodName = txtProdName.Text;
                decimal price = decimal.Parse(txtPrice.Text);

                if (!decimal.TryParse((txtPrice.Text), out price))
                {
                    MessageBox.Show("Invalid Price input");
                    return;
                }

                productsTableAdapter.InsertQuery(prodName, categoryId, price);
                MessageBox.Show("Product is added");
            }
            else
            {
                MessageBox.Show("Please select a category before adding the product.");
            }
        }

        private void btbnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
