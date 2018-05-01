using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Primeira.Models
{
    public class Despesa
    {
        [Required(ErrorMessage="Por favor preencha o Nome da Despesa")]
        public string NomeDespesa { get; set; }
        [Required(ErrorMessage = "Por favor preencha a Quantidade da Despesa")]
        public int Quantidade { get; set; }
        [Required(ErrorMessage = "Por favor preencha o Valor da Despesa")]
        public double Valor { get; set; }
        [Required(ErrorMessage = "Por fvor preencha a Categoria da Despesa")]
        public string Categoria { get; set; }
        [Required(ErrorMessage = "Por favor diga se está a despesa está paga ou não")]
        public bool Pago { get; set; }



    }
}
