using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoDeProjeto.Models
{
    public class Usuario
    {
       [Required]
       [Column("USERNAME")]
       [Display(Name = "Nome")]
        public string nome { get; set; }

        [Required]
        [Key]
        [Column("USERID")]
        public int id { get; set; }

        [Display(Name ="Data de Nascimento")]
        [Column("USERNASC")]
        public string dataNasc { get; set; }

        [Display(Name = "Endereço")]
        [Column("USEREND")]
        public string endereco { get; set; }

        [Column("USEREMAIL")]
        [Display(Name = "E-mail")]
        public string email { get; set; }

        [Column("USERCARGO")]
        [Display(Name = "Cargo")]
        public string cargo { get; set; }


    }
}
