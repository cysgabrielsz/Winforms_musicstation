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
    public partial class formlogin : Form
    {
        public formlogin()
        {
            InitializeComponent();
        }


        private void formlogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtNome.Text;
            string senha = txtSenha.Text;

            if (usuario == "admin" && senha == "123")
            {                
                Forminicial telaPrincipal = new Forminicial();
                telaPrincipal.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos");
            }
        }


    }

}
        

        


