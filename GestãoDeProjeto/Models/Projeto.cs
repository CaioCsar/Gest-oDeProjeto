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
        [Display(Name = "Nome")]
        public string nome { get; set; }

        [Required]
        [Key]
        [Column("USERID")]
        public int id { get; set; }

        [Column("PROJINICIO")]
        [Display(Name = "Data de Início")]
        public string dataInicio { get; set; }

        [Column("PROJFIM")]
        [Display(Name = "Data de Término")]
        public string dataFim { get; set; }

        [Column("PROJESTIMATIVA")]
        [Display(Name = "Estimativa em meses")]
        [StringLength(2)]
        public string estimativaEmMeses { get; set; }

        [Display(Name ="CASA")]
        [Column("PROJLOCAL")]
        public string local { get; set; }

        [Column("PROJVALOR")]
        [Display(Name = "Valor Estimado do Projeto")]
        public string valorProj { get; set; }

        [Column("PROJSDATAAPROV")]
        [StringLength(4)]
        [Display(Name = "Ano de Aprovação")]
        public string anoDeAprovacao { get; set; }

        [Column("PROJNUMERO")]
        [StringLength(4)]
        [Display(Name = "Número do Projeto")]
        public string numeroDoProj { get; set; }

        [Column("PROJSTATUS")]
        [Display(Name = "Situação")]
        public string status { get; set; }

    }
}
