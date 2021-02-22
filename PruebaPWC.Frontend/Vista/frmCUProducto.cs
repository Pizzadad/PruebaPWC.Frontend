using PruebaPWC.Api.API;
using PruebaPWC.API;
using PruebaPWC.Frontend.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaPWC.Frontend.Vista
{
    public partial class frmCUProducto : Form
    {
        private readonly int? _idProducto;
        private ProductoClient _productoClient;

        private ProductoDto _productoDto;

        public ProductoDto ProductoDto
        {
            get => _productoDto;
            set 
            { 
                _productoDto = value;
                bindingSource1.DataSource = value;
                bindingSource1.ResetBindings(true);
            }
        }


        public frmCUProducto(int? idProducto = null)
        {
            InitializeComponent();
            _idProducto = idProducto;
            ProductoDto = new ProductoDto();
        }

        private async void frmCUProducto_Load(object sender, EventArgs e)
        {
            try
            {
                if (_idProducto.HasValue)
                {
                    await CargarProducto(_idProducto.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task CargarProducto(int id)
        {
            try
            {
                _productoClient = new ProductoClient(await WSCommon.HttpAPIClient.Autenticar());

                ProductoDto = await _productoClient.GetAsync(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task Save()
        {
            try
            {
                _productoClient = new ProductoClient(await WSCommon.HttpAPIClient.Autenticar());

                if ((_idProducto ?? 0) == 0)
                {
                    var addProduct = ProductoDto.MapTo<RequestProductoCreate>();
                    
                    await _productoClient.CreateAsync(addProduct);

                    DialogResult = DialogResult.OK;

                }
                else
                {
                    var updtProduct = ProductoDto.MapTo<RequestProductoUpdate>();

                    await _productoClient.UpdateAsync(updtProduct.IdProducto, updtProduct);

                    DialogResult = DialogResult.OK;
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ultraToolbarsManager1_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {
            switch (e.Tool.Key)
            {
                case "ButtonTool1":

                    await Save();

                    break;
                default:
                    break;
            }
        }
    }
}
