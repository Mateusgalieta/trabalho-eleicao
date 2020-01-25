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
    public partial class resultadoEleicoes : Form
    {
        public resultadoEleicoes()
        {
            InitializeComponent();
        }

        private void ResultadoEleicoes_Load(object sender, EventArgs e)
        {
            string connection = @"SERVER=localhost;DATABASE=trabalho_mailson;UID=root;PASSWORD=;";

            MySqlConnection con = new MySqlConnection(connection);

            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT id ,titulo, data_eleicao FROM eleicoes WHERE situacao=3", con);
                MySqlDataReader dados = cmd.ExecuteReader();
                if (dados.HasRows == true)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dados);
                    dgvEleicoes.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Não existe nenhuma eleicão encerrada no momento!");
                }
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

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            string connection = @"SERVER=localhost;DATABASE=trabalho_mailson;UID=root;PASSWORD=;";

            MySqlConnection con = new MySqlConnection(connection);

            try
            {
                con.Open();

                dgvEleicoes.DataSource = null;

                if (dtpInicio.Value != null && dtpFim.Value != null)
                {
                    string dataInicio = dtpInicio.Value.ToString("yyyy-MM-dd");
                    string dataFim = dtpFim.Value.ToString("yyyy-MM-dd");

                    MySqlCommand cmd = new MySqlCommand("SELECT id ,titulo, data_eleicao FROM eleicoes where situacao=3 AND data_eleicao between " + "date('" + dataInicio + "')" + " AND " + "date('" + dataFim + "')", con);
                    MySqlDataReader dados = cmd.ExecuteReader();

                    if (dados.HasRows == true)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dados);
                        dgvEleicoes.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("Não existe nenhuma eleição com status de encerrada nesse intervalo de data");
                    }
                }
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

        private void DgvEleicoes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn coluna in dgvEleicoes.Columns)
            {
                switch (coluna.Name)
                {
                    case "id":
                        coluna.Visible = false;
                        break;
                    case "titulo":
                        coluna.HeaderText = "Título";
                        break;
                    case "data_eleicao":
                        coluna.HeaderText = "Data da Eleição";
                        break;
                    case "verResultado":
                        coluna.DisplayIndex = 3;
                        break;
                }
            }
        }

        private void DgvEleicoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEleicoes.Columns[e.ColumnIndex] == dgvEleicoes.Columns["verResultado"])
            {
                string idEleicao = dgvEleicoes.Rows[e.RowIndex].Cells[1].Value.ToString();

                ConfirmaCodigo confirmaCodigo = new ConfirmaCodigo(idEleicao);
                confirmaCodigo.Show();
            }
        }
    }
}
