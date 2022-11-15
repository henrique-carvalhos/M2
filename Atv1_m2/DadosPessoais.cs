using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atv1_m2
{
    public partial class DadosPessoais : Form
    {
        public DadosPessoais()
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
            Documentos documentos = new Documentos();
            documentos.Show();
            this.Close();
        }

        //Limpar os dados
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
