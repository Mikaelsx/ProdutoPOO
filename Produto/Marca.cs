using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutoPOO
{
    public class Marca
    {
        public int Codigo {get; set;}

        public string NomeMarca {get; set;}

        public DateTime DataCadastro {get; set;}

        public int resposta {get; set;}

        List<Marca> ListaMarcas = new List<Marca>();

        public void Cadastrar()
        {
            Console.WriteLine($"Digite o nome da marca:");
            NomeMarca = Console.ReadLine()!;

            Console.WriteLine($"Digite o código da marca:");
            Codigo = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Marca cadastrada com sucesso"); 
        }

        public void Listar()
        {

        }

        public void Deletar()
        {
            
        }
    }
}