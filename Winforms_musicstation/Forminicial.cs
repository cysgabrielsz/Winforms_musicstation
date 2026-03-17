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
            FormCargos formsCargos = new FormCargos();   
            formsCargos.Show();
            this.Hide();
        }

        private void profissionaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfissionais formsprofissional = new FormProfissionais(); 
            formsprofissional.Show();
            this.Hide();
        }

        private void profissionalCargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfissionalCargo formProfissionalCargo = new FormProfissionalCargo(); 
            formProfissionalCargo.Show();
            this.Hide();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formclientes formclientes = new formclientes();
            formclientes.Show();
            this.Hide();
        }

        private void adminstradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formadmin formadmin = new formadmin(); 
            formadmin.Show();
            this.Hide();
        }
        
    }
}

