using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    public class Especie : Pagamento
    {
        private double Quantia { get; set; }
        private double Troco { get; set; }

        public Especie(int data, double total, double quantia, double troco) : base(data, total)
        {
            Quantia = quantia;
            Troco = troco;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Quantia: " + Quantia + "\tTroco: " + Troco);
        }

        public override void ProcessarPagamento()
        {
            Console.WriteLine($"Pagamento em espécie processado. Valor: {Total}, Quantia recebida: {Quantia}, Troco: {Troco}");
        }
    }
}
