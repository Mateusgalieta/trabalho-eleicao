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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            int r = 0;
          
                if (txtLogin.Text == "Admin" && txtSenha.Text == "europa")
                {


                    string strConexao = @"SERVER=localhost; DATABASE=trabalho_mailson; UID=root;PASSWORD=;";
                    // Cria a conexão com o BD

                    MySqlConnection con = new MySqlConnection(strConexao);
                    try
                    {
                        con.Open();
                    con.Close();
                    Backoffice Backoffice = new Backoffice();
                    this.Hide();
                    Backoffice.Closed += (s, args) => this.Close();
                    Backoffice.Show();

                }
                    catch (Exception erro)
                    {
                        MessageBox.Show("O programa não pode se conectar com o banco de dados!!!");
                        
                    }


                }

                else
                {
                    MessageBox.Show("Login ou senha incorretos!!!");
                    txtLogin.Text = null;
                    txtSenha.Text = null;
                 
                }
            }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
