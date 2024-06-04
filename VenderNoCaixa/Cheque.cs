using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    public class Cheque : Pagamento
    {
        private long Numero { get; set; }
        private int DataDeposito { get; set; }
        private int Situacao { get; set; }

        public Cheque(int data, double total, long numero, int dataDeposito, int situacao) : base(data, total)
        {
            Numero = numero;
            DataDeposito = dataDeposito;
            Situacao = situacao;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Número: " + Numero + "\tData de Depósito: " +  DataDeposito + "\tSituação: " + Situacao);
        }

        public override void ProcessarPagamento()
        {
            Console.WriteLine($"Pagamento com cheque processado. Número: {Numero}, Data de Depósito: {DataDeposito}, Situação: {Situacao}");
        }
    }
}
