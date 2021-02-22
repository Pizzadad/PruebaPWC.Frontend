using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaPWC.Frontend.Extension
{
    public static class Extensiones
    {
        public static void ContenerControl(this Panel panel, System.Windows.Forms.Control control)
        {
            panel.LimpiarControles();
            panel.Controls.Add(control);
            panel.Controls[0].Dock = DockStyle.Fill;
        }
        public static void LimpiarControles(this Panel panel)
        {
            foreach (System.Windows.Forms.Control contentPanelControl in panel.Controls)
            {
                panel.Controls.Remove(contentPanelControl);
            }
        }

        public static T MapTo<T>(this object value)
        {
            return JsonConvert.DeserializeObject<T>(
                JsonConvert.SerializeObject(value, Formatting.Indented, new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                })
            );
        }

    }
}
