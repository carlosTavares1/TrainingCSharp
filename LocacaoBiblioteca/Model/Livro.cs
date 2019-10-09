using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    /// <summary>
    /// Nossa Class que contem as informações que nossos livros vão apresentar
    /// </summary>
    public class Livro : Controle
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Nome { get; set; }
    }
}
