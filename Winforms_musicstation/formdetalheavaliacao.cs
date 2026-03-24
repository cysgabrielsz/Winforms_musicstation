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
    public partial class formdetalheavaliacao : Form
    {
        private string connectionString = "Server=OSA0716348W11-1\\SQLEXPRESS; Database=MusicStation; Integrated Security=True;";
        private int _id;
        public formdetalheavaliacao()
        {
            InitializeComponent();
        }        

        public formdetalheavaliacao(int id)
        {
            InitializeComponent();
            _id = id;           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void formdetalheavaliacao_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT a.nota, a.comentario, a.data_avaliacao, u.nome AS NomeUsuario FROM Avaliacoes a JOIN Clientes c ON a.cliente_id = c.id_cliente JOIN Usuarios u ON c.usuario_id = u.id_usuario WHERE a.id_avaliacao = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", _id);

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtUsuario.Text = dr["NomeUsuario"].ToString();
                    txtNota.Text = dr["nota"].ToString();
                    txtComentario.Text = dr["comentario"].ToString();

                    txtData.Text = Convert.ToDateTime(dr["data_avaliacao"])
                                   .ToString("dd/MM/yyyy");

                    int nota = Convert.ToInt32(dr["nota"]);
                    lblNota.Text = new string('★', nota);
                }

                conn.Close();
            }
        }
    }
}
