using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class credenciamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "CPF: ")]
        [Range(0, long.MaxValue)]
        public long cpf  { get; set; }

        [Display(Name = "Nome: ")]
        [MinLength(5, ErrorMessage = "O tamanho mínimo do nome são 5 caracteres.")]
        [StringLength(200, ErrorMessage = "O tamanho máximo são 200 caracteres.")]
        //[Required(ErrorMessage = "Digite O nome do Usuario.")]
        public string nome { get; set; }


        [Display(Name = "Convite: ")]
        public int convite { get; set; }


        [Display(Name = "Premio: ")]
        public int premio { get; set; }

        //campo Booleano para
        public Boolean OK { get; set; }
    }
}
