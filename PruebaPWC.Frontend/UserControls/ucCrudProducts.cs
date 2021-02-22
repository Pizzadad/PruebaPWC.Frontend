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
using PruebaPWC.API.ApiClient;
using PruebaPWC.API;
using PruebaPWC.Frontend.Vista;

namespace PruebaPWC.Frontend.UserControls
{
    public partial class ucCrudProducts : UserControl
    {
        public event EventHandler AtrasEvent;
        private ProductoClient _productoClient;

        private readonly string _role;

        private List<ProductoDto> _model;

        public List<ProductoDto> Model
        {
            get => _model;
            set 
            { 
                _model = value;
                bindingSource1.DataSource = value;
                bindingSource1.ResetBindings(true);
            }
        }


        public ucCrudProducts(string role)
        {
            InitializeComponent();
            _role = role;
        }

        private async Task CargarData()
        {
            try
            {
                _productoClient = new ProductoClient(await WSCommon.HttpAPIClient.Autenticar());
                var data = await _productoClient.GetallAsync();
                Model = data.ToList();

                if (_role != "admin")
                {
                    ultraToolbarsManager1.Visible = false;
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ucCrudProducts_Load(object sender, EventArgs e)
        {
            await CargarData();
        }

        private async void ultraToolbarsManager1_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {
            try
            {
                switch (e.Tool.Key)
                {
                    case "ButtonTool1":

                        var addProduct = new frmCUProducto(null);
                        var addDialog = addProduct.ShowDialog();

                        if (addDialog == DialogResult.OK)
                        {
                            await CargarData();
                        }

                        break;
                    case "ButtonTool2":

                        if (ultraGrid1.ActiveRow.IsFilterRow) return;

                        _productoClient = new ProductoClient(await WSCommon.HttpAPIClient.Autenticar());

                        var deleteProduct = (ProductoDto)ultraGrid1.ActiveRow.ListObject;

                        var msg = MessageBox.Show($@"¿Seguro de borrar el producto {deleteProduct.NombreProducto}?", @"Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (msg == DialogResult.No) return;

                        var s = await _productoClient.DeleteAsync(deleteProduct.IdProducto);

                        if (s > 0)
                        {
                            await CargarData();
                        }

                        break;
                    case "ButtonTool3":

                        if (ultraGrid1.ActiveRow.IsFilterRow) return;

                        var updateProduct = (ProductoDto)ultraGrid1.ActiveRow.ListObject;

                        var updProduct = new frmCUProducto(updateProduct.IdProducto);

                        var updDialog = updProduct.ShowDialog();

                        if (updDialog == DialogResult.OK)
                        {
                            await CargarData();
                        }

                        break;
                    
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            var menssage = MessageBox.Show(@"Va a cerrar sesión, ¿Estas seguro?", @"Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (menssage != DialogResult.Yes) return;

            WSCommon.Session.EmailUsuario = null;
            WSCommon.Session.Password = null;
            WSCommon.Session.RoleUser = null;

            AtrasEvent?.Invoke(sender, e);
        }
    }
}
