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
    public partial class CadastroEleicao : Form
    {
        public struct candidatura
        {
            public string id_pessoa;
            public string id_eleicao;
        }
        public struct Candidato
        {
            public string id;
            public string nome_completo;
            public int numero_partido;
            public string nome_partido;
        }

        List<Candidato> lista = new List<Candidato>();
        List<Candidato> lista2 = new List<Candidato>();
        List<int> votos = new List<int>();
        Candidato y; 
        DateTime today = DateTime.Now;
        
        public CadastroEleicao()
        {
            InitializeComponent();
            Candidato x;
            string numero;
            string y;
            txtDataCadastro.Text = today.Day.ToString()+ today.Month.ToString()+ today.Year.ToString();
            string strConexao = @"SERVER=localhost;DATABASE=trabalho_mailson;UID=root;PASSWORD=;";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open(); // Abre a conexão com o BD
            MySqlCommand cmd = new MySqlCommand("select count(*) from pessoas", con);
            MySqlDataReader dados = cmd.ExecuteReader(); // Executa a consulta
            if (dados.HasRows == true)
            { // Verifica se a consulta retornou registros
                DataTable dt = new DataTable(); // Cria uma Tabela Genérica e Vazia
                dt.Load(dados); // Carrega os dados para o DataTable
                y = dt.Rows[0]["count(*)"].ToString();
            }
            else
            {
                y = "0";
            }
            for (int i = 0; i < int.Parse(y); i++)
            {
                cmd = new MySqlCommand("select * from pessoas", con);
                cmd.ExecuteNonQuery();
                MySqlDataReader dados2 = cmd.ExecuteReader();
                if (dados2.HasRows == true)
                { // Verifica se a consulta retornou registros


                    DataTable dt = new DataTable(); // Cria uma Tabela Genérica e Vazia
                    dt.Load(dados2); // Carrega os dados para o DataTable
                    x.nome_completo = dt.Rows[i]["nome_completo"].ToString();
                    x.nome_partido = dt.Rows[i]["nome_partido"].ToString();
                    numero = dt.Rows[i]["numero_partido"].ToString();
                    x.numero_partido = int.Parse(numero);
                    x.id = dt.Rows[i]["id"].ToString();
                    lista.Add(x);
                }

            }



            con.Close();

            for (int i = 0; i < lista.Count; i++)
            {

                dgvCandidatos.Rows.Add();

                dgvCandidatos.Rows[i].Cells[1].Value = lista[i].nome_completo;
                dgvCandidatos.Rows[i].Cells[2].Value = lista[i].nome_partido;
                dgvCandidatos.Rows[i].Cells[3].Value = lista[i].numero_partido;


            }

        }










        private void CadastroEleicao_Load(object sender, EventArgs e)
        {

        }

        private void cklbPartidos_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void cklbPartidos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cklbCandidatos_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void lbCadastroDeEleicao_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            int marcados = 0;
            int r = 0;
            while (r == 0)
            {
                for (int i = 0; i < dgvCandidatos.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgvCandidatos.Rows[i].Cells[0].Value) == true)
                    {
                        marcados++;
                    }
                }
                if (String.IsNullOrEmpty(txtCodigo.Text) || String.IsNullOrEmpty(txtDataEleicao.Text) || String.IsNullOrEmpty(txtDataCadastro.Text)
                    || String.IsNullOrEmpty(txtTitulo.Text) || comboBox1.SelectedIndex == -1)
                {

                    MessageBox.Show("Preencha todos os campos!!!");
                    break;
                }
                DateTime temp;
                if (DateTime.TryParse(txtDataCadastro.Text, out temp))
                {
                    // Yay :)
                }
                else
                {
                    MessageBox.Show("Data de Cadastro Inválida!!!");
                    break;
                }
                if (DateTime.TryParse(txtDataEleicao.Text, out temp))
                {
                    // Yay :)
                }
                else
                {
                    MessageBox.Show("Data da Eleição Inválida!!!");
                    break;
                }
                if (!String.IsNullOrEmpty(txtCodigo.Text) && txtCodigo.Text.Length < 8)
                {
                    MessageBox.Show("O código deve conter pelo menos 8 caracteres!");
                    break;
                }
                if (!String.IsNullOrEmpty(txtCodigo.Text) && txtCodigo.Text.Length >= 8)
                {
                    if (!txtCodigo.Text.Any(Char.IsLetter) || !txtCodigo.Text.Any(Char.IsDigit))
                    {
                        MessageBox.Show("O código deve conter números e letras!!!");
                        break;
                    }


                    else
                    {
                        string strConexao = @"SERVER=localhost;DATABASE=trabalho_mailson;UID=root;PASSWORD=;";
                        MySqlConnection con = new MySqlConnection(strConexao);
                        con.Open(); // Abre a conexão com o BD
                        MySqlCommand cmd = new MySqlCommand("select codigo from eleicoes", con);
                        MySqlDataReader dados = cmd.ExecuteReader(); // Executa a consulta
                        if (dados.HasRows == true)
                        { // Verifica se a consulta retornou registros
                            DataTable dt = new DataTable(); // Cria uma Tabela Genérica e Vazia
                            dt.Load(dados); // Carrega os dados para o DataTable

                            int p = 0;
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {

                                if (txtCodigo.Text == dt.Rows[i]["codigo"].ToString())
                                {
                                    p++;

                                }
                                else { con.Close(); }
                            }

                            if (p > 0)
                            {
                                MessageBox.Show("Este código já foi registrado. Insira outro!!!");
                                break;
                            }
                            con.Close();
                        }


                    }
                }
                if (!String.IsNullOrEmpty(txtTitulo.Text))
                {
                    int u = 0;
                    string strConexao = @"SERVER=localhost;DATABASE=trabalho_mailson;UID=root;PASSWORD=;";
                    MySqlConnection con = new MySqlConnection(strConexao);
                    con.Open(); // Abre a conexão com o BD
                    MySqlCommand cmd = new MySqlCommand("select titulo from eleicoes", con);
                    MySqlDataReader dados = cmd.ExecuteReader(); // Executa a consulta
                    if (dados.HasRows == true)
                    { // Verifica se a consulta retornou registros
                        DataTable dt = new DataTable(); // Cria uma Tabela Genérica e Vazia
                        dt.Load(dados); // Carrega os dados para o DataTable

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (txtTitulo.Text == dt.Rows[i]["titulo"].ToString())
                            {
                                u++;

                            }
                            else { }
                        }
                        if (u > 0)
                        {
                            MessageBox.Show("Já existe uma eleição com esse Título. Insira outro!!!");
                            con.Close();
                            break;
                        }
                        con.Close();
                    }



                }
                if (marcados <= 1)
                {

                    MessageBox.Show("Escolha no mínimo 2 candidatos");
                    break;

                }
                else

                    for (int i = 0; i < dgvCandidatos.Rows.Count; i++)
                    {

                        if (Convert.ToBoolean(dgvCandidatos.Rows[i].Cells[0].Value) == true)
                        {
                            int x = int.Parse(Convert.ToString(dgvCandidatos.Rows[i].Cells[3].Value));
                            votos.Add(x);

                        }
                    }

                if (votos.Count != votos.Distinct().Count())
                {
                    MessageBox.Show("Escolha Somente Candidatos de Partidos Diferentes!!!!");
                    votos.Clear();
                    break;
                }
                else
                {

                    // Define a Str de Conexão
                    string strConexao = @"SERVER=localhost;DATABASE=trabalho_mailson;UID=root;PASSWORD=;";
                    // Cria a conexão com o BD
                    MySqlConnection con = new MySqlConnection(strConexao);
                    con.Open(); // Abre a Conexão com o BD
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO eleicoes(codigo, titulo,data_cadastro, data_eleicao,pais) " +
                    "VALUES(@codigo, @titulo, @data_cadastro, @data_eleicao,@pais)", con); // Define o comando SQL
                    cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                    cmd.Parameters.AddWithValue("@titulo", txtTitulo.Text);
                    cmd.Parameters.AddWithValue("@data_cadastro", Convert.ToDateTime(txtDataCadastro.Text));
                    cmd.Parameters.AddWithValue("@data_eleicao", Convert.ToDateTime(txtDataEleicao.Text));
                    if (comboBox1.SelectedIndex == 0)
                    {
                        cmd.Parameters.AddWithValue("@pais", 1);
                    }
                    if (comboBox1.SelectedIndex == 1)
                    {
                        cmd.Parameters.AddWithValue("@pais", 2);
                    }
                    if (comboBox1.SelectedIndex == 2)
                    {
                        cmd.Parameters.AddWithValue("@pais", 3);
                    }
                    if (comboBox1.SelectedIndex == 3)
                    {
                        cmd.Parameters.AddWithValue("@pais", 4);
                    }

                    cmd.ExecuteNonQuery();
                    for (int i = 0; i < dgvCandidatos.Rows.Count; i++)
                    {

                        if (Convert.ToBoolean(dgvCandidatos.Rows[i].Cells[0].Value) == true)
                        {

                            y.nome_completo = Convert.ToString(dgvCandidatos.Rows[i].Cells[1].Value);
                            y.nome_partido = Convert.ToString(dgvCandidatos.Rows[i].Cells[2].Value);
                            y.numero_partido = int.Parse(Convert.ToString(dgvCandidatos.Rows[i].Cells[3].Value));
                            lista2.Add(y);
                        }
                    }

                    foreach (Candidato item in lista2)
                    {
                        candidatura teste;
                        cmd = new MySqlCommand("select id from pessoas where nome_completo ='" + item.nome_completo + "'", con);
                        cmd.ExecuteNonQuery();
                        MySqlDataReader dados = cmd.ExecuteReader();
                        if (dados.HasRows == true)
                        { // Verifica se a consulta retornou registros
                            DataTable dt = new DataTable(); // Cria uma Tabela Genérica e Vazia
                            dt.Load(dados); // Carrega os dados para o DataTable
                            teste.id_pessoa = dt.Rows[0]["id"].ToString();
                        }
                        else { teste.id_pessoa = "erro"; }
                        cmd = new MySqlCommand("select id from eleicoes where codigo ='" + txtCodigo.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        MySqlDataReader dados2 = cmd.ExecuteReader();
                        if (dados2.HasRows == true)
                        { // Verifica se a consulta retornou registros
                            DataTable dt = new DataTable(); // Cria uma Tabela Genérica e Vazia
                            dt.Load(dados2); // Carrega os dados para o DataTable
                            teste.id_eleicao = dt.Rows[0]["id"].ToString();
                        }
                        else { teste.id_eleicao = "erro"; }
                        cmd = new MySqlCommand("INSERT INTO candidaturas(id_pessoa, id_eleicao) " +
                "VALUES(@id_pessoa, @id_eleicao)", con);
                        cmd.Parameters.AddWithValue("@id_pessoa", teste.id_pessoa);
                        cmd.Parameters.AddWithValue("@id_eleicao", teste.id_eleicao);
                        cmd.ExecuteNonQuery();

                    }
                    con.Close();
                    txtCodigo.Text = null;
                    txtTitulo.Text = null;
                    txtDataEleicao.Text = null;
                    comboBox1.SelectedIndex = -1;
                    for (int i = 0; i < dgvCandidatos.Rows.Count; i++)
                    {

                        if (Convert.ToBoolean(dgvCandidatos.Rows[i].Cells[0].Value) == true)
                        {
                            dgvCandidatos.Rows[i].Cells[0].Value = false;


                        }

                    }
                    votos.Clear();
                    MessageBox.Show("Eleição Cadastrada com Sucesso!!!");
                    r++;
                    // Fecha a Conexão com o BD
                }
            }



        }
    }
}
