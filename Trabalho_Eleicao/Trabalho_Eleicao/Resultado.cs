using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Trabalho_Eleicao
{
    public partial class Resultado : Form
    {
        int idEleicao;

        public Resultado()
        {
            InitializeComponent();
        }

        public Resultado(int idEleicao)
        {
            InitializeComponent();
            this.idEleicao = idEleicao;
        }

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            var ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void Resultado_Load(object sender, EventArgs e)
        {
            string connection = @"SERVER=localhost;DATABASE=trabalho_mailson;UID=root;PASSWORD=;";

            MySqlConnection con = new MySqlConnection(connection);

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT pessoas.id, numero_partido, nome_completo, nome_partido, (select count(*) from votos where votos.id_eleicao=" + idEleicao + " AND votos.valor_digitado=numero_partido) AS quantidade_votos FROM pessoas INNER JOIN candidaturas ON pessoas.id=candidaturas.id_pessoa INNER JOIN eleicoes ON eleicoes.id = candidaturas.id_eleicao INNER JOIN votos ON eleicoes.id = votos.id_eleicao where candidaturas.id_eleicao=" + idEleicao + " GROUP BY nome_completo ORDER BY quantidade_votos DESC", con);
                MySqlDataReader dados = cmd.ExecuteReader();

                if (dados.HasRows == true)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dados);
                    dgvResultado.DataSource = dt;
                }

                con.Close();

                con.Open();

                MySqlCommand totalVotos = new MySqlCommand("SELECT count(*) AS votos_total FROM votos WHERE votos.id_eleicao=" + idEleicao, con);
                MySqlDataReader VerificaTotalVotos = totalVotos.ExecuteReader();

                string cont = "0";

                if (VerificaTotalVotos.HasRows)
                {
                    DataTable calculaTotal = new DataTable();
                    calculaTotal.Load(VerificaTotalVotos);
                    cont = calculaTotal.Rows[0]["votos_total"].ToString();
                }

                con.Close();

                con.Open();

                MySqlCommand consultaBranco = new MySqlCommand("SELECT count(*) AS total_brancos from votos where valor_digitado='Branco' AND votos.id_eleicao=" + idEleicao, con);
                MySqlDataReader votosBrancos = consultaBranco.ExecuteReader();

                string total_brancos = "0";

                if (votosBrancos.HasRows)
                {
                    DataTable calculabrancos = new DataTable();
                    calculabrancos.Load(votosBrancos);
                    total_brancos = calculabrancos.Rows[0]["total_brancos"].ToString();
                }

                con.Close();

                con.Open();

                MySqlCommand consultaNulos = new MySqlCommand("SELECT count(*) AS total_nulos from votos where valor_digitado not in (select numero_partido FROM pessoas INNER JOIN candidaturas ON candidaturas.id_pessoa = pessoas.id INNER JOIN eleicoes ON candidaturas.id_eleicao = eleicoes.id where eleicoes.id ="+ idEleicao + ") AND votos.id_eleicao=" + idEleicao + " AND votos.valor_digitado <> 'Branco' ", con);
                MySqlDataReader votosNulos = consultaNulos.ExecuteReader();

                string total_nulos = "0";

                if (votosNulos.HasRows)
                {
                    DataTable calculaNulos = new DataTable();
                    calculaNulos.Load(votosNulos);
                    total_nulos = calculaNulos.Rows[0]["total_nulos"].ToString();
                }

                con.Close();



                con.Open();

                MySqlCommand consultarVencedor = new MySqlCommand("SELECT pessoas.id AS id, numero_partido, foto, nome_completo, nome_partido, (select count(*) from votos where votos.id_eleicao="+ idEleicao + " AND votos.valor_digitado=numero_partido) AS quantidade_votos FROM pessoas INNER JOIN candidaturas ON pessoas.id=candidaturas.id_pessoa INNER JOIN eleicoes ON eleicoes.id = candidaturas.id_eleicao INNER JOIN votos ON eleicoes.id = votos.id_eleicao where candidaturas.id_eleicao=" + idEleicao + " GROUP BY nome_completo ORDER BY quantidade_votos DESC", con);
                MySqlDataReader vencedor = consultarVencedor.ExecuteReader();

                string quantidade_vencedor = "";
                string nomeVencedor = "";
                


                if (vencedor.HasRows)
                {
                    DataTable dadosVencedor = new DataTable();
                    dadosVencedor.Load(vencedor);
                    quantidade_vencedor = dadosVencedor.Rows[0]["quantidade_votos"].ToString();
                    nomeVencedor = dadosVencedor.Rows[0]["nome_completo"].ToString();
                    string idVencedor = dadosVencedor.Rows[0]["id"].ToString();

                    if (Convert.ToInt32(quantidade_vencedor) > (Convert.ToInt32(cont) / 2) && Convert.ToInt32(quantidade_vencedor) > Convert.ToInt32(total_nulos) && Convert.ToInt32(quantidade_vencedor) > Convert.ToInt32(total_brancos))
                    {
                        Vencedor vencedor1 = new Vencedor(idVencedor, nomeVencedor);
                        vencedor1.Show();
                    }
                    else if(Convert.ToInt32(total_nulos) > (Convert.ToInt32(cont) / 2) || Convert.ToInt32(total_brancos) > (Convert.ToInt32(cont) / 2))
                    {
                        MessageBox.Show("Não obteve vencedor, pois mais da metade dos eleitores votaram Branco ou Nulo. Será necessário uma nova eleição");
                        nomeVencedor = "Não houve Vencedor!";
                    }
                    else if(Convert.ToInt32(quantidade_vencedor) < (Convert.ToInt32(cont) / 2))
                    {
                        MessageBox.Show("Nenhum candidato obteve mais que 50% dos votos. Será necessário uma nova eleição com os seguintes candidatos: " + dadosVencedor.Rows[0]["nome_completo"].ToString() + " e " + dadosVencedor.Rows[1]["nome_completo"].ToString());
                    }
                }

                con.Close();


                con.Open();

                MySqlCommand consultaEleicao = new MySqlCommand("SELECT titulo FROM eleicoes WHERE id=" + idEleicao, con);
                MySqlDataReader executaBuscaEleicao = consultaEleicao.ExecuteReader();

                string titulo = "";

                if (executaBuscaEleicao.HasRows)
                {
                    DataTable dadosEleicoes = new DataTable();
                    dadosEleicoes.Load(executaBuscaEleicao);
                    titulo = dadosEleicoes.Rows[0]["titulo"].ToString();
                }

                con.Close();


                vlTitulo.Text = titulo;
                vlVencedor.Text = nomeVencedor;
                vlTotalVotos.Text = cont;
                vlTotalBrancos.Text = total_brancos;
                vlTotalNulos.Text = total_nulos;
                

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void DgvResultado_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgvResultado.Columns)
            {
                switch (coluna.Name)
                {
                    case "id":
                        coluna.Visible = false;
                        break;
                    case "nome_completo":
                        coluna.HeaderText = "Nome Completo";
                        break;
                    case "nome_abreviado":
                        coluna.HeaderText = "Nome Abreviado";
                        break;
                    case "data_nascimento":
                        coluna.HeaderText = "Data de Nascimento";
                        break;
                    case "numero_partido":
                        coluna.HeaderText = "Número do Partido";
                        break;
                    case "nome_partido":
                        coluna.HeaderText = "Nome de Partido";
                        break;
                    case "quantidade_votos":
                        coluna.HeaderText = "Quantidade de votos";
                        break;
                    case "foto":
                        coluna.HeaderText = "Foto";
                        coluna.DisplayIndex = 1;
                        break;
                    case "editar":
                        coluna.DisplayIndex = 7;
                        break;
                }
            }
        }
    }
}
