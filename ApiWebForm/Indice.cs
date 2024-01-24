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
    public partial class Indice : Form
    {
        public Indice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agregar AgregarForm = new Agregar();
            AgregarForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductList productListForm = new ProductList();
            productListForm.Show();
        }
    }
}
