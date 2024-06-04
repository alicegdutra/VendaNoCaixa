using System;

namespace VenderNoCaixa
{
    public class ItemVenda
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public double Subtotal { get; set; }
        public Produto Produto { get; set; } 

        public ItemVenda(int quantidade, double preco, double subtotal, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Subtotal = subtotal;
            Produto = produto;
        }

        public void Mostrar()
        {
            Console.WriteLine("Produto: " + Produto.Nome + "\tQuantidade: " + Quantidade + "\tPreco: " + Preco + "\tSubtotal: " + Subtotal);
        }
    }
}
