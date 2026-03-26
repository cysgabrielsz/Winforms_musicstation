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
    public partial class formdetalhe_da_empresa : Form
    {
        private string connectionString = "Server=OSA0716348W11-1\\SQLEXPRESS; Database=MusicStation; Integrated Security=True;";
        private int _id;
        public formdetalhe_da_empresa()
        {
            InitializeComponent();
        }

        public formdetalhe_da_empresa(int id)
        {
            InitializeComponent();
            this._id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formdetalhe_da_empresa_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT 
            e.nome_fantasia,
            e.cnpj,
            e.razao_social,
            e.telefone,
            e.descricao,
            u.nome AS NomeUsuario,
            u.email
        FROM Empresas e
        JOIN Usuarios u ON e.usuario_id = u.id_usuario
        WHERE e.id_empresa = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", _id);

                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtNome.Text = dr["nome_fantasia"].ToString();
                    txtCnpj.Text = dr["cnpj"].ToString();
                    txtRazaoSocial.Text = dr["razao_social"].ToString();
                    txtTelefone.Text = dr["telefone"].ToString();
                    txtDescricao.Text = dr["descricao"].ToString();

                    txtEmail.Text = dr["NomeUsuario"].ToString();
                    txtEmail.Text = dr["email"].ToString();
                }

                conn.Close();
            }
        }
    }
}
