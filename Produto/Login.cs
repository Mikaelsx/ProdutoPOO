using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutoPOO
{
    public class Login
    {
        public bool logado {get; set;}
        
        public Login()
        {
            
        }

        public void Logar(Usuario usuario)
        {
            Console.WriteLine($"Informe o email:");
            string emailDigitado = Console.ReadLine()!;
        }

        public void Deslogar()
        {

        }

        public void GerarMenu()
        {
            
        }
    }
}