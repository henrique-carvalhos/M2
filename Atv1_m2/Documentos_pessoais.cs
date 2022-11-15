using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atv1_m2
{
    public class Documentos_pessoais
    {
        private string Email;
        private string ConfirmacaoEmail;
        private string Cep;
        private string Cidade;
        private string Logradouro;
        private string Distrito;
        private string Ddd;
        private string Telefone;

        //Método construtor
        public Documentos_pessoais()
        {
        }

        public Documentos_pessoais(string email, string confirmacaoEmail, string cep, string cidade, string logradouro, string distrito)
        {
            Email = email;
            ConfirmacaoEmail = confirmacaoEmail;
            Cep = cep;
            Cidade = cidade;
            Logradouro = logradouro;
            Distrito = distrito;
        }

        //Métodos Get e Set
        public string getEmail()
        {
            return this.Email;
        }
        public void setEmail(string email)
        {
            this.Email = email;
        }

        public string getConfirmacaoEmail()
        {
            return this.ConfirmacaoEmail;
        }
        public void setConfirmacaoEmail(string confirmacaoEmail)
        {
            this.ConfirmacaoEmail = confirmacaoEmail;
        }

        public string getCep()
        {
            return this.Cep;
        }
        public void setCep(string cep)
        {
            this.Cep = cep;
        }

        public string getCidade()
        {
            return this.Cidade;
        }
        public void setCidade(string cidade)
        {
            this.Cidade = cidade;
        }

        public string getLogradouro()
        {
            return this.Logradouro;
        }
        public void setLogradouro(string logradouro)
        {
            this.Logradouro = logradouro;
        }

        public string getDistrito()
        {
            return this.Distrito;
        }
        public void setDistrito(string distrito)
        {
            this.Distrito = distrito;
        }

        public string getDdd()
        {
            return this.Ddd;
        }
        public void setDdd(string ddd)
        {
            this.Ddd = ddd;
        }

        public string getTelefone()
        {
            return this.Telefone;
        }
        public void setTelefone(string telefone)
        {
            this.Telefone = telefone;
        }
    }
}
