using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutoPOO
{
    public class Usuario
    {
        public int Codigo {get; set;}
        public string Nome {get; set;}
        public string Email {get; set;}
        public string Senha{get; set;}

        public DateTime DataCadastro {get; set;}

        public void Cadastrar()
        {
            this.Nome = "Mikael";
            this.Email = "MikaelSouza@gmail.com";
            this.Senha = "12345";
            this.DataCadastro = DateTime.Now;
        }
        public void Deletar()
        {
            this.Nome = "";
            this.Email = "";
            this.Senha = "";
            this.DataCadastro = DateTime.Parse("0000-00-00T00:00:00");
        }
    }
}