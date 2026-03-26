using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_musicstation
{
    public partial class Forminicial : Form
    {
        private string connectionString = "Server=OSA0716348W11-1\\SQLEXPRESS; Integrated Security= True;";
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

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEmpresa formEmpresa = new formEmpresa();
            formEmpresa.Show();
            this.Hide();
        }

        private void instrumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forminstrumentos forminstrumentos = new forminstrumentos();
            forminstrumentos.Show();
            this.Hide();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formServiço formServiço = new formServiço();
            formServiço.Show();
            this.Hide();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPedidos formPedidos = new formPedidos();
            formPedidos.Show();
            this.Hide();
        }

        private void servicosPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formServicosPedidos formServicosPedidos = new formServicosPedidos();
            formServicosPedidos.Show();
            this.Hide();
        }

        private void locacoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLocacoes formLocacoes = new formLocacoes();
            formLocacoes.Show();
            this.Hide();
        }

        private void locacoesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formLocacoesitens formLocacoes = new formLocacoesitens();
            formLocacoes.Show();
            this.Hide();
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPagamentos formPagamentos = new formPagamentos();
            formPagamentos.Show();
            this.Hide();
        }

        private void tansacoesPagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTransacoes pagamentos = new formTransacoes();
            pagamentos.Show();
            this.Hide();
        }

        private void formasPagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formFormaspagamentos formFormaspagamentos = new formFormaspagamentos();
            formFormaspagamentos.Show();   
            this.Hide();
        }

        private void chatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formChats formChats = new formChats();
            formChats.Show();
            this.Hide();
        }

        private void mensagensToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formMensagens formMensagens = new formMensagens();
            formMensagens.Show();
            this.Hide();
        }

        private void notificacoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formNotificacoes formNotificacoes = new formNotificacoes();
            formNotificacoes.Show();
            this.Hide();
        }

        private void avaliacoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAvaliações formAvaliações = new formAvaliações();
            formAvaliações.Show();
            this.Hide();
        }



        private void dASHBOARDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDashboard formDashboard = new formDashboard();
            formDashboard.Show();
            this.Hide();
        }


    }
}

