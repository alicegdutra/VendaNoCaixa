using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    public class Especie : Pagamento
    {
        private double quantia { get; set; }

        private double troco { get; set; }

        public Especie (int data, double total, double quantia, double troco) : base (data, total)
        {
            Quantia = quantia;
            Troco = troco;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Qauntia: " + quantia + "\tTroco: " +  troco);
        }

        public double Quantia
        {
            get { return quantia; }
            set { quantia = value; }
        }

        public double Troco
        {
            get { return troco; }
            set { troco = value; }
        }
    }

    
}