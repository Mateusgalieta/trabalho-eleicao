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
    public partial class exibirCandidatos : Form
    {
        public exibirCandidatos()
        {
            InitializeComponent();
        }

        public void PreencherCandidatos()
        {
            string connection = @"SERVER=localhost; DATABASE=trabalho_mailson; UID=root;PASSWORD=;";

            MySqlConnection con = new MySqlConnection(connection);

            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM pessoas", con);
                MySqlDataReader dados = cmd.ExecuteReader();

                if (dados.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dados);
                    dgvCandidatos.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Nenhum candidato encontrado!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void AtualizaDgvCandidatos()
        {
            string connection = @"SERVER=localhost; DATABASE=trabalho_mailson; UID=root;PASSWORD=;";

            MySqlConnection con = new MySqlConnection(connection);

            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM pessoas", con);
                MySqlDataReader dados = cmd.ExecuteReader();

                if (dados.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dados);
                    dgvCandidatos.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Nenhum candidato encontrado!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                con.Close();
            }
        }



        private void DgvCandidatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCandidatos.Columns[e.ColumnIndex] == dgvCandidatos.Columns["editar"])
            {

                string idCandidato = dgvCandidatos.Rows[e.RowIndex].Cells[1].Value.ToString();

                string connection = @"SERVER=localhost; DATABASE=trabalho_mailson; UID=root;PASSWORD=;";

                MySqlConnection con = new MySqlConnection(connection);
                try
                {
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM pessoas JOIN candidaturas ON candidaturas.id_pessoa=pessoas.id" +
                        " JOIN eleicoes ON eleicoes.id=candidaturas.id_pessoa WHERE eleicoes.situacao=2 AND candidaturas.id_pessoa=" + Convert.ToInt32(idCandidato), con);
                    MySqlDataReader dados = cmd.ExecuteReader();

                    if (dados.HasRows == true)
                    {
                        MessageBox.Show("O candidato não pode ser editado pois está concorrendo em uma eleição em andamento");
                    }
                    else { 
                        editarCandidato editarCandidato = new editarCandidato(idCandidato);
                        editarCandidato.Show();

                        this.Hide();
                    }

                    con.Close();

                    
                }
                catch (Exception erro2)
                {
                    MessageBox.Show(erro2.Message);
                }
            }
        }

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            var ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void ExibirCandidatos_Load(object sender, EventArgs e)
        {
            string connection = @"SERVER=localhost; DATABASE=trabalho_mailson; UID=root;PASSWORD=;";

            MySqlConnection con = new MySqlConnection(connection);

            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM pessoas", con);
                MySqlDataReader dados = cmd.ExecuteReader();

                if (dados.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dados);
                    dgvCandidatos.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Nenhum candidato encontrado!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void DgvCandidatos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgvCandidatos.Columns)
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

        private void DgvCandidatos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dgvCandidatos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
        }
    }
}
