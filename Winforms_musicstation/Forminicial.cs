using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_musicstation
{
    public partial class Forminicial : Form
    {
        public Forminicial()
        {
            InitializeComponent();            

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formusuario formusuario = new formusuario();
            formusuario.Show();
            this.Hide();
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formsCargos formsCargos = new formsCargos();   
            formsCargos.Show();
            this.Hide();
        }
    }
}

