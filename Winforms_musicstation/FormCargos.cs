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
    public partial class FormCargos : Form
    {
        public FormCargos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)// voltar para tela inicial
        {                   
            Forminicial telaInicial = new Forminicial();
            telaInicial.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Forminicial forminicial = new Forminicial();
            forminicial.Show();
            this.Close();
        }
    }
}
