using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GestãoDeProjeto.Models
{
    public class Projeto
    {
        [Column("PROJNOME")]
        [StringLength(100)]
        public string nome { get; set; }

        [Required]
        [Key]
        [Column("USERID")]
        public int id { get; set; }

        [Column("PROJACAO")]
        [StringLength(100)]
        public string acao { get; set; }

        [Column("PROJINICIO")]
        public string dataInicio { get; set; }

        [Column("PROJFIM")]
        public string dataFim { get; set; }

        [Column("PROJUSER")]
        public string usuario { get; set; }

        [Column("PROJSTATUS")]
        public string status { get; set; }
    }
}
