using Infraestructure.DataSource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiWebForm
{
    public partial class Agregar : Form
    {
        private readonly ProductDataSource productDataSource = new ProductDataSource();

        public Agregar()
        {
            InitializeComponent();
        }

        public async void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Register registro = await productDataSource.RegisterProduct(title.Text);
                MessageBox.Show($"Se agrego el registro con id {registro.id} y nombre {registro.title}", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Algo salio mal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
