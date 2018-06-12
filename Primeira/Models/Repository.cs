using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeira.Models
{
    public class Repository
    {
        //private static List<Despesa> despesas = new List<Despesa>();
        //private static List<Conta> contas = new List<Conta>();
        
        public static List<Despesa> Despesa
        {
            get
            {
                LabComrpasBdContext context = new LabComrpasBdContext();
                List<Despesa> despesas = context.Despesas.ToList();
 
                return despesas;
            }
        }
        public static List<Conta> Contas
        {
            get
            {
                LabComrpasBdContext context = new LabComrpasBdContext();
                List<Conta> contas = context.Contas.ToList();
                return contas;
            }
        }

        public static void novaDespesa(Despesa novaDespesa)
        {
            LabComrpasBdContext context = new LabComrpasBdContext();
            context.Despesas.Add(novaDespesa);
            context.SaveChanges();
          
        }

        

        public static void AddConta(Conta newContas)
        {
            LabComrpasBdContext context = new LabComrpasBdContext();
            context.Contas.Add(newContas);
            context.SaveChanges();
        }
        public static void ClearDespesa()
        {
            LabComrpasBdContext context = new LabComrpasBdContext();

            foreach (Despesa d in Despesa)
            {
                context.Despesas.Remove(d);
            }

            context.SaveChanges();

        }


        public static void ClearContas()
        {
            LabComrpasBdContext context = new LabComrpasBdContext();

            foreach (Conta c in Contas)
            {
                context.Contas.Remove(c);
            }

            context.SaveChanges();

        }

        public static Despesa GetDespesas(int id)
        {
            foreach (Despesa d in Despesa)
            {
                if (d.ID == id)
                    return d;
            }
            return null;
        }

        public static Conta GetContas(string name)
        {
            foreach (Conta c in Contas)
            {
                if (c.NomeTitular == name)
                    return c;
            }
            return null;
        }


    }
}
