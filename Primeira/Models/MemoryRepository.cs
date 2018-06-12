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
        public static void AddDespesa(Despesa newDespesa)
        {
           
            despesas.Add(newDespesa);
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

        public static Despesa GetDespesas(int id)
        {
            foreach (Despesa d in despesas)
            {
                if (d.ID == id)
                    return d;
            }
            return null;
        }

        public static Conta GetContas(string name)
        {
            foreach (Conta c in contas)
            {
                if (c.NomeTitular == name)
                    return c;
            }
            return null;
        }

    }
}
