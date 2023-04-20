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
        public string nome { get; set; }

        [Required]
        [Key]
        [Column("USERID")]
        public int id { get; set; }

        [Column("USERNASC")]
        public string dataNasc { get; set; }

        [Column("USEREND")]
        public string endereco { get; set; }

        [Column("USEREMAIL")]
        public string email { get; set; }

        [Column("USERCARGO")]
        public string cargo { get; set; }


    }
}
