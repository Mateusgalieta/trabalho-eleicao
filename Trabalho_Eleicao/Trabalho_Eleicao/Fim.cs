using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Trabalho_Eleicao
{
    public partial class Fim : Form
    {
        public Fim()
        {
            InitializeComponent();
        }
        Timer formClose = new Timer();
        private void Fim_Load(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.som);
            player.Play();

            formClose.Interval = 1000;
            formClose.Tick += new EventHandler(formClose_Tick);
            formClose.Start();
        }


        void formClose_Tick(object sender, EventArgs e)
        {
            formClose.Stop();
            formClose.Tick -= new EventHandler(formClose_Tick);
            this.Close();
        }
    }
}
