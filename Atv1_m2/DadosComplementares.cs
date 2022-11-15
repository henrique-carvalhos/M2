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
    public partial class DadosComplementares : Form
    {
        public DadosComplementares()
        {
            InitializeComponent();
        }

        //Fechar forms
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Pular para o próximo forms
        private void button1_Click(object sender, EventArgs e)
        {
            RevisarDados revisarDados = new RevisarDados() { MdiParent = MdiParent };
            revisarDados.Show();
            this.Close();
        }

        //Limpar dados
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        //Voltar para o forms anterior
        private void button4_Click(object sender, EventArgs e)
        {
            Documentos documentos = new Documentos() { MdiParent = MdiParent };
            documentos.Show();
            this.Close();
        }
    }
}
