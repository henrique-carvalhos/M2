using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atv1_m2
{
    public partial class RevisarDados : Form
    {
        public RevisarDados()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DadosComplementares dadosComplementares = new DadosComplementares() { MdiParent = MdiParent };
            dadosComplementares.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //.Clear();
        }
    }
}
