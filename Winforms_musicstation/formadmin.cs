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
    public partial class formadmin : Form
    {
        public formadmin()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Forminicial telainicial = new Forminicial();   
            telainicial.Show();
            this.Close();   
        }
    }
}
