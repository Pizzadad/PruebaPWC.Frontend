using PruebaPWC.Api.API;
using PruebaPWC.API;

using PruebaPWC.Frontend.Extension;
using PruebaPWC.Frontend.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaPWC.Frontend
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CargarLogin();
        }

        private void CargarLogin()
        {
            var control = new ucLogin();
            control.RegistroNuevoEvent += (o, args) =>
            {
                CargarRegistro();
            };
            control.TareaExitosaEvent += (o, args) =>
            {
                CargarListaProducto(WSCommon.Session.RoleUser);
                this.Text = $@"Bienvenido - {WSCommon.Session.EmailUsuario}";
            };
            
            contentPanel.ContenerControl(control);
            pictureBox1.Image = Properties.Resources.loggin;
        }

        private void CargarListaProducto(string role)
        {
            var control = new ucCrudProducts(role);

            control.AtrasEvent += (o, args) =>
            {
                CargarLogin();
                this.Text = $@"Bienvenido";
            };

            contentPanel.ContenerControl(control);
            pictureBox1.Image = Properties.Resources.products;
        }

        private void CargarRegistro()
        {
            var control = new ucRegister();

            control.TareaExitosaEvent += (o, args) =>
            {
                var model = (RequestRegisterUser)o;
                model.Email = model.Email;
                MessageBox.Show("Se creo el usuario, inicie sesión", @"ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            };
            control.AtrasEvent += (o, args) =>
            {
                CargarLogin();
            };
            contentPanel.ContenerControl(control);
            pictureBox1.Image = Properties.Resources.register;
        }

    }
}
