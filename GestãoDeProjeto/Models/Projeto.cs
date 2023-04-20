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

        [Column("PROJINICIO")]
        public string dataInicio { get; set; }

        [Column("PROJFIM")]
        public string dataFim { get; set; }

        [Column("PROJESTIMATIVA")]
        [StringLength(100)]
        public string estimativaEmMeses { get; set; }


        [Column("PROJLOCAL")]
        public string local { get; set; }

        [Column("PROJVALOR")]
        public string valorProj { get; set; }

        [Column("PROJSDATAAPROV")]
        public string anoDeAprovacao { get; set; }

        [Column("PROJNUMERO")]
        public string numeroDoProj { get; set; }

        [Column("PROJSTATUS")]
        public string status { get; set; }



    }
}
