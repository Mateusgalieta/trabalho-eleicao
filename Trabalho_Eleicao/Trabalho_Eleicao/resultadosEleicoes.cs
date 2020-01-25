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
    public partial class resultadosEleicoes : Form
    {
        public resultadosEleicoes()
        {
            InitializeComponent();
        }

        private void ResultadosEeicoes_Load(object sender, EventArgs e)
        {
            string connection = @"SERVER=localhost;DATABASE=trabalho_mailson;UID=root;PASSWORD=1234;";

            MySqlConnection con = new MySqlConnection(connection);

            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM eleicoes", con);
                MySqlDataReader dados = cmd.ExecuteReader(); 
                if (dados.HasRows == true)
                { 
                    DataTable dt = new DataTable();
                    dt.Load(dados);

                    for (int i=0; i<dt.Rows.Count; i++) {
                        lbEleicoes.Items.Add("Título: " + dt.Rows[i]["titulo"].ToString() + " - " + "Data da Eleição: " + dt.Rows[i]["data_eleicao"].ToString() + " - " + "Status: " + dt.Rows[i]["situacao"].ToString());
                    }
                }
            }
            catch(Exception erro)
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
            string connection = @"SERVER=localhost;DATABASE=trabalho_mailson;UID=root;PASSWORD=1234;";

            MySqlConnection con = new MySqlConnection(connection);

            try
            {
                con.Open();

                lbEleicoes.Items.Clear();

                if(cbStatus.SelectedIndex == -1 && dtpInicio.Value != null && dtpFim.Value != null)
                {
                    string dataInicio = dtpInicio.Value.ToString("yyyy-MM-dd");
                    string dataFim = dtpFim.Value.ToString("yyyy-MM-dd");

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM eleicoes where data_cadastro between " + "date('"  + dataInicio + "')" + " AND " + "date('" + dataFim + "')", con);
                    MySqlDataReader dados = cmd.ExecuteReader();

                    if (dados.HasRows == true)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dados);

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            lbEleicoes.Items.Add("Título: " + dt.Rows[i]["titulo"].ToString() + " - " + "Data da Eleição: " + dt.Rows[i]["data_eleicao"].ToString() + " - " + "Status: " + dt.Rows[i]["situacao"].ToString());
                        }
                    }
                }

                if (cbStatus.SelectedIndex == 0 && dtpInicio.Value  != null && dtpFim.Value != null)
                {
                    string dataInicio = dtpInicio.Value.ToString("yyyy-MM-dd");
                    string dataFim = dtpFim.Value.ToString("yyyy-MM-dd");

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM eleicoes where situacao=1 AND data_cadastro between " + "date('" + dataInicio + "')" + " AND " + "date('" + dataFim + "')", con);
                    MySqlDataReader dados = cmd.ExecuteReader();
                    if (dados.HasRows == true)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dados);

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            lbEleicoes.Items.Add("Título: " + dt.Rows[i]["titulo"].ToString() + " - " + "Data da Eleição: " + dt.Rows[i]["data_eleicao"].ToString() + " - " + "Status: " + dt.Rows[i]["situacao"].ToString());
                        }
                    }
                }


                if (cbStatus.SelectedIndex == 1 && dtpInicio.Value != null && dtpFim.Value != null)
                {
                    string dataInicio = dtpInicio.Value.ToString("yyyy-MM-dd");
                    string dataFim = dtpFim.Value.ToString("yyyy-MM-dd");

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM eleicoes where situacao=2 AND data_cadastro between " + "date('" + dataInicio + "')" + " AND " + "date('" + dataFim + "')", con);
                    MySqlDataReader dados = cmd.ExecuteReader();
                    if (dados.HasRows == true)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dados);

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            lbEleicoes.Items.Add("Título: " + dt.Rows[i]["titulo"].ToString() + " - " + "Data da Eleição: " + dt.Rows[i]["data_eleicao"].ToString() + " - " + "Status: " + dt.Rows[i]["situacao"].ToString());
                        }
                    }
                }

                if (cbStatus.SelectedIndex == 2 && dtpInicio.Value != null && dtpFim.Value != null)
                {
                    string dataInicio = dtpInicio.Value.ToString("yyyy-MM-dd");
                    string dataFim = dtpFim.Value.ToString("yyyy-MM-dd");

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM eleicoes where situacao=3 AND data_cadastro between " + "date('" + dataInicio + "')" + " AND " + "date('" + dataFim + "')", con);
                    MySqlDataReader dados = cmd.ExecuteReader();
                    if (dados.HasRows == true)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dados);

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            lbEleicoes.Items.Add("Título: " + dt.Rows[i]["titulo"].ToString() + " - " + "Data da Eleição: " + dt.Rows[i]["data_eleicao"].ToString() + " - " + "Status: " + dt.Rows[i]["situacao"].ToString());
                        }
                    }
                }

                if (cbStatus.SelectedIndex == 3 && dtpInicio.Value != null && dtpFim.Value != null)
                {
                    string dataInicio = dtpInicio.Value.ToString("yyyy-MM-dd");
                    string dataFim = dtpFim.Value.ToString("yyyy-MM-dd");

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM eleicoes where situacao=4 AND data_cadastro between " + "date('" + dataInicio + "')" + " AND " + "date('" + dataFim + "')", con);
                    MySqlDataReader dados = cmd.ExecuteReader();
                    if (dados.HasRows == true)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dados);

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            lbEleicoes.Items.Add("Título: " + dt.Rows[i]["titulo"].ToString() + " - " + "Data da Eleição: " + dt.Rows[i]["data_eleicao"].ToString() + " - " + "Status: " + dt.Rows[i]["situacao"].ToString());
                        }
                    }
                }

                if (cbStatus.SelectedIndex == 0)
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM eleicoes where situacao=1", con);
                    MySqlDataReader dados = cmd.ExecuteReader();
                    if (dados.HasRows == true)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dados);

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            lbEleicoes.Items.Add("Título: " + dt.Rows[i]["titulo"].ToString() + " - " + "Data da Eleição: " + dt.Rows[i]["data_eleicao"].ToString() + " - " + "Status: " + dt.Rows[i]["situacao"].ToString());
                        }
                    }
                }

                if (cbStatus.SelectedIndex == 1)
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM eleicoes where situacao=2", con);
                    MySqlDataReader dados = cmd.ExecuteReader();
                    if (dados.HasRows == true)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dados);

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            lbEleicoes.Items.Add("Título: " + dt.Rows[i]["titulo"].ToString() + " - " + "Data da Eleição: " + dt.Rows[i]["data_eleicao"].ToString() + " - " + "Status: " + dt.Rows[i]["situacao"].ToString());
                        }
                    }
                }

                if (cbStatus.SelectedIndex == 2)
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM eleicoes where situacao=3", con);
                    MySqlDataReader dados = cmd.ExecuteReader();
                    if (dados.HasRows == true)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dados);

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            lbEleicoes.Items.Add("Título: " + dt.Rows[i]["titulo"].ToString() + " - " + "Data da Eleição: " + dt.Rows[i]["data_eleicao"].ToString() + " - " + "Status: " + dt.Rows[i]["situacao"].ToString());
                        }
                    }
                }

                if (cbStatus.SelectedIndex == 3)
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM eleicoes where situacao=4", con);
                    MySqlDataReader dados = cmd.ExecuteReader();
                    if (dados.HasRows == true)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dados);

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            lbEleicoes.Items.Add("Título: " + dt.Rows[i]["titulo"].ToString() + " - " + "Data da Eleição: " + dt.Rows[i]["data_eleicao"].ToString() + " - " + "Status: " + dt.Rows[i]["situacao"].ToString());
                        }
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
    }
}
