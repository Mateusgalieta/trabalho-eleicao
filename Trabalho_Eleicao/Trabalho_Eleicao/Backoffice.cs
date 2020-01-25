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
    public partial class Backoffice : Form
    {
        public Backoffice()
        {
            InitializeComponent();
        }

        private void CadastrarEleiçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EleiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarEleiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroEleicao cadastroEleicao = new CadastroEleicao();

            cadastroEleicao.Show();
        }

        private void CadastrarCandidatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCandidato cadastroCandidato = new CadastroCandidato();

            cadastroCandidato.Show();
        }

        private void ExibirEleiçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exibirEleicoes exibirEleicoes = new exibirEleicoes();
            exibirEleicoes.Owner = this;
            exibirEleicoes.Show();
        }

        private void ExibirCandidatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exibirCandidatos exibirCandidatos = new exibirCandidatos();

            exibirCandidatos.Show();
        }

        private void Backoffice_Load(object sender, EventArgs e)
        {

        }

        private void VerResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultadoEleicoes resultadosEleicoes = new resultadoEleicoes();

            resultadosEleicoes.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Resultado verResultado = new Resultado();

            verResultado.Show();
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.ShowDialog();
        }

        private void FecharProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DocumentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documentacao documentacao = new Documentacao();

            documentacao.Show();
        }
    }
}
