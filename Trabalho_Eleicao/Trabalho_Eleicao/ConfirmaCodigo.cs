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
    public partial class ConfirmaCodigo : Form
    {

        string idEleicao;
        public ConfirmaCodigo()
        {
            InitializeComponent();
        }

        public ConfirmaCodigo(string idEleicao)
        {
            InitializeComponent();
            this.idEleicao = idEleicao;
        }

        private void BtnProsseguir_Click(object sender, EventArgs e)
        {

            string connection = @"SERVER=localhost;DATABASE=trabalho_mailson;UID=root;PASSWORD=;";

            MySqlConnection con = new MySqlConnection(connection);

            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT codigo FROM eleicoes WHERE codigo='" + txtCodigoEleicao.Text + "' AND id=" + idEleicao, con);
                MySqlDataReader testeCodigo = cmd.ExecuteReader();

                if (testeCodigo.HasRows)
                {
                    Resultado resultado = new Resultado(Convert.ToInt32(this.idEleicao));
                    resultado.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Código Incorreto");
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

        private void ConfirmaCodigo_Load(object sender, EventArgs e)
        {

        }
    }
}
