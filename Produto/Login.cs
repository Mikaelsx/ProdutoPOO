using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdutoPOO
{
    public class Login
    {
        public bool logado { get; set; }

        public int CodigoU {get; set;}
        public string NomeU {get; set;}
        public string EmailU {get; set;}
        public string SenhaU{get; set;}

        public Login()
        {
            Usuario log = new Usuario();

            Console.WriteLine($"Digite o seu nome:");
            NomeU = Console.ReadLine()!;

            Console.WriteLine($"Digite o seu email:");
            EmailU = Console.ReadLine()!;

            Console.WriteLine($"Digite a sua senha:");
            SenhaU = Console.ReadLine()!;

            Console.WriteLine($"Digite o seu código de verificação:");
            CodigoU = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"{log.DataCadastro}");
            Usuario user = new Usuario();

            if (EmailU == user.Email)
            {
                GerarMenu();
            }

            else
            {
                Console.WriteLine($"Falha no login, digite informções verídicas");
            }

          

        }
          public void Logar(Usuario user)
         {
Console.WriteLine($@"Cadastro e Login!
            
[1] - Cadastro
[2] - Login 
[0] - Sair
            
");
string loga;
loga = Console.ReadLine()!;
       
        switch (loga)
        {
            case "1":
                
            break;
            case "2":
                
            break;
            case "0":
                Console.WriteLine($"Programa encerrado");
                
            break;

            default:
                break;
        }
        
            
         }

        public void Deslogar()
        {

        }

        public void GerarMenu()
        {

            Console.Clear();
            Produto v3 = new Produto();
            Marca v4 = new Marca();

            string opcaoMenu;
            do
            {
                Console.WriteLine($"CADASTRO DE PRODUTOS");
                Console.WriteLine(@$"
        Digite o número de acordo com a opção desejada:

        1 - Cadastrar Produto
        2 - Listar Produto
        3 - Deletar Produto
        ");
                Console.WriteLine(@$"
        4 - Cadastrar Marca
        5 - Listar Marca
        6 - Deletar Marca

        0 - Sair");

                opcaoMenu = Console.ReadLine()!;

                switch (opcaoMenu)
                {
                    case "1":
                        v3.Cadastrar();
                    break;
                    case "2":
                        v3.Listar();
                    break;
                    case "3":

                    Console.WriteLine($"Informe o código do produto que deseja deletar: ");
                    int codigo = int.Parse(Console.ReadLine()!);
                        v3.Deletar(codigo);

                    break;
                    case "4":
                        v4.Cadastrar();
                    break;
                    case "5":
                        v4.Listar();
                    break;
                    case "6":

                    Console.WriteLine($"Informe o código do produto que deseja deletar: ");
                    int cod = int.Parse(Console.ReadLine()!);
                        v4.Deletar(cod);

                    break;
                    case "0":
                        Console.WriteLine($"Programa encerrado");
                        
                    break;
                    default:
                        break;
                }
                

                // if (opcaoMenu == "1")
                // {
                //     v3.Cadastrar();
                // }
                // if (opcaoMenu == "2")
                // {
                //     v3.Listar();
                // }

                // if (opcaoMenu == "3")
                // {
                //     Console.WriteLine($"Informe o código do produto que deseja deletar: ");
                //     int codigo = int.Parse(Console.ReadLine()!);

                //     v3.Deletar(codigo);
                // }
                // if (opcaoMenu == "4")
                // {
                //     v4.Cadastrar();
                // }
                // if (opcaoMenu == "5")
                // {
                //     v4.Listar();
                // }

                // if (opcaoMenu == "6")
                // {
                //     Console.WriteLine($"Informe o código da marca que deseja deletar: ");
                //     int codigo = int.Parse(Console.ReadLine()!);

                //     v4.Deletar(codigo);
                // }

            } while (opcaoMenu != "0");

        }
    }
}