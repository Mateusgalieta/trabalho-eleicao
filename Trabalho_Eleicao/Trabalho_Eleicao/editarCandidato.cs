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
    public partial class editarCandidato : Form
    {
        string idCandidato;
        public editarCandidato(string id)
        {
            InitializeComponent();
            this.idCandidato = id;
        }

        public byte[] ImageToByteArray(Image imageIn)
        {
            var ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            var ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void EditarCandidato_Load(object sender, EventArgs e)
        {
            string connection = @"SERVER=localhost;DATABASE=trabalho_mailson;UID=root;PASSWORD=;";

            MySqlConnection con = new MySqlConnection(connection);

            try
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM pessoas where id=" + this.idCandidato, con);
                MySqlDataReader dados = cmd.ExecuteReader();

                if (dados.HasRows == true)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dados);

                    txtNomeCompleto.Text = dt.Rows[0]["nome_completo"].ToString();
                    txtNomeAbreviado.Text = dt.Rows[0]["nome_abreviado"].ToString();
                    txtDataNascimento.Text = dt.Rows[0]["data_nascimento"].ToString();
                    txtNomePartido.Text = dt.Rows[0]["nome_partido"].ToString();
                    txtNumeroPartido.Text = dt.Rows[0]["numero_partido"].ToString();
                    pbFotoCandidato.Image = ByteArrayToImage((byte[])dt.Rows[0]["foto"]);
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

        private void BtnEditarCandidato_Click(object sender, EventArgs e)
        {
            string connection = @"SERVER=localhost;DATABASE=trabalho_mailson;UID=root;PASSWORD=;";

            MySqlConnection con = new MySqlConnection(connection);

            try
            {
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

                MySqlCommand consult = new MySqlCommand("SELECT * FROM pessoas WHERE numero_partido='" + txtNumeroPartido.Text + "' AND nome_partido='" + txtNomePartido.Text + "';", con);
                MySqlDataReader dados = consult.ExecuteReader();

                if (dados.HasRows == true)
                {
                    con.Close();
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("UPDATE pessoas SET nome_completo=@nome_completo, nome_abreviado=@nome_abreviado, data_nascimento=@data_nascimento, nome_partido=@nome_partido, numero_partido=@numero_partido, foto=@foto WHERE id=@id", con);
                    cmd.Parameters.AddWithValue("@nome_completo", txtNomeCompleto.Text);
                    cmd.Parameters.AddWithValue("@nome_abreviado", txtNomeAbreviado.Text);
                    cmd.Parameters.AddWithValue("@data_nascimento", DateTime.Parse(txtDataNascimento.Text));
                    cmd.Parameters.AddWithValue("@numero_partido", txtNumeroPartido.Text);
                    cmd.Parameters.AddWithValue("@nome_partido", txtNomePartido.Text);
                    cmd.Parameters.AddWithValue("@foto", ImageToByteArray(pbFotoCandidato.Image));
                    cmd.Parameters.AddWithValue("@id", this.idCandidato);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Candidato atualizado com sucesso!");

                    con.Close();

                    exibirCandidatos exibirCandidatos = new exibirCandidatos();

                    exibirCandidatos.Show();
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

                    MySqlCommand cmd = new MySqlCommand("UPDATE pessoas SET nome_completo=@nome_completo, nome_abreviado=@nome_abreviado, data_nascimento=@data_nascimento, nome_partido=@nome_partido, numero_partido=@numero_partido, foto=@foto WHERE id=@id", con);
                    cmd.Parameters.AddWithValue("@nome_completo", txtNomeCompleto.Text);
                    cmd.Parameters.AddWithValue("@nome_abreviado", txtNomeAbreviado.Text);
                    cmd.Parameters.AddWithValue("@data_nascimento", DateTime.Parse(txtDataNascimento.Text));
                    cmd.Parameters.AddWithValue("@numero_partido", txtNumeroPartido.Text);
                    cmd.Parameters.AddWithValue("@nome_partido", txtNomePartido.Text);
                    cmd.Parameters.AddWithValue("@foto", ImageToByteArray(pbFotoCandidato.Image));
                    cmd.Parameters.AddWithValue("@id", this.idCandidato);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Candidato editado com sucesso!");

                    con.Close();

                    this.Close();

                    exibirCandidatos exibirCandidatos = new exibirCandidatos();

                    exibirCandidatos.Show();
                }
                else
                {
                    con.Close();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Tudo certo, candidato atualizado! Agora você já pode utilizar o candidato em uma eleição!");
            }
        }

        private void BtnImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            file.Filter = "JPG Files(*.jpg) |*.jpg|PNG Files(*.png)|*.png|AllFiles(*.*)|*.*";

            if (file.ShowDialog() == DialogResult.OK)
            {
                string foto = file.FileName.ToString();
                txtImagem.Text = foto;
                pbFotoCandidato.ImageLocation = foto;
            }
        }
    }
}
