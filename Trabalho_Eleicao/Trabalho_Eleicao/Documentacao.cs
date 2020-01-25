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
    public partial class Documentacao : Form
    {
        public Documentacao()
        {
            InitializeComponent();
        }

        private void Documentacao_Load(object sender, EventArgs e)
        {
            lbDocumentação.Text = "Para se criar os candidatos e eleição, é necessário saber o login e senha.\n" +
                "Assim, para cadastrar um candidato, basta ir no menu Candidatos e clicar em 'Cadastrar Candidato'.\n" +
                "Preencha os dados e clique em cadastrar.\n" +
                "\n" +
                "Para se cadastrar uma eleição, basta ir no menu Eleições e clicar em 'Cadastrar Eleição'\n" +
                "Preencha os dados e vincule os candidatos à eleição.\n" +
                "Para iniciar a eleição, vá no menu Eleições e clique em 'Exibir Eleições',\n" +
                " após isso, clique em 'Iniciar Eleição' e será aberto a tela de votação. \n" +
                "\n" +
                "Os eleitores poderão votar para o candidato, branco ou de forma nula.\n" +
                "Assim que terminar a eleição, basta clicar no menu acima 'Voltar' no menu superior.\n" +
                "\n" +
                "Para finalizar a eleição, vá em exibir Eleições e clique em finalizar.\n" +
                "\n" +
                "Para ver os resultados, basta ir no menu Eleições e clicar em 'Ver Resultados'.\n" +
                "Assim, caso a eleição estiver encerrada, já será possível ver seu resultado.\n" +
                "\n" +
                "Aproveite o sistema!!";
        }
    }
}
