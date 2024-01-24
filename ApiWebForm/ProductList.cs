using Infraestructure.DataSource;

namespace ApiWebForm
{
    public partial class ProductList : Form
    {
        private readonly ProductDataSource productDataSource = new ProductDataSource();
        public ProductList()
        {
            InitializeComponent();
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Obtener productos de manera asincrónica
                var data = await productDataSource.GetAllProducts();

                // Asignar los productos al DataGridView
                dataGridView1.DataSource = data;

                // Opcional: ajustar las columnas, etc.
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
