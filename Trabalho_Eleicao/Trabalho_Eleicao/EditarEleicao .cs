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
    public partial class EditarEleicao : Form
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
        List<candidatura> listaC = new List<candidatura>();
        List<int> votos = new List<int>();
        Candidato y;
        string codigo;
        public EditarEleicao(string z)
        {
            codigo = z;
            InitializeComponent();
            Candidato x;
            string id;
            string numero;
            string y;
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
            for (int w = 0; w < lista.Count; w++)
            {

                dgvCandidatos.Rows.Add();

                dgvCandidatos.Rows[w].Cells[1].Value = lista[w].nome_completo;
                dgvCandidatos.Rows[w].Cells[2].Value = lista[w].nome_partido;
                dgvCandidatos.Rows[w].Cells[3].Value = lista[w].numero_partido;


            }



            cmd = new MySqlCommand("select * from eleicoes where codigo='" + z + "'", con);
            cmd.ExecuteNonQuery();
            MySqlDataReader dados3 = cmd.ExecuteReader();
            if (dados3.HasRows == true)
            {

                string numerocombo;
                DataTable dt = new DataTable(); // Cria uma Tabela Genérica e Vazia
                dt.Load(dados3); // Carrega os dados para o DataTable
                txtCodigo.Text = dt.Rows[0]["codigo"].ToString();
                txtTitulo.Text = dt.Rows[0]["titulo"].ToString();
                maskedTextBox1.Text = dt.Rows[0]["data_cadastro"].ToString();
                txtDataEleicao.Text = dt.Rows[0]["data_eleicao"].ToString();
                numerocombo = dt.Rows[0]["pais"].ToString();
                comboBox1.SelectedIndex = int.Parse(numerocombo) - 1;
                id = dt.Rows[0]["id"].ToString();
            }
            else
            {
                id = "erro";
            }
            string c;

            cmd = new MySqlCommand("select count(*) from candidaturas where id_eleicao=" + int.Parse(id), con);
            MySqlDataReader dados4 = cmd.ExecuteReader(); // Executa a consulta
            if (dados4.HasRows == true)
            { // Verifica se a consulta retornou registros
                DataTable dt = new DataTable(); // Cria uma Tabela Genérica e Vazia
                dt.Load(dados4); // Carrega os dados para o DataTable

                c = dt.Rows[0]["count(*)"].ToString();
            }
            else
            {
                c = "0";
            }
            for (int i = 0; i < int.Parse(c); i++)
            {
                candidatura t;
                cmd = new MySqlCommand("select * from candidaturas where id_eleicao=" + int.Parse(id), con);
                cmd.ExecuteNonQuery();
                MySqlDataReader dados5 = cmd.ExecuteReader();
                if (dados5.HasRows == true)
                { // Verifica se a consulta retornou registros


                    DataTable dt = new DataTable(); // Cria uma Tabela Genérica e Vazia
                    dt.Load(dados5); // Carrega os dados para o DataTable
                    t.id_eleicao = dt.Rows[i]["id_eleicao"].ToString();
                    t.id_pessoa = dt.Rows[i]["id_pessoa"].ToString();
                    listaC.Add(t);
                }
            }
            for (int e = 0; e < listaC.Count; e++)
            {
                cmd = new MySqlCommand("select nome_completo from pessoas where id=" + int.Parse(listaC[e].id_pessoa), con);
                cmd.ExecuteNonQuery();
                MySqlDataReader dados6 = cmd.ExecuteReader();
                if (dados6.HasRows == true)
                {
                    DataTable dt = new DataTable(); // Cria uma Tabela Genérica e Vazia
                    dt.Load(dados6); // Carrega os dados para o DataTable

                    if (Convert.ToString(dgvCandidatos.Rows[e].Cells[1].Value) == dt.Rows[0]["nome_completo"].ToString())

                        dgvCandidatos.Rows[e].Cells[0].Value = true;


                }
            }

            con.Close();
        }





        private void button1_Click(object sender, EventArgs e)
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
                if (String.IsNullOrEmpty(txtCodigo.Text) || String.IsNullOrEmpty(txtDataEleicao.Text) || String.IsNullOrEmpty(maskedTextBox1.Text)
                    || String.IsNullOrEmpty(txtTitulo.Text) || comboBox1.SelectedIndex == -1)
                {

                    MessageBox.Show("Preencha todos os campos!!!");
                    break;
                }
                DateTime temp;
                if (DateTime.TryParse(maskedTextBox1.Text, out temp))
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
                            int cont = 0;
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {

                                if (txtCodigo.Text == dt.Rows[i]["codigo"].ToString() && txtCodigo.Text != codigo)
                                {
                                    cont++;

                                    
                                }
                                if (txtCodigo.Text == codigo)
                                {
                                    cont++;
                                }
                            }
                            if (cont == 1)
                            {
                                MessageBox.Show("Este código já foi registrado. Insira outro!!!");
                                con.Close();
                                break;
                            }

                            else { con.Close(); }
                        }
                        con.Close();
                    }





                }
                if (!String.IsNullOrEmpty(txtTitulo.Text))
                {
                    int u = 0;
                    string strConexao = @"SERVER=localhost;DATABASE=trabalho_mailson;UID=root;PASSWORD=;";
                    MySqlConnection con = new MySqlConnection(strConexao);
                    con.Open(); // Abre a conexão com o BD
                    MySqlCommand cmd = new MySqlCommand("select titulo, codigo from eleicoes", con);
                    MySqlDataReader dados = cmd.ExecuteReader(); // Executa a consulta
                    if (dados.HasRows == true)
                    { // Verifica se a consulta retornou registros
                        DataTable dt = new DataTable(); // Cria uma Tabela Genérica e Vazia
                        dt.Load(dados); // Carrega os dados para o DataTable

                        for (int i = 0; i < dt.Rows.Count; i++)
                        { if (txtTitulo.Text == dt.Rows[i]["titulo"].ToString() && codigo == dt.Rows[i]["codigo"].ToString())
                            {
                                u = 0;
                            }
                            if (txtTitulo.Text == dt.Rows[i]["titulo"].ToString() && codigo != dt.Rows[i]["codigo"].ToString())
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
                    int id_eleicao;
                    int pais = 0;

                    DateTime data = Convert.ToDateTime(txtDataEleicao.Text);

                    if (comboBox1.SelectedIndex > -1)
                    {
                        if (comboBox1.SelectedIndex == 0)
                        {
                            pais = 1;
                        }

                        if (comboBox1.SelectedIndex == 1)
                        {
                            pais = 2;
                        }

                        if (comboBox1.SelectedIndex == 2)
                        {
                            pais = 3;
                        }

                        if (comboBox1.SelectedIndex == 3)
                        {
                            pais = 4;
                        }


                    }

                    // Define a Str de Conexão
                    string strConexao = @"SERVER=localhost;DATABASE=trabalho_mailson;UID=root;PASSWORD=;";
                    // Cria a conexão com o BD
                    MySqlConnection con = new MySqlConnection(strConexao);
                    con.Open(); // Abre a conexão com o BD
                    MySqlCommand cmd = new MySqlCommand("SELECT id FROM eleicoes where codigo='" + codigo + "'", con);
                    MySqlDataReader dados = cmd.ExecuteReader(); // Executa a consulta
                    if (dados.HasRows == true)
                    { // Verifica se a consulta retornou registros
                        DataTable dt = new DataTable(); // Cria uma Tabela Genérica e Vazia
                        dt.Load(dados); // Carrega os dados para o DataTable
                        id_eleicao = int.Parse(dt.Rows[0]["id"].ToString());

                    }

                    else { id_eleicao = 0; }

                    cmd = new MySqlCommand("Update eleicoes set codigo='" + txtCodigo.Text.ToString() + "',titulo ='" + txtTitulo.Text
                        + "',data_eleicao='" + data.Year.ToString() + "-" + data.Month.ToString() + "-" + data.Day.ToString() + "', pais=" + pais + " where id=" + id_eleicao, con);
                    cmd.ExecuteNonQuery();
                    cmd = new MySqlCommand("delete from candidaturas where id_eleicao=" + id_eleicao, con);
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
                        MySqlDataReader dados2 = cmd.ExecuteReader();
                        if (dados2.HasRows == true)
                        { // Verifica se a consulta retornou registros
                            DataTable dt = new DataTable(); // Cria uma Tabela Genérica e Vazia
                            dt.Load(dados2); // Carrega os dados para o DataTable
                            teste.id_pessoa = dt.Rows[0]["id"].ToString();
                        }
                        else { teste.id_pessoa = "erro"; }
                        cmd = new MySqlCommand("select id from eleicoes where codigo ='" + txtCodigo.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        MySqlDataReader dados3 = cmd.ExecuteReader();
                        if (dados3.HasRows == true)
                        { // Verifica se a consulta retornou registros
                            DataTable dt = new DataTable(); // Cria uma Tabela Genérica e Vazia
                            dt.Load(dados3); // Carrega os dados para o DataTable
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
                    maskedTextBox1.Text = null;
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
                    MessageBox.Show("Eleição Atualizada com Sucesso!!!");
                    r++;
                    this.Close();

                }
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

        private void EditarEleicao_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
