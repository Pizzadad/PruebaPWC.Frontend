using PruebaPWC.API; 

using PruebaPWC.API.ApiClient.Resource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaPWC.Frontend
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            

            var handler = new HttpClientHandler { AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip };

            WSCommon.Session = new ClientSesion();
            WSCommon.HttpAPIClient = new HttpClient(handler, true)
            {
                BaseAddress = new Uri(Constants.APIEndpoint),
                Timeout = TimeSpan.FromMilliseconds(7200000),
            };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPrincipal());
        }
    }
}
