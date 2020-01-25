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
    public partial class exibirEleicoes : Form
    {
        public struct Eleicao
        {
            public string titulo;
            public string data_cadastro;
            public string data_eleicao;
            public int pais;
        }


        List<Eleicao> lista = new List<Eleicao>();
        List<int> ids = new List<int>();
        List<string> codigos = new List<string>();
        DateTime today = DateTime.Now;
        public exibirEleicoes()
        {

            InitializeComponent();
            Eleicao x;
            string y;
            string numero;
            string strConexao = @"SERVER=localhost;DATABASE=trabalho_mailson;UID=root;PASSWORD=;";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open(); // Abre a conexão com o BD
            MySqlCommand cmd = new MySqlCommand("select count(*) from eleicoes", con);
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
                cmd = new MySqlCommand("select * from eleicoes", con);
                cmd.ExecuteNonQuery();
                MySqlDataReader dados2 = cmd.ExecuteReader();
                if (dados2.HasRows == true)
                { // Verifica se a consulta retornou registros


                    DataTable dt = new DataTable(); // Cria uma Tabela Genérica e Vazia
                    dt.Load(dados2); // Carrega os dados para o DataTable
                    x.titulo = dt.Rows[i]["titulo"].ToString();
                    x.data_cadastro = dt.Rows[i]["data_cadastro"].ToString();
                    x.data_eleicao = dt.Rows[i]["data_eleicao"].ToString();
                    numero = dt.Rows[i]["pais"].ToString();
                    x.pais = int.Parse(numero);
                    ids.Add(int.Parse(dt.Rows[i]["id"].ToString()));
                    codigos.Add(dt.Rows[i]["codigo"].ToString());
                    lista.Add(x);
                }

            }



            con.Close();

            for (int i = 0; i < lista.Count; i++)
            {

                dgvEleicoes.Rows.Add();
                int pais = lista[i].pais;
                dgvEleicoes.Rows[i].Cells[0].Value = lista[i].titulo;
                dgvEleicoes.Rows[i].Cells[1].Value = lista[i].data_cadastro;
                dgvEleicoes.Rows[i].Cells[2].Value = lista[i].data_eleicao;
                if (pais == 1)
                    dgvEleicoes.Rows[i].Cells[3].Value = "Brasil";
                if (pais == 2)
                    dgvEleicoes.Rows[i].Cells[3].Value = "Argentina";
                if (pais == 3)
                    dgvEleicoes.Rows[i].Cells[3].Value = "Paraguai";
                if (pais == 4)
                    dgvEleicoes.Rows[i].Cells[3].Value = "Uruguai";


            }
            for (int i = 0; i < dgvEleicoes.Rows.Count; i++)
            {

                con = new MySqlConnection(strConexao);
                con.Open(); // Abre a conexão com o BD
                cmd = new MySqlCommand("select situacao from eleicoes", con);
                MySqlDataReader dados2 = cmd.ExecuteReader(); // Executa a consulta
                if (dados2.HasRows == true)
                { // Verifica se a consulta retornou registros
                    DataTable dt = new DataTable(); // Cria uma Tabela Genérica e Vazia
                    dt.Load(dados2); // Carrega os dados para o DataTable
                    if (int.Parse(dt.Rows[i]["situacao"].ToString()) == 1)
                    {
                        dgvEleicoes.Rows[i].Cells[6].Value = "--";
                        dgvEleicoes.Rows[i].Cells[7].Value = "--";
                    }
                    if (int.Parse(dt.Rows[i]["situacao"].ToString()) == 2)
                    {
                        dgvEleicoes.Rows[i].Cells[5].Value = "Iniciada";

                        dgvEleicoes.Rows[i].Cells[4].Value = "Iniciada";

                    }
                    if (int.Parse(dt.Rows[i]["situacao"].ToString()) == 3)
                    {
                        dgvEleicoes.Rows[i].Cells[4].Value = "Finalizada";
                        dgvEleicoes.Rows[i].Cells[5].Value = "Finalizada";
                        dgvEleicoes.Rows[i].Cells[6].Value = "Finalizada";
                        dgvEleicoes.Rows[i].Cells[7].Value = "Finalizada";

                    }
                }


            }
            con.Close();
        }

        private void exibirEleicoes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lista.Clear();
            codigos.Clear();
            ids.Clear();
            Eleicao x;
            string y;
            string numero;
            string strConexao = @"SERVER=localhost;DATABASE=trabalho_mailson;UID=root;PASSWORD=;";
            MySqlConnection con = new MySqlConnection(strConexao);
            con.Open(); // Abre a conexão com o BD
            MySqlCommand cmd = new MySqlCommand("select count(*) from eleicoes", con);
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
                cmd = new MySqlCommand("select * from eleicoes", con);
                cmd.ExecuteNonQuery();
                MySqlDataReader dados2 = cmd.ExecuteReader();
                if (dados2.HasRows == true)
                { // Verifica se a consulta retornou registros


                    DataTable dt = new DataTable(); // Cria uma Tabela Genérica e Vazia
                    dt.Load(dados2); // Carrega os dados para o DataTable
                    x.titulo = dt.Rows[i]["titulo"].ToString();
                    x.data_cadastro = dt.Rows[i]["data_cadastro"].ToString();
                    x.data_eleicao = dt.Rows[i]["data_eleicao"].ToString();
                    numero = dt.Rows[i]["pais"].ToString();
                    x.pais = int.Parse(numero);
                    ids.Add(int.Parse(dt.Rows[i]["id"].ToString()));
                    codigos.Add(dt.Rows[i]["codigo"].ToString());
                    lista.Add(x);
                }

            }



            con.Close();

            for (int i = 0; i < lista.Count; i++)
            {

                dgvEleicoes.Rows.Add();
                int pais = lista[i].pais;
                dgvEleicoes.Rows[i].Cells[0].Value = lista[i].titulo;
                dgvEleicoes.Rows[i].Cells[1].Value = lista[i].data_cadastro;
                dgvEleicoes.Rows[i].Cells[2].Value = lista[i].data_eleicao;
                if (pais == 1)
                    dgvEleicoes.Rows[i].Cells[3].Value = "Brasil";
                if (pais == 2)
                    dgvEleicoes.Rows[i].Cells[3].Value = "Argentina";
                if (pais == 3)
                    dgvEleicoes.Rows[i].Cells[3].Value = "Paraguai";
                if (pais == 4)
                    dgvEleicoes.Rows[i].Cells[3].Value = "Uruguai";


            }

            for (int i = 0; i < dgvEleicoes.Rows.Count; i++)
            {

                con = new MySqlConnection(strConexao);
                con.Open(); // Abre a conexão com o BD
                cmd = new MySqlCommand("select situacao from eleicoes", con);
                MySqlDataReader dados2 = cmd.ExecuteReader(); // Executa a consulta
                if (dados2.HasRows == true)
                { // Verifica se a consulta retornou registros
                    DataTable dt = new DataTable(); // Cria uma Tabela Genérica e Vazia
                    dt.Load(dados2); // Carrega os dados para o DataTable
                    if (int.Parse(dt.Rows[i]["situacao"].ToString()) == 1)
                    {
                        dgvEleicoes.Rows[i].Cells[6].Value = "--";
                        dgvEleicoes.Rows[i].Cells[7].Value = "--";
                    }
                    if (int.Parse(dt.Rows[i]["situacao"].ToString()) == 2)
                    {
                        dgvEleicoes.Rows[i].Cells[5].Value = "Iniciada";

                        dgvEleicoes.Rows[i].Cells[4].Value = "Iniciada";

                    }
                    if (int.Parse(dt.Rows[i]["situacao"].ToString()) == 3)
                    {
                        dgvEleicoes.Rows[i].Cells[4].Value = "Finalizada";
                        dgvEleicoes.Rows[i].Cells[5].Value = "Finalizada";
                        dgvEleicoes.Rows[i].Cells[6].Value = "Finalizada";
                        dgvEleicoes.Rows[i].Cells[7].Value = "Finalizada";

                    }
                }


            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvEleicoes.Rows.Clear();

        }

        private void exibirEleicoes_Load_1(object sender, EventArgs e)
        {

        }

        private void DgvEleicoes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = 0;
            while (r == 0)
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0 && e.ColumnIndex == 4)
                {
                    int i = e.RowIndex;
                    if (Convert.ToString(dgvEleicoes.Rows[i].Cells[4].Value) == "Finalizada")
                    {
                        MessageBox.Show("Eleição Finalizada. Ímpossível Editar!!!!");
                        break;
                    }
                    if (Convert.ToString(dgvEleicoes.Rows[i].Cells[4].Value) == "Iniciada")
                    {
                        MessageBox.Show("Eleição Iniciada. Ímpossível Editar!!!!");
                        break;
                    }
                    else
                    {
                        CodigoEditar teste = new CodigoEditar(Convert.ToString(dgvEleicoes.Rows[e.RowIndex].Cells[0].Value));
                        teste.ShowDialog();
                        button2_Click(null, null);
                        button1_Click(null, null);
                        break;
                    }
                }
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0 && e.ColumnIndex == 5)
                {
                    int i = e.RowIndex;
                    DateTime data;
                    string strConexao = @"SERVER=localhost;DATABASE=trabalho_mailson;UID=root;PASSWORD=;";
                    // Cria a conexão com o BD
                    MySqlConnection con = new MySqlConnection(strConexao);
                    con.Open(); // Abre a conexão com o BD
                    MySqlCommand cmd = new MySqlCommand("SELECT data_eleicao FROM eleicoes where codigo='" + codigos[int.Parse(e.RowIndex.ToString())]
                       + "'", con);
                    MySqlDataReader dados = cmd.ExecuteReader(); // Executa a consulta
                    if (dados.HasRows == true)
                    { // Verifica se a consulta retornou registros
                        DataTable dt = new DataTable(); // Cria uma Tabela Genérica e Vazia
                        dt.Load(dados); // Carrega os dados para o DataTable
                        data = Convert.ToDateTime(dt.Rows[0]["data_eleicao"].ToString());

                    }
                    else { data = Convert.ToDateTime("00/00/0000"); }

                    if (data.Date!=today.Date )
                    {
                        MessageBox.Show("O Dia da Eleição não é Hoje!!!!");
                        break;
                    }
                    
                    if (Convert.ToString(dgvEleicoes.Rows[i].Cells[5].Value) == "Finalizada")
                    {
                        MessageBox.Show("Eleição já foi Finalizada!!!!");
                        break;
                    }
                    if (Convert.ToString(dgvEleicoes.Rows[i].Cells[5].Value) == "Iniciada")
                    {
                        MessageBox.Show("Eleição já foi Iniciada!!!!");
                        break;
                    }
                    int x = ids[int.Parse(e.RowIndex.ToString())];
                    
                   cmd = new MySqlCommand("UPDATE eleicoes SET situacao =2 WHERE id =" + x, con);
                    // Executa o comando SQL e retorna o total de linhas afetadas no BD
                    cmd.ExecuteNonQuery();
                    con.Close();
                    votacao novo = new votacao(codigos[int.Parse(e.RowIndex.ToString())]);
                    this.Owner.Hide();
                    this.Hide();
                    novo.ShowDialog();
                    this.Owner.Show();
                    this.Show();
                    button2_Click(null, null);
                    button1_Click(null, null);
                    break;
                }
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 6)
                {
                    int i = e.RowIndex;
                    if (Convert.ToString(dgvEleicoes.Rows[i].Cells[6].Value) == "--")
                    {
                        MessageBox.Show("Opção não disponível!!!!");
                        break;
                    }
                    if (Convert.ToString(dgvEleicoes.Rows[i].Cells[6].Value) == "Finalizada")
                    {
                        MessageBox.Show("Opção não disponível!!!!");
                        break;
                    }
                    else
                    {

                        votacao novo = new votacao(codigos[int.Parse(e.RowIndex.ToString())]);
                        this.Owner.Hide();
                        this.Hide();
                        novo.ShowDialog();
                        this.Owner.Show();
                        this.Show();
                        button2_Click(null, null);
                        button1_Click(null, null);
                        break;
                    }
                }
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
              e.RowIndex >= 0 && e.ColumnIndex == 7)
                {
                    int i = e.RowIndex;
                    if (Convert.ToString(dgvEleicoes.Rows[i].Cells[7].Value) == "--")
                    {
                        MessageBox.Show("Eleição não foi Inicializada!!!!");
                        break;
                    }
                    if (Convert.ToString(dgvEleicoes.Rows[i].Cells[7].Value) == "Finalizada")
                    {
                        MessageBox.Show("Eleição já Finalizada!!!!");
                        break;
                    }
                    else
                    {
                        int x = ids[int.Parse(e.RowIndex.ToString())];
                        string strConexao = @"SERVER=localhost;DATABASE=trabalho_mailson;UID=root;PASSWORD=;";
                        MySqlConnection con = new MySqlConnection(strConexao);
                        con.Open(); // Abre a Conexão com o BD
                                    // Define o comando SQL (Update)
                        MySqlCommand cmd = new MySqlCommand("UPDATE eleicoes SET situacao =3 WHERE id =" + x, con);
                        // Executa o comando SQL e retorna o total de linhas afetadas no BD
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Eleição Finalizada com Sucesso!!!!");
                        button2_Click(null, null);
                        button1_Click(null, null);
                        break;
                    }

                }
            }
        }

        private void exibirEleicoes_Load_2(object sender, EventArgs e)
        {

        }
    }


}
