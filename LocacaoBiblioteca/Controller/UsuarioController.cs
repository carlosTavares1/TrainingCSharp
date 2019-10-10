using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    /// <summary>
    /// Classe que contem os metodos de usuários do sistema
    /// </summary>
    public class UsuarioController
    {
        ContextDB contextDB = new ContextDB();
        /// <summary>
        /// Este método faz a busca de todos os registros que estão ativos
        /// </summary>
        /// <returns>Este retorna os registro que estão ativos na base</returns>
        public IQueryable<Usuario> GetUsuarios()
        {
            return contextDB.Usuarios.Where(x => x.Ativo == true);
        }
        /// <summary>
        /// Este método atualiza um registro com base em um id
        /// </summary>
        /// <param name="item">Este método recebe como parâmetro um objeto do tipo usuário</param>
        /// <returns>Retorna verdadeiro caso o id exista na base de dados</returns>
        public bool AtualizarUsuario(Usuario item)
        {
            var usuario = contextDB.Usuarios.FirstOrDefault(x => x.Id == item.Id); //Essa linha eh exatamente igual a debaixo, só que mais otimizada
            //var usuario2 = contextDB.Usuarios.Where(x => x.Id == item.Id).First(); 
            if (usuario == null)
            {
                return false;
            }
            else
            {
                usuario.DataAlteracao = DateTime.Now;
            }
            contextDB.SaveChanges();
            return true;
        }
        /// <summary>
        /// Este método inseri um novo usuario no sistema
        /// </summary>
        /// <param name="item">Recebe como parâmetro um objeto</param>
        /// <returns>Retorna verdadeiro caso os campos sejam aceitáveis</returns>
        public bool InserirUsuario(Usuario item)
        {
            if (string.IsNullOrWhiteSpace(item.Login))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(item.Senha))
            {
                return false;
            }
            contextDB.Usuarios.Add(item);
            contextDB.SaveChanges();
            return true;
        }
        /// <summary>
        /// Este método desativa um usuário do sistema
        /// </summary>
        /// <param name="id">Ele recebe como parâmetro um int</param>
        /// <returns>E retorna um true com base no valor inserido</returns>
        public bool RemoverUsuario(int id)
        {
            var usuario = contextDB.Usuarios.FirstOrDefault(x => x.Id == id);

            if(usuario == null)
            {
                return false;
            }
            else
            {
                usuario.Ativo = false;
            }
            contextDB.SaveChanges();
            return true;
        }
    }
}
