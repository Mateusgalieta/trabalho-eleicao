using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using MySql.Data;


namespace Trabalho_Eleicao
{
    public partial class CodigoEditar : Form
    {
        string y;
        public CodigoEditar(string x)
        {
            y = x;
            InitializeComponent();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string strConexao = @"SERVER=localhost;DATABASE=trabalho_mailson;UID=root;PASSWORD=;";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open(); // Abre a conexão com o BD
            MySqlCommand cmd = new MySqlCommand("select codigo from eleicoes where titulo='" + y + "'", con);
            MySqlDataReader dados = cmd.ExecuteReader(); // Executa a consulta
            if (dados.HasRows == true)
            { // Verifica se a consulta retornou registros
                DataTable dt = new DataTable(); // Cria uma Tabela Genérica e Vazia
                dt.Load(dados); // Carrega os dados para o DataTable

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (textBox1.Text == dt.Rows[i]["codigo"].ToString())
                    {
                        EditarEleicao teste = new EditarEleicao(textBox1.Text);
                        teste.ShowDialog();
                        this.Close();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Código Incorreto!!!");
                        break;
                    }
                }
                con.Close();
            }
        }

        private void CodigoEditar_Load(object sender, EventArgs e)
        {

        }
    }
}
