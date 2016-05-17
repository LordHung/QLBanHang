using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang.Controls
{
    public class ToolStripOverride : ToolStripProfessionalRenderer
    {
        public ToolStripOverride() { }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e) { }
    }
}
