using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace RestauraDir
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void SelectColorBtn_Click(object sender, EventArgs e)
        {
            ColorDlg.ShowDialog();
            Properties.Settings.Default.ColorFondo = ColorDlg.Color;
            Properties.Settings.Default.Save();            
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {

        }
    }
}
