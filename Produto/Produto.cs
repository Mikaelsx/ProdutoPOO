using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutoPOO
{
    public class Produto 
    {
        public int Codigo{get; set;}
        public string NomeProduto{get; set;}
        public float Preco{get; set;}
        public DateTime DataCadastro{get; set;}

    public int resposta {get; set;}


        public Marca Marca = new Marca();

        public Usuario CadastradoPor {get; set;}

        List<Produto> ListaProdutos = new List<Produto>();


        public void Cadastrar()
        {
                Console.WriteLine($"Digite o nome do produto:");
                NomeProduto = Console.ReadLine()!;

                Console.WriteLine($"Digite o código do produto:");
                Codigo = int.Parse(Console.ReadLine()!);

                Console.WriteLine($"Digite o preço do produto:");
                Preco = float.Parse(Console.ReadLine()!);

                Console.WriteLine($"Produto cadastrado com sucesso"); 
        }

        public void Listar()
        {
            if(ListaProdutos.Count > 0)
            {
                foreach (Produto p in ListaProdutos)
                {
Console.WriteLine(@$"
Códido: {p.Codigo}
Nome: {p.NomeProduto}
Preço: {p.Preco}");
Console.WriteLine($"");  
                }
            }
        }

        public void Deletar()
        {
            // this.Codigo = "";
            // this.Preco = "";
            // this.NomeProduto = "";
            // Console.WriteLine($"Produto apagado");
            
        }
    }
}
