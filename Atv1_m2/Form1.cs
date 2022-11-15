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
    public partial class Form1 : Form
    {
        int id_form = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void dadosPessoaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id_form++;
            DadosPessoais dadosComplementares = new DadosPessoais(); //Instância do objeto editor - Form2
            dadosComplementares.MdiParent = this;    //Define o pai do filho, editor(filho) e pai(Form1)
            dadosComplementares.Text = "Dados pessoais " + id_form;
            dadosComplementares.Show();
        }
    }
}
