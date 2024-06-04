
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    public class Cheque : Pagamento
    {
        private long numero { get; set; }
        private int dataDeposito { get; set; }
        private int situacao { get; set; }

        public Cheque() : base()
        {         }

        public Cheque (int data, double total, long numero, int dataDeposito, int situacao) : base (data, total)
        {
            Numero = numero;
            DataDeposito = dataDeposito;
            Situacao = situacao;
        }


        //classe base= super classe= classe pai = classe mae
        //classe filho = classe derivada = subclasse
        public override void Mostrar()
        {
            base.Mostrar(); //base()-- chama construtor da classe base, agora base. ---- chama método da classe base (base.Metodo();)
            Console.WriteLine("Numero: " + Numero + "\tData de Deposito: " +  DataDeposito + "\tSituacao: " + Situacao);
        }

        public long Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public int DataDeposito
        {
            get { return dataDeposito; }
            set { dataDeposito = value; }
        }

        public int Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }
    }
}
