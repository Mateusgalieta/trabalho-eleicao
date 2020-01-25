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
    public partial class CadastroCandidato : Form
    {
        public CadastroCandidato()
        {
            InitializeComponent();
        }


        public struct Candidato
        {
            public string nome_completo;
            public string nome_abreviado;
            public DateTime data_nascimento;
            public byte[] foto;
            public int numero_partido;
            public string nome_partido;
        }

        public byte[] ImageToByteArray(Image imageIn)
        {
            var ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }


        private void BtnImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            file.Filter = "JPG Files(*.jpg) |*.jpg|PNG Files(*.png)|*.png|AllFiles(*.*)|*.*";

            if(file.ShowDialog() == DialogResult.OK)
            {
                string foto = file.FileName.ToString();
                txtImagem.Text = foto;
                pbFotoCandidato.ImageLocation = foto;
            }
        }

        private void BtnCadastrarCandidato_Click(object sender, EventArgs e)
        {
            string connection = @"SERVER=localhost;DATABASE=trabalho_mailson;UID=root;PASSWORD=;";

            MySqlConnection con = new MySqlConnection(connection);

            try
            {
                con.Open();

                MySqlCommand consult = new MySqlCommand("SELECT * FROM pessoas WHERE numero_partido='" + txtNumeroPartido.Text + "' AND nome_partido='" + txtNomePartido.Text + "';", con);
                MySqlDataReader dados = consult.ExecuteReader();

                if (dados.HasRows == true)
                {
                    con.Close();
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO pessoas(nome_completo, nome_abreviado, data_nascimento, numero_partido, nome_partido, foto) VALUES(@nome_completo, @nome_abreviado, @data_nascimento, @numero_partido, @nome_partido, @foto)", con);

                    cmd.Parameters.AddWithValue("@nome_completo", txtNomeCompleto.Text);
                    cmd.Parameters.AddWithValue("@nome_abreviado", txtNomeAbreviado.Text);
                    cmd.Parameters.AddWithValue("@data_nascimento", DateTime.Parse(txtDataNascimento.Text));
                    cmd.Parameters.AddWithValue("@numero_partido", txtNumeroPartido.Text);
                    cmd.Parameters.AddWithValue("@nome_partido", txtNomePartido.Text);
                    cmd.Parameters.AddWithValue("@foto", ImageToByteArray(pbFotoCandidato.Image));
                    cmd.ExecuteNonQuery();

                    txtNomeCompleto.Text = "";
                    txtNomeAbreviado.Text = "";
                    txtDataNascimento.Text = "";
                    txtNumeroPartido.Text = "";
                    txtNomePartido.Text = "";
                    txtImagem.Text = "";
                    pbFotoCandidato.Image = null;

                    MessageBox.Show("Candidato cadastrado com sucesso! ");

                    con.Close();
                }
                else
                {
                    con.Close();
                }

                con.Open();

                MySqlCommand verifica = new MySqlCommand("SELECT * FROM pessoas WHERE (numero_partido='" + txtNumeroPartido.Text + "' OR nome_partido='" + txtNomePartido.Text + "') AND (numero_partido <> '" + txtNumeroPartido.Text + "' OR nome_partido <> '" + txtNomePartido.Text + "');", con);
                MySqlDataReader verificaDados = verifica.ExecuteReader();

                if (verificaDados.HasRows == true)
                {
                    MessageBox.Show("O número o partido e o nome do partido precisam ser o mesmo de um existente, ou você pode cadastrar um novo candidato com um novo partido.");

                    con.Close();
                }
                else
                {
                    con.Close();
                }

                con.Open();

                MySqlCommand naoExiste = new MySqlCommand("SELECT * FROM pessoas WHERE (numero_partido='" + txtNumeroPartido.Text + "' OR nome_partido='" + txtNomePartido.Text + "') OR (numero_partido='" + txtNumeroPartido.Text + "' AND nome_partido='" + txtNomePartido.Text + "');", con);
                MySqlDataReader naoExiste1 = naoExiste.ExecuteReader();

                if (naoExiste1.HasRows == false)
                {
                    con.Close();
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO pessoas(nome_completo, nome_abreviado, data_nascimento, numero_partido, nome_partido, foto) VALUES(@nome_completo, @nome_abreviado, @data_nascimento, @numero_partido, @nome_partido, @foto)", con);

                    cmd.Parameters.AddWithValue("@nome_completo", txtNomeCompleto.Text);
                    cmd.Parameters.AddWithValue("@nome_abreviado", txtNomeAbreviado.Text);
                    cmd.Parameters.AddWithValue("@data_nascimento", DateTime.Parse(txtDataNascimento.Text));
                    cmd.Parameters.AddWithValue("@numero_partido", txtNumeroPartido.Text);
                    cmd.Parameters.AddWithValue("@nome_partido", txtNomePartido.Text);
                    cmd.Parameters.AddWithValue("@foto", ImageToByteArray(pbFotoCandidato.Image));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Candidato cadastrado com sucesso! ");

                    this.Close();

                    con.Close();
                }
                else
                {
                    con.Close();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Tudo certo, candidato cadastrado! Agora você já pode utilizar o candidato em uma eleição!");
            }
        }

        private void CadastroCandidato_Load(object sender, EventArgs e)
        {

        }
    }
}
