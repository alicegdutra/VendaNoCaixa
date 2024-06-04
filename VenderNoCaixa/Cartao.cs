using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    public class Cartao : Pagamento
    {
        private string DadosTransacao { get; set; }
        private int ResultadoTransacao { get; set; }

        public Cartao(int data, double total, string dadosTransacao, int resultadoTransacao) : base(data, total)
        {
            DadosTransacao = dadosTransacao;
            ResultadoTransacao = resultadoTransacao;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Dados da Transacao: " + DadosTransacao + "\tResultado da Transacao: " +  ResultadoTransacao);
        }

        public override void ProcessarPagamento()
        {
            Console.WriteLine($"Pagamento com cartão processado. Dados da transação: {DadosTransacao}, Resultado: {ResultadoTransacao}");
        }
    }
}
