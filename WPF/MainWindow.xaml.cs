using BusinessObjects;
using Reponsitories;
using System.Windows;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        public MainWindow()
        {
            InitializeComponent();
            _productRepository = new ProductRepository();
            _categoryRepository = new CategoryRepository();
            LoadCategoryList();
            loadProductList();
        }

        public void LoadCategoryList()
        {
            var listCategory = _categoryRepository.GetCategories();
            cboCategory.ItemsSource = listCategory;
            cboCategory.DisplayMemberPath = "CategoryName";
            cboCategory.SelectedValuePath = "CategoryId";
        }
        public void loadProductList()
        {
            var listProduct = _productRepository.GetAllProducts();
            dgData.ItemsSource = null;
            dgData.ItemsSource = listProduct;
        }


        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int prodcutId = _productRepository.getMaxId() + 1;
                string productName = txtProductName.Text;
                decimal price = decimal.Parse(txtPrice.Text);
                short unitsInStock = short.Parse(txtUnitsInStock.Text); int categoryId = 0;
                if (cboCategory.SelectedValue != null)
                {
                    categoryId = (int)cboCategory.SelectedValue;
                }
                Product p = new Product(prodcutId, productName, categoryId, unitsInStock, price);
                _productRepository.SaveProduct(p);
                loadProductList();
            }
            catch (Exception)
            {

                MessageBox.Show("Add khong duoc");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (txtProductID.Text.Length > 0)
            {
                int txtProductId = Convert.ToInt32(txtProductID.Text);
                String productName = txtProductName.Text;
                decimal price = decimal.Parse(txtPrice.Text);
                short uni = short.Parse(txtUnitsInStock.Text);
                int categoryId = Convert.ToInt32(cboCategory.SelectedValue);
                Product p = new Product(txtProductId, productName, categoryId, uni, price);
                _productRepository.UpdateProduct(p);
                loadProductList();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (txtProductID.Text.Length > 0)
            {
                Product p = _productRepository.GetProductById(Convert.ToInt32(txtProductID.Text));
                _productRepository.DeleteProduct(p);
                loadProductList();
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void dgData_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (dgData.SelectedItem is Product p)
            {
                txtProductID.Text = p.ProductId.ToString();
                txtProductName.Text = p.ProductName.ToString();
                txtUnitsInStock.Text = p.UnitsInStock.ToString();
                txtPrice.Text = p.UbitPrice.ToString();
                cboCategory.SelectedValue = p.CategoryId;
            }

        }
    }
}