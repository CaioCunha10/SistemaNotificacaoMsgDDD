using Entidades.Notificações;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    [Table("TB_NOTICIA")]
    public class Noticia : Notifica
    {
        [Columm("NTC_id")]
        public int Id { get; set; }

        [Columm("NTC_TITULO")]
        [MaxLength(255)]  
        public string Titulo { get; set; }

        [Columm("NTC_INFORMACAO")]
        [MaxLength(255)]
        public string Informacao { get; set; }

        [Columm("NTC_ATIVO")]
        public bool Ativo { get; set; }

        [Columm("NTC_DATA_CADASTRO")]
        public DateTime DataCadastro { get; set; }

        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public DateTime DataAlteracao { get; set; }
    }

}
