using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    public class ItemVenda
    {
        private int Quantidade { get; set; }
        private double Preco { get; set; }
        private double Subtotal { get; set; }

        public Produto Produto {get;set;}

        public ItemVenda(int quantidade, double preco, double subtotal)
        {
            Quantidade = quantidade;
            Preco = preco;
            Subtotal = subtotal;
        }
        public void Mostrar()
            {
                Console.WriteLine("Produto: " + Produto.nome + "\tQuantidade: " + Quantidade + "\tPreco: " + Preco + "\tSubtotal: " + Subtotal);
            }

        public int quantidade
        {
            get { return Quantidade; }
            set { Quantidade = value; }
        }

        public double preco{
            get{ return Produto.preco * Quantidade;}
            set{ Preco = value;}
        }

        public double subtotal
        {
            get{return Subtotal;}
            set{Subtotal = value;}
        }
        

        
    }
}