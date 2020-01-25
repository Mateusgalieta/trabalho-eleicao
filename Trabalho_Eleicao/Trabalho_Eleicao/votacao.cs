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

namespace Trabalho_Eleicao
{

    public partial class votacao : Form
    {
        string codigo;
        public votacao(string w)
        {
            string x;
            codigo = w;

            InitializeComponent();
            string strConexao = @"SERVER=localhost;DATABASE=trabalho_mailson;UID=root;PASSWORD=;";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open(); // Abre a conexão com o BD
            MySqlCommand cmd = new MySqlCommand("select titulo,pais from eleicoes where codigo='" + codigo + "'", con);
            MySqlDataReader dados = cmd.ExecuteReader(); // Executa a consulta
            if (dados.HasRows == true)
            { // Verifica se a consulta retornou registros
                DataTable dt = new DataTable(); // Cria uma Tabela Genérica e Vazia
                dt.Load(dados); // Carrega os dados para o DataTable
                lbTitulo.Text = dt.Rows[0]["titulo"].ToString();
                x = dt.Rows[0]["pais"].ToString();
            }
            else
            {
                x = "erro";
            }
            con.Close();
            if (x == "1")
            {
                lbPais.Text = "Brasil";
            }
            if (x == "2")
            {
                lbPais.Text = "Argentina";
            }
            if (x == "3")
            {
                lbPais.Text = "Paraguai";
            }
            if (x == "4")
            {
                lbPais.Text = "Uruguai";
            }


        }


        private void votacao_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                btn1.PerformClick();
            }
            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                btn2.PerformClick();
            }
            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                btn3.PerformClick();
            }
            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                btn4.PerformClick();
            }
            if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                btn5.PerformClick();
            }
            if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                btn6.PerformClick();
            }
            if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                btn7.PerformClick();
            }
            if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                btn8.PerformClick();
            }
            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                btn9.PerformClick();
            }
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                btn0.PerformClick();
            }
            if (e.KeyCode == Keys.Enter)
            {
                btEnter.PerformClick();
            }
        }

        private void votacao_Load(object sender, EventArgs e)
        {

        }

        

        private void Btn1_Click_1(object sender, EventArgs e)
        {
            if (txtVoto.Text != null && txtVoto.Text.Length < 2)
            {
                txtVoto.Text = txtVoto.Text + "1";


            }
            if (txtVoto.Text.Length == 2)
            {

            }
            else

                txtVoto.Text = "1";
            label5.Focus();

        }

        private void Btn2_Click_1(object sender, EventArgs e)
        {
            if (txtVoto.Text != null && txtVoto.Text.Length < 2)
            {
                txtVoto.Text = txtVoto.Text + "2";


            }
            if (txtVoto.Text.Length == 2)
            {

            }
            else
                txtVoto.Text = "2";
            label5.Focus();
        }

        private void Btn3_Click_1(object sender, EventArgs e)
        {
            if (txtVoto.Text != null && txtVoto.Text.Length < 2)
            {
                txtVoto.Text = txtVoto.Text + "3";


            }
            if (txtVoto.Text.Length == 2)
            {

            }
            else

                txtVoto.Text = "3";
            label5.Focus();
        }

        private void Btn4_Click_1(object sender, EventArgs e)
        {
            if (txtVoto.Text != null && txtVoto.Text.Length < 2)
            {
                txtVoto.Text = txtVoto.Text + "4";


            }
            if (txtVoto.Text.Length == 2)
            {

            }
            else
                txtVoto.Text = "4";
            label5.Focus();
        }

        private void Btn5_Click_1(object sender, EventArgs e)
        {
            if (txtVoto.Text != null && txtVoto.Text.Length < 2)
            {
                txtVoto.Text = txtVoto.Text + "5";


            }
            if (txtVoto.Text.Length == 2)
            {

            }
            else
                txtVoto.Text = "5";
            label5.Focus();
        }

        private void Btn6_Click_1(object sender, EventArgs e)
        {
            if (txtVoto.Text != null && txtVoto.Text.Length < 2)
            {
                txtVoto.Text = txtVoto.Text + "6";


            }
            if (txtVoto.Text.Length == 2)
            {

            }
            else
                txtVoto.Text = "6";
            label5.Focus();
        }

        private void Btn7_Click_1(object sender, EventArgs e)
        {
            if (txtVoto.Text != null && txtVoto.Text.Length < 2)
            {
                txtVoto.Text = txtVoto.Text + "7";


            }
            if (txtVoto.Text.Length == 2)
            {

            }
            else
                txtVoto.Text = "7";
            label5.Focus();
        }

        private void Btn8_Click_1(object sender, EventArgs e)
        {
            if (txtVoto.Text != null && txtVoto.Text.Length < 2)
            {
                txtVoto.Text = txtVoto.Text + "8";


            }
            if (txtVoto.Text.Length == 2)
            {

            }
            else
                txtVoto.Text = "8";
            label5.Focus();
        }

        private void Btn9_Click_1(object sender, EventArgs e)
        {
            if (txtVoto.Text != null && txtVoto.Text.Length < 2)
            {
                txtVoto.Text = txtVoto.Text + "9";


            }
            if (txtVoto.Text.Length == 2)
            {

            }
            else
                txtVoto.Text = "9";
            label5.Focus();
        }

        private void BtBranco_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtVoto.Text))
            {
                txtVoto.Text = "Branco";
            }

            else
            {

            }

            label5.Focus();
        }

        private void BtCorrigir_Click_1(object sender, EventArgs e)
        {
            txtVoto.Text = null;

            label5.Focus();
        }

        private void VoltarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CodigoVoltar teste = new CodigoVoltar(lbTitulo.Text);
            teste.Owner = this;
            teste.ShowDialog();
            
        }

        private void BtEnter_Click(object sender, EventArgs e)
        {
            if (txtVoto.Text != "Branco" && !String.IsNullOrEmpty(txtVoto.Text))
            {
                string id;
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
               "inner join pessoas on candidaturas.id_pessoa = pessoas.id and id_eleicao =" + id + " and numero_partido =" + txtVoto.Text, con);
                cmd.ExecuteNonQuery();
                MySqlDataReader dados2 = cmd.ExecuteReader();
                if (dados2.HasRows == false)
                {
                    ConfirmaBrancoNulo teste2 = new ConfirmaBrancoNulo(txtVoto.Text, id);
                    teste2.ShowDialog();
                    txtVoto.Text = null;


                }

                else
                {
                    confirma teste2 = new confirma(txtVoto.Text, codigo);
                    teste2.ShowDialog();
                    txtVoto.Text = null;
                }

                con.Close();
            }

            else
            {
                string id;
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
                con.Close();
                ConfirmaBrancoNulo teste2 = new ConfirmaBrancoNulo(txtVoto.Text, id);
                teste2.ShowDialog();
                txtVoto.Text = null;
            }
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (txtVoto.Text != null && txtVoto.Text.Length < 2)
            {
                txtVoto.Text = txtVoto.Text + "0";


            }
            if (txtVoto.Text.Length == 2)
            {

            }
            else
                txtVoto.Text = "0";
            label5.Focus();
        }
    }
}
