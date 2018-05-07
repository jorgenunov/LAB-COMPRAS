using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Primeira.Models
{
    public class Conta
    {
        [Required(ErrorMessage = "Por favor preencha o Nome do Titular")]
        public string NomeTitular { get; set; }

        [Required(ErrorMessage = "Por favor preencha o Valor da Saldo")]
        public int Saldo { get; set; }

        public bool Ativa { get; set; }

        public Conta()
        {

        }
    }
}
