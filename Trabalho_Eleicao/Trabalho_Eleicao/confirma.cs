using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace Trabalho_Eleicao
{
    public partial class confirma : Form
    {
        string x, y, val;

        public confirma(string valor, string codigo)
        {
            val = valor;
            string id;
            InitializeComponent();
            string strConexao = @"SERVER=localhost;DATABASE=trabalho_mailson;UID=root;PASSWORD=;";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open(); // Abre a conexão com o BD
            MySqlCommand cmd = new MySqlCommand("select id from eleicoes where codigo='" + codigo + "'", con);
            MySqlDataReader dados = cmd.ExecuteReader(); // Executa a consulta
            if (dados.HasRows == true)
            { // Verifica se a consulta retornou registros
                DataTable dt = new DataTable(); // Cria uma Tabela Genérica e Vazia
                dt.Load(dados); // Carrega os dados para o DataTable
                id = dt.Rows[0]["id"].ToString();
            }
            else
            {
                id = "erro";
            }
            cmd = new MySqlCommand("select nome_completo, nome_partido, foto, id_pessoa, id_eleicao from candidaturas " +
           "inner join pessoas on candidaturas.id_pessoa = pessoas.id and id_eleicao =" + id + " and numero_partido =" + valor, con);
            cmd.ExecuteNonQuery();
            MySqlDataReader dados2 = cmd.ExecuteReader();
            if (dados2.HasRows == true)
            { // Verifica se a consulta retornou registros
                DataTable dt = new DataTable(); // Cria uma Tabela Genérica e Vazia
                dt.Load(dados2); // Carrega os dados para o DataTable
                lbNome.Text = dt.Rows[0]["nome_completo"].ToString();
                lbPartido.Text = dt.Rows[0]["nome_partido"].ToString();
                x = dt.Rows[0]["id_pessoa"].ToString();
                y = dt.Rows[0]["id_eleicao"].ToString();
                byte[] img = (byte[])dt.Rows[0]["foto"];
                MemoryStream ms = new MemoryStream(img);
                pbConfirma.Image = Image.FromStream(ms);


            }



            con.Close();


        }

        private void confirma_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pbConfirma_Click(object sender, EventArgs e)
        {

        }

        private void confirma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.S)
            {
                string strConexao = @"SERVER=localhost;DATABASE=trabalho_mailson;UID=root;PASSWORD=;";
                MySqlConnection con = new MySqlConnection(strConexao);
                con.Open(); // Abre a conexão com o BD
                MySqlCommand cmd = new MySqlCommand("INSERT INTO votos(valor_digitado, id_pessoa, id_eleicao) VALUES(@valor_digitado," +
                    " @id_pessoa,@id_eleicao)", con); // Define o comando SQL
                cmd.Parameters.AddWithValue("@valor_digitado", val);
                cmd.Parameters.AddWithValue("@id_pessoa", x);
                cmd.Parameters.AddWithValue("@id_eleicao", y);
                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();
                Fim teste2 = new Fim();
                teste2.ShowDialog();


            }


        }
    }
}
