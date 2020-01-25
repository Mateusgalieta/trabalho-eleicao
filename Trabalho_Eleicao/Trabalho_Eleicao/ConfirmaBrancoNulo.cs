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

namespace Trabalho_Eleicao
{
    public partial class ConfirmaBrancoNulo : Form
    { string voto2, id2;
        public ConfirmaBrancoNulo(string voto, string id)
        {
            InitializeComponent();
            if (voto == "Branco")
                label1.Text = "Voto Branco!!!!";
            else
                label1.Text = "Voto Nulo!!!!";
            voto2 = voto;
            id2 = id;
        }

        private void ConfirmaBrancoNulo_Load(object sender, EventArgs e)
        {

        }

        private void ConfirmaBrancoNulo_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.N)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.S)
            {
                    string strConexao = @"SERVER=localhost;DATABASE=trabalho_mailson;UID=root;PASSWORD=;";
                    MySqlConnection con = new MySqlConnection(strConexao);
                    con.Open(); // Abre a conexão com o BD
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO votos(valor_digitado, id_eleicao) VALUES(@valor_digitado," +
                        "@id_eleicao)", con); // Define o comando SQL
                    cmd.Parameters.AddWithValue("@valor_digitado", voto2);
                    cmd.Parameters.AddWithValue("@id_eleicao", id2);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    this.Close();
                    Fim teste2 = new Fim();
                    teste2.ShowDialog();
              

            }
        }
    }
}
