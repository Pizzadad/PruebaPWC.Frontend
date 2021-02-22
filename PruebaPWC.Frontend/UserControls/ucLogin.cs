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

namespace PruebaPWC.Frontend.UserControls
{
    public partial class ucLogin : UserControl
    {
        public event EventHandler Atras;
        public event EventHandler RegistroNuevoEvent;
        public event EventHandler TareaExitosaEvent;

       
        private RequestLogger  _requestLogger;

        public RequestLogger  RequestLogger
        {
            get => _requestLogger;
            set 
            { 
                _requestLogger = value;
                bindingSource1.DataSource = value;
                bindingSource1.ResetBindings(true);
            }
        }


        public ucLogin()
        {
            InitializeComponent();
            Enabled = true;
            RequestLogger = new RequestLogger();
            
        }

        private async void ultraButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Enabled = false;

                var cliente = new UserClient(WSCommon.HttpAPIClient);

                var inicioSesion = await cliente.LoginAsync(RequestLogger);
                if (string.IsNullOrEmpty(inicioSesion.Token))
                {
                    MessageBox.Show("No se pudo loggear", @"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    WSCommon.Session.EmailUsuario = inicioSesion.Email;
                    WSCommon.Session.Password = RequestLogger.Password;
                    WSCommon.Session.RoleUser = inicioSesion.RoleUser;

                    TareaExitosaEvent?.Invoke(this, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Esto es un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Enabled = true;
            }
        }

        protected virtual void OnRegistroNuevoEvent()
        {
            RegistroNuevoEvent?.Invoke(this, EventArgs.Empty);
        }

        private void ultraButton2_Click(object sender, EventArgs e)
        {
            OnRegistroNuevoEvent();
        }
    }
}
