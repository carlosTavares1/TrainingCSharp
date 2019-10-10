using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Classe que controla as informações dos nossos livros
    /// </summary>
    public class LivrosController
    {
        ContextDB contextDB = new ContextDB();
        /// <summary>
        /// Este método faz a busca de todos os registros que estão ativos
        /// </summary>
        /// <returns>Este retorna os registro que estão ativos na base</returns>
        public IQueryable<Livro> GetLivros()
        {
            return contextDB.Livros.Where(x => x.Ativo == true);
        }
        /// <summary>
        /// Este método atualiza um registro com base em um id
        /// </summary>
        /// <param name="item">Este método recebe como parâmetro um objeto do tipo livro</param>
        /// <returns>Retorna verdadeiro caso o id exista na base de dados</returns>
        public bool AtualizarLivro(Livro item)
        {
            var livro = contextDB.Livros.FirstOrDefault(x => x.Id == item.Id); 
            
            if (livro == null)
            {
                return false;
            }
            else
            {
                livro.DataAlteracao = DateTime.Now;
            }
            contextDB.SaveChanges();
            return true;
        }
        /// <summary>
        /// Este método inseri um novo livro no sistema
        /// </summary>
        /// <param name="item">Recebe como parâmetro um objeto</param>
        /// <returns>Retorna verdadeiro caso os campos sejam aceitáveis</returns>
        public bool InserirLivro(Livro item)
        {
            if (string.IsNullOrWhiteSpace(item.Nome))
            {
                return false;
            }
            contextDB.Livros.Add(item);
            contextDB.SaveChanges();
            return true;
        }
        /// <summary>
        /// Este método desativa um livro do sistema
        /// </summary>
        /// <param name="id">Ele recebe como parâmetro um int</param>
        /// <returns>E retorna um true com base no valor inserido</returns>
        public bool RemoverLIvro(int id)
        {
            var livro = contextDB.Livros.FirstOrDefault(x => x.Id == id);

            if (livro == null)
            {
                return false;
            }
            else
            {
                livro.Ativo = false;
            }
            contextDB.SaveChanges();
            return true;
        }
    }
}
