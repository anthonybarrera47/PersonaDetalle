using PersonaDetalle.UI.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonaDetalle
{
    public partial class RegistroDetalle : Form
    {
        public RegistroDetalle()
        {
            InitializeComponent();
        }

        private void nuevaPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroPersonas registroPersonas = new RegistroPersonas();
            registroPersonas.MdiParent = this;
            registroPersonas.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
