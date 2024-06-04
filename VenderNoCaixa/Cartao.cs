
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    public class Cartao : Pagamento
    {
        private string dadosTransacao { get; set; }
        private int resultadoTransacao { get; set; }

        public Cartao() : base()
        {         }

        public Cartao (int data, double total, string dadosTransacao, int resultadoTransacao) : base (data, total)
        {
            DadosTransacao = dadosTransacao;
            ResultadoTransacao = resultadoTransacao;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Data de Transacao: " + DadosTransacao + "\tResultado da Transacao: " +  ResultadoTransacao);
        }

        public string DadosTransacao
        {
            get { return dadosTransacao; }
            set { dadosTransacao = value; }
        }

        public int ResultadoTransacao
        {
            get { return resultadoTransacao; }
            set { resultadoTransacao = value; }
        }

    }
}
