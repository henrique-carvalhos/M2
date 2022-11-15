using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv1_m2
{
    public class Dados_Pessoais
    {
        //Atributos
        private string Nome;
        private string Filiacao1;
        private string Filiacao2;
        private DateTime DataNascimento;
        private string NomeAnterior;

        //Método construtor 
        public Dados_Pessoais()
        {
        }

        public Dados_Pessoais(string nome, DateTime dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        //Métodos Get e Set
        public string getNome()
        {
            return this.Nome;
        }
        public void setId(string nome)
        {
            this.Nome = nome;
        }

        public string getFiliacao1()
        {
            return this.Filiacao1;
        }
        public void setFiliacao1(string filiacao1)
        {
            this.Filiacao1 = filiacao1;
        }

        public string getFiliacao2()
        {
            return this.Filiacao2;
        }
        public void setFiliacao2(string filiacao2)
        {
            this.Filiacao2 = filiacao2;
        }

        public DateTime getDataNascimento()
        {
            return this.DataNascimento;
        }
        public void setDataNascimento(DateTime dataNascimento)
        {
            this.DataNascimento = dataNascimento;
        }

        public string getNomeAnterior()
        {
            return this.NomeAnterior;
        }
        public void setNomeAnterior(string nomeAnterior)
        {
            this.NomeAnterior = nomeAnterior;
        }
    }
}
