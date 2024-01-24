using Domain.Entity;
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
    public partial class Login : Form
    {
        private readonly AuthDataSource authDataSource = new AuthDataSource();

        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User? user = await authDataSource?.RealizarLogin(Inputuser.Text, Inputpassword.Text);

                if (user == null) { 
                    MessageBox.Show("Inicio de sesión fallido. Verifica tus credenciales.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Inicio de sesión exitoso, redirigir a Indice
                Indice indiceForm = new Indice();
                indiceForm.Activate();
                indiceForm.Show();

                // Cerrar este formulario (LoginForm) después de abrir Indice
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Usuario no autorizado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
