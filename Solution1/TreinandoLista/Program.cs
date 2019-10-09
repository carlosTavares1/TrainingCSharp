using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinandoLista.Model;

namespace TreinandoLista
{
    class Program
    {
        static List<Aluno> lista = new List<Aluno>();
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }
        /// <summary>
        /// Este método proporciona a entrada das informações de cada aluno
        /// </summary>
        private static void CadastrarAluno()
        {
            Aluno aluno = new Aluno();
            Console.Clear();
            Console.WriteLine("----------Novo Cadastro----------");
            Console.Write("Informe o nome: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Informe o endereço: ");
            aluno.Endereco = Console.ReadLine();
            Console.Write("Informe a idade: ");
            aluno.Idade = int.Parse(Console.ReadLine());
            lista.Add(aluno);
            Console.Clear();
            Console.WriteLine("----------Cadastro realizado com sucesso----------\r\n");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
        /// <summary>
        /// Este método exibe os registros de cada aluno cadastrado até o momento
        /// </summary>
        private static void ListarAluno()
        {
            Console.Clear();
            lista.ForEach(i => Console.WriteLine($"Nome: {i.Nome} | Endereço: {i.Endereco} | Idade: {i.Idade}"));
            Console.WriteLine("\r\nPressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
            Console.Clear();
            Menu();
        }
        /// <summary>
        /// Este método permite exibir o menu do sistema
        /// </summary>
        private static void Menu()
        {
            Console.WriteLine("----------Seja bem-vindo----------");
            Console.WriteLine("---Sistema de Cadastro Academia---\r\n");
            Console.WriteLine("Escolha uma das opções abaixo!");
            Console.WriteLine("\r\n1 - Cadastrar novo aluno\r\n2 - Listar alunos\r\n3 - Buscar aluno\r\n4 - Sair\r\n");
            Console.WriteLine("Digite a opção desejada:");
            var opcao = int.Parse(Console.ReadKey().KeyChar.ToString());

            switch (opcao)
            {
                case 1:
                    {
                        CadastrarAluno();
                    }
                    break;
                case 2:
                    {
                        ListarAluno();
                    }
                    break;
                case 3:
                    {
                        BuscarAluno();
                    }
                    break;
                case 4:
                    {
                        Console.Clear();
                        Console.WriteLine("Saindo do sistema...");
                    }
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Este método realiza a busca por nome, um aluno cadastrado no sistema
        /// </summary>
        private static void BuscarAluno()
        {
            Console.Clear();
            Console.WriteLine("----------Buscar usuário----------");
            Console.WriteLine("Informe o nome e pressione enter para realizar a busca:");
            var nome = Console.ReadLine();
            foreach (var item in lista)
            {
                if (item.Nome == nome)
                {
                    Console.WriteLine(item.Nome);
                }
                else
                {
                    Console.WriteLine("Nenhum registro encontrado");
                }
            }
        }
    }
}