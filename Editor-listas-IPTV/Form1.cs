using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_listas_IPTV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialogIPTV.Filter = "IPTV list (*.m3u)|*.m3u";
        }

        private void CargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (openFileDialogIPTV.ShowDialog() == DialogResult.OK)
            {
                lblListaLeida.Text = openFileDialogIPTV.FileName;
            }
        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pendiente de implementación", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versión: " + Assembly.GetEntryAssembly().GetName().Version + Environment.NewLine + "Desarrollado por Warger95", "Info", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Exclamation);
        }
    }
}
