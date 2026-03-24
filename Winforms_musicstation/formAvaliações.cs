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
    public partial class formAvaliações : Form
    {
        private string connectionString = "Server=OSA0716348W11-1\\SQLEXPRESS; Integrated Security= True;";
        public formAvaliações()
        {
            InitializeComponent();
            CarregarDados();
        }

        private void CarregarDados()
        {
            dataGridView1.Rows.Clear(); //Limpa os itens da listbox antes de adicionar novos
            using (SqlConnection conn = new SqlConnection(connectionString)) //cria a conexão com o banco de dados
            {
                conn.Open(); //abre conexão com o banco
                SqlCommand cmd = new SqlCommand("USE MusicStation SELECT id_avaliacao, servico_pedido_id, cliente_id, nota, comentario, CONVERT(VARCHAR, data_avaliacao, 103) AS data_avaliacao FROM Avaliacoes", conn);
                //cria um comando sql para selecionar os usuarios da tabela
                SqlDataReader reader = cmd.ExecuteReader();//executa o comando que retorna um leitor de dados

                while (reader.Read())//percorre os resultados retornandos pela consulta
                {
                    dataGridView1.Rows.Add(reader["id_avaliacao"].ToString(), " | " + reader["servico_pedido_id"].ToString(), " | " + reader["cliente_id"].ToString(), " | " + reader["nota"].ToString(), " | " + reader["data_avaliacao"].ToString());
                }
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Forminicial forminicial = new Forminicial();
            forminicial.Show();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            formdetalheavaliacao tela = new formdetalheavaliacao(id);
            tela.ShowDialog();           
        }
    }
}
