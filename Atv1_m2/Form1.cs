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
        public Form1()
        {
            InitializeComponent();
        }

        private void dadosPessoaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DadosPessoais dadosComplementares = new DadosPessoais(); //Instância do objeto editor - Form2
            dadosComplementares.MdiParent = this;    //Define o pai do filho, editor(filho) e pai(Form1)
            dadosComplementares.Text = "Dados pessoais ";
            dadosComplementares.Show();
            dadosComplementares.WindowState = FormWindowState.Maximized;
        }

        private void documentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Documentos documentos = new Documentos(); //Instância do objeto editor - Form2
            documentos.MdiParent = this;    //Define o pai do filho, editor(filho) e pai(Form1)
            documentos.Text = "Documentos";
            documentos.Show();
            documentos.WindowState = FormWindowState.Maximized;
        }

        private void dadosComplementaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DadosComplementares dadosComplementares = new DadosComplementares(); //Instância do objeto editor - Form2
            dadosComplementares.MdiParent = this;    //Define o pai do filho, editor(filho) e pai(Form1)
            dadosComplementares.Text = "Documentos";
            dadosComplementares.Show();
            dadosComplementares.WindowState = FormWindowState.Maximized;
        }

        private void revisarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RevisarDados revisarDados = new RevisarDados(); //Instância do objeto editor - Form2
            revisarDados.MdiParent = this;    //Define o pai do filho, editor(filho) e pai(Form1)
            revisarDados.Text = "Documentos";
            revisarDados.Show();
            revisarDados.WindowState = FormWindowState.Maximized;
        }
    }
}
