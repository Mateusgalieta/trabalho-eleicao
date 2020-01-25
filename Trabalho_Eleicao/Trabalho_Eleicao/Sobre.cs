using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_Eleicao
{
    public partial class Sobre : Form
    {
        public Sobre()
        {
            InitializeComponent();
        }

        private void Sobre_Load(object sender, EventArgs e)
        {
            lbSobre.Text = "Esse sistema tem como objetivo, fornecer uma solução para votação na região política do Mercosul. \n" +
                "Através de registros de candidados, é possível criar uma eleição, preenhcendo seus dados \n" +
                "e vincular" +
                " os candidatos participantes. \n" +
                "Assim, é possível iniciar a eleição e finalizá-la, obtendo assim os resultados, no qual apenas \nquem possui cadastro de Administrador " +
                "pode acessar. \n" +
                "\n" +
                "\n" +
                "Esse trabalho é um trabalho para a disciplina de Programação 2, \n" +
                "no 4° Período de Sistemas de Informação - 2019\n" +
                "\n" +
                "\n" +
                "UEMG - Universidade do Estado de Minas Gerais - Unidade Passos" +
                "\n" +
                "\n" +
                "Alunos: Mateus Augusto Galieta Cruz e Pedro Henrique Ferreira Lemos.";
        }
    }
}
