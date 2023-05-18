// Requisitos
// A classe Login deve ter um método que vai ser responsável por gerar os menus e todas as funcionalidades gerais do programa
// Para isso vamos seguir a linha de raciocínio abaixo:
// [ ] Criar estrutura do projeto
// [ ] Criar Classes
// [ ] Marca
// [ ] Usuário
// [ ] Produto
// [ ] Login
// [ ] Implementar a lógica nos métodos
// [ ] Na classe program.cs chamar apenas o construtor Login que vai gerar o menu e todas as outras opções.
// Dica: crie os métodos e atributos primeiro, e só depois comece a implementar as ações nos métodos, isso vai gerar uma visão mais sistêmica de seu projeto.

using ProdutoPOO;

Login app = new Login();

Produto v3 = new Produto();

Marca v4 = new Marca();

Console.Clear();

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

v3.resposta = int.Parse(Console.ReadLine()!);
if (v3.resposta == 1)
{
    v3.Cadastrar();
}
if (v3.resposta == 2)
{
    v3.Listar();
}

if (v3.resposta == 3)
{
    v3.Deletar();
}
if (v3.resposta == 4)
{
    v3.Cadastrar();
}
if (v3.resposta == 5)
{
    v3.Listar();
}

if (v3.resposta == 6)
{
    v3.Deletar();
}

} while (v3.resposta != 0);
