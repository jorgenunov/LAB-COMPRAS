using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeira.Models
{
    public static class MemoryRepository
    {
        private static List<Despesa> despesas = new List<Despesa>();
        private static List<Conta> contas = new List<Conta>();

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

        public static List<Conta> Contas
        {
            get { return contas; }
        }
        
        public static void AddConta(Conta newContas)
        {
            contas.Add(newContas);
        }
        public static void ClearDespesas()
        {
            despesas.Clear();
        }
        
        public static void ClearContas()
        {
            contas.Clear();
        }


    }
}
