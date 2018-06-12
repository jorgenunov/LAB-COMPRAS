using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primeira.Models
{
    public class Repository
    {
        //private static List<Despesa> despesas = new List<Despesa>();
        private static List<Conta> contas = new List<Conta>();
        
        public static List<Despesa> Despesa
        {
            get
            {
                LabComrpasBdContext context = new LabComrpasBdContext();
                List<Despesa> despesas = context.Despesas.ToList();
 
                return despesas;
            }
        }
        public static void novaDespesa(Despesa novaDespesa)
        {
            LabComrpasBdContext context = new LabComrpasBdContext();
            context.Despesas.Add(novaDespesa);
            context.SaveChanges();
          
        }

        public static List<Conta> Contas
        {
            get
            {
                
                return contas;
            }
        }

        public static void AddConta(Conta newContas)
        {
            contas.Add(newContas);
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
            contas.Clear();
        }


    

}
}
