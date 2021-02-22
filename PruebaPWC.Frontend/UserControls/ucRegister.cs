using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PruebaPWC.Api.API;
using PruebaPWC.API;
using PruebaPWC.Frontend.Extension;

namespace PruebaPWC.Frontend.UserControls
{
    public partial class ucRegister : UserControl
    {
        public event EventHandler AtrasEvent;
        public event EventHandler TareaExitosaEvent;

        private RequestRegisterUser _model;

        public RequestRegisterUser Model
        {
            get => _model;
            set 
            { 
                _model = value;
                bindingSource1.DataSource = value;
                bindingSource1.ResetBindings(true);
            }
        }


        public ucRegister()
        {
            InitializeComponent();
        }

        private void ucRegister_Load(object sender, EventArgs e)
        {
            Enabled = false;
            Model = new RequestRegisterUser();

            Combo item1 = new Combo();
            item1.Text = "admin";
            item1.Value = 1;

            Combo item2 = new Combo();
            item2.Text = "comprador";
            item2.Value = 2;

            cboRol.Items.Add(item1);
            cboRol.Items.Add(item2);
            

            Enabled = true;
        }

        private async void ultraButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Enabled = false;
                var cl = new UserClient(WSCommon.HttpAPIClient);
                var usuario = await cl.RegisterAsync(Model);

                if (usuario != null && usuario.Token.Any() == true)
                {
                    AtrasEvent?.Invoke(this, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Enabled = true;
            }
        }

        private void ultraButton2_Click(object sender, EventArgs e)
        {
            AtrasEvent?.Invoke(this, e);
        }
    }
}
