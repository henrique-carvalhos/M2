using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv1_m2
{
    public class Dados_Complementares
    {
        private string NumeroDocumento;
        private DateTime DataEmissao;
        private string OrgaoEmissor;
        private string Cpf;
        private string CpfResponsavel;
        private string NumeroCertidao;
        private string LivroCertidao;
        private string FolhaCertidao;
        private string CartorioCertidao;
        private string SeriePassaporteAnterior;
        private string NumeroPassaporteAnterior;

        //Método construtor
        public Dados_Complementares()
        {
        }

        public Dados_Complementares(string numeroDocumento, DateTime dataEmissao, string orgaoEmissor, string cpf, string numeroCertidao, string livroCertidao, string folhaCertidao, string cartorioCertidao)
        {
            NumeroDocumento = numeroDocumento;
            DataEmissao = dataEmissao;
            OrgaoEmissor = orgaoEmissor;
            Cpf = cpf;
            NumeroCertidao = numeroCertidao;
            LivroCertidao = livroCertidao;
            FolhaCertidao = folhaCertidao;
            CartorioCertidao = cartorioCertidao;
        }

        //Métodos Get e Set
        public string getNumeroDocumento()
        {
            return this.NumeroDocumento;
        }
        public void setId(string numeroDocumento)
        {
            this.NumeroDocumento = numeroDocumento;
        }

        public DateTime getDataEmissao()
        {
            return this.DataEmissao;
        }
        public void setDataEmissao(DateTime dataEmissao)
        {
            this.DataEmissao = dataEmissao;
        }

        public string getOrgaoEmissor()
        {
            return this.OrgaoEmissor;
        }
        public void setOrgaoEmissor(string orgaoEmissor)
        {
            this.OrgaoEmissor = orgaoEmissor;
        }

        public string getCpf()
        {
            return this.Cpf;
        }
        public void setCpf(string cpf)
        {
            this.Cpf = cpf;
        }

        public string getCpfResponsavel()
        {
            return this.CpfResponsavel;
        }
        public void setCpfResponsavel(string cpfResponsavel)
        {
            this.CpfResponsavel = cpfResponsavel;
        }
    }
}
