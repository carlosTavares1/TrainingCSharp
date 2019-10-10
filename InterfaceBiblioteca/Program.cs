using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;

namespace InterfaceBiblioteca
{
    class Program
    { 
        //Instanciamos "Carregamos para memoria" nosso controlador dos livros
        static LivrosController livrosController = new LivrosController();
        //Instanciamos "Carregamos para memoria" nosso controlador dos usuarios
        static UsuarioController usuarioController = new UsuarioController();
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");
            //Realizamos a chamada "invok" do nosso menu do sistema em um metodo
            MostraMenuSistema();
        }
        /// <summary>
        /// Mostra no console o menu  disponivel do sistema.
        /// </summary>
        private static void MostraMenuSistema()
        {
            //Iniciamos nossa variavel com o menot valor de int possivel
            var menuEscolhido = int.MinValue;
            //Aqui definimos se for diferente de 0 mantemos o sistema aberto se não finalizamos
            while (menuEscolhido != 0)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");
                //Mostra as opções de menu dentro do nosso sistema.
                Console.WriteLine("Menu sistema");
                Console.WriteLine("1 - Cadastrar Livro");
                Console.WriteLine("2 - Listar Livros");
                Console.WriteLine("3 - Remover Livro");
                Console.WriteLine("4 - Atualizar Livro");
                Console.WriteLine("0 - Sair");
                //Aqui vamos pegar numero digitado
                menuEscolhido = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                //Executar proxima funcao
                switch (menuEscolhido)
                {
                    case 1:
                        AdicionarLivro();
                        break;
                    case 2:
                        MostrarLivro();
                        break;
                    case 3:
                        RemoverLivro();
                        break;
                    case 4:
                        AtualizarLivro();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
        /// <summary>
        /// Metodo que adiciona dentro de nossa lista um novo registro de livro
        /// </summary>
        private static void AdicionarLivro()
        {
            //Identificamos que o mesmo esta na parte de cadas,tro de livros do sistema
            Console.WriteLine("Cadastrar livro dentro do sistema!");
            //Informamos que para dar continuidade ele deve informar um nome para o livro
            Console.WriteLine("Nome do livro para cadastro:");
            //Obtemos esta informação do usuario
            var nomeDoLivro = Console.ReadLine();
            //"livrosController" livros controle e nosso "objeto" em memoria
            //Com isso temos disponivel nele ferramentas que nos ajudam a realizar as tarefas
            //como adicionar um item a nossa lista de livros
            var resultado = livrosController.InserirLivro(new Livro()
            {
                //Aqui "Atribuimos" o nome que demos ao livro na propriedade Nome de nosso livro
                //com o sinal de apenas um "=" temos atribuição, passagem de valor
                Nome = nomeDoLivro
            });
            //Indico que finalizamos o processo de cadastro do livro, assim o usuario já sabe 
            //que o mesmo foi realizado e sem erros
            if (resultado)
            {
                Console.WriteLine("Livro cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro ao cadastrar!");
            }
            //ReadKey apenas para que ele visualize esta informação
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que mostra os livros já cadastrados em nossa lista
        /// </summary>
        private static void MostrarLivro()
        {
            livrosController.GetLivros().ToList<Livro>().ForEach(x => Console.WriteLine($"Id: {x.Id} Nome: {x.Nome}"));
            Console.ReadKey();
        }
        /// <summary>
        /// Este método remove o livro do sistema pelo id
        /// </summary>
        public static void RemoverLivro()
        {
            Console.Clear();
            MostrarLivro();

            Console.WriteLine("Informe o Id para a remoção do registro: ");
            var livroId = int.Parse(Console.ReadLine());

            var resultado = livrosController.RemoverLIvro(livroId);

            if (resultado)
            {
                Console.WriteLine("Livro removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro ao remover aparelho");
            }
        }
        /// <summary>
        /// Atualiza um livro pelo Id
        /// </summary>
        public static void AtualizarLivro()
        {
            MostrarLivro();
            Console.WriteLine("Informe o id para alteração de registro: ");
            var LivroId = int.Parse(Console.ReadLine());
            var livro = livrosController.GetLivros().FirstOrDefault(x => x.Id == LivroId);
            if (livro == null)
            {
                Console.WriteLine("Id informado inválido");
                return;
            }
            Console.WriteLine("Informe um novo nome para o livro selecionado: ");
            livro.Nome = Console.ReadLine();
            var resultado = livrosController.AtualizarLivro(livro);
            if (resultado)
            {
                Console.WriteLine("Livro atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro ao atualizar a base!");
            }
        }
    }
}