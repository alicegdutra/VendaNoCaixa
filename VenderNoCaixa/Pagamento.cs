using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    public abstract class Pagamento
    {
        protected int Data { get; set; }
        protected double Total { get; set; }

        public Pagamento(int data, double total)
        {
            Data = data;
            Total = total;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine("Data: " + Data + "\tTotal: " + Total);
        }

        public abstract void ProcessarPagamento();
    }
}
