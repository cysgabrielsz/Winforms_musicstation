using System;
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
    public partial class formusuario : Form
    {
        private string connectionString = "Server=OSA0716348W11-1\\SQLEXPRESS; Integrated Security= True;";
        public formusuario()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void CarregarDados() //Metodo para carregar os dados do banco no listbox
        {
            dataGridView1.Rows.Clear(); //Limpa os itens da listbox antes de adicionar novos
            using (SqlConnection conn = new SqlConnection(connectionString)) //cria a conexão com o banco de dados
            {
                conn.Open(); //abre conexão com o banco
                SqlCommand cmd = new SqlCommand("USE MeuBanco00 SELECT Nome, Preco, Quantidade FROM Produtos", conn);
                //cria um comando sql para selecionar os usuarios da tabela
                SqlDataReader reader = cmd.ExecuteReader();//executa o comando que retorna um leitor de dados

                while (reader.Read())//percorre os resultados retornandos pela consulta
                {
                    dataGridView1.Rows.Add(reader["Nome"].ToString(),  " | " + "R$" + reader["Preco"].ToString(),  " | " + reader["Quantidade"].ToString());
                }
            }

        }

        private void button1_Click(object sender, EventArgs e) //voltar para tela inicial
        {
            Forminicial telaInicial = new Forminicial();
            telaInicial.Show();
            this.Close();
        }
    }

}
