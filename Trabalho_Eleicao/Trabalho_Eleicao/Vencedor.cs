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
    public partial class Vencedor : Form
    {
        string nome;
        Image foto;
        string id;

        public Vencedor()
        {
            InitializeComponent();
        } 

        public Vencedor(string id, string nome)
        {
            InitializeComponent();
            this.nome = nome;
            this.id = id;
        }

        private void Vencedor_Load(object sender, EventArgs e)
        {
            try { 

                string connection = @"SERVER=localhost;DATABASE=trabalho_mailson;UID=root;PASSWORD=;";

                MySqlConnection con = new MySqlConnection(connection);

                lbVencedor.Text = this.nome;

                con.Open();

                MySqlCommand consultaFoto = new MySqlCommand("SELECT foto FROM pessoas WHERE id=" + this.id, con);
                MySqlDataReader executaBusca = consultaFoto.ExecuteReader();

                if (executaBusca.HasRows)
                {
                    DataTable dadosfoto = new DataTable();
                    dadosfoto.Load(executaBusca);
                    pbFoto.Image = new Resultado().ByteArrayToImage((byte[])dadosfoto.Rows[0]["foto"]);
                }

                con.Close();
            }
            catch(Exception erro3)
            {
                MessageBox.Show(erro3.Message);
            }
        }
    }
}
