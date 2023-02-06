using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ESH_ValidacaoComAnnot.WebApi.Models
{
    public class AlunoView
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Campo Nome é obrigatório.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo RA é obrigatório.")]
        public string RA { get; set; }
        [Range(1,99999,ErrorMessage ="Campo TurmaId é obrigatório.")]
        public int TurmaId { get; set; }
    }
}
