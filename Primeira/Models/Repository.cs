using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeira.Models
{
    public static class Repository
    {
        private static List<Despesa> despesas = new List<Despesa>();

        public static List<Despesa> Despesa
        {
            get
            {
                return despesas;
            }
        }
        public static void novaDespesa(Despesa novaDespesa)
        {
            despesas.Add(novaDespesa);
        }

        public static void ClearDespesas()
        {
            despesas.Clear();
        }
    }
}
