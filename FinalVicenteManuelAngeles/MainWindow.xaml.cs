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

namespace FinalVicenteManuelAngeles
{

    public partial class MainWindow : Window
    {
        private NorthwindTableAdapters.ProductsTableAdapter productsTableAdapter;
        private Northwind.ProductsDataTable tblProducts;

        private NorthwindTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private Northwind.CategoriesDataTable tblCategories;

        public MainWindow()
        {
            InitializeComponent();
            productsTableAdapter = new NorthwindTableAdapters.ProductsTableAdapter();
            tblProducts = new Northwind.ProductsDataTable();

            categoriesTableAdapter = new NorthwindTableAdapters.CategoriesTableAdapter();
            tblCategories = new Northwind.CategoriesDataTable();

        }

        private void GetAllProducts()
        {
            productsTableAdapter.FillProducts(tblProducts);
            grdProducts.ItemsSource = tblProducts;

            tblCategories = categoriesTableAdapter.GetCategory();

            productCombo.ItemsSource = tblCategories;
            productCombo.DisplayMemberPath = "CategoryName";
            productCombo.SelectedValuePath = "CategoryID";
        }

        private void btnGetAllProducts_Click(object sender, RoutedEventArgs e)
        {
            GetAllProducts();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtsearchProd.Clear();
            productCombo.SelectedIndex = -1;
            tblProducts.Clear();
        }


        private void productCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (productCombo.SelectedIndex != null)
            {
                int categoryId = (int)(productCombo.SelectedValue);

                grdProducts.ItemsSource = productsTableAdapter.GetCategoryById(categoryId);

            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            tblProducts = productsTableAdapter.GetByPartialName(txtsearchProd.Text);
            grdProducts.ItemsSource = tblProducts;
        }

        private void btnAddProd_Click(object sender, RoutedEventArgs e)
        {
            addProduct addProduct = new addProduct();
            addProduct.ShowDialog();
        }
    }
}
