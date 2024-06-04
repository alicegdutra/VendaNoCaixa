
using System;

namespace VenderNoCaixa
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Estoque { get; set; }
        public double Preco { get; set; }

        public Produto(int codigo, string nome, int estoque, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Estoque = estoque;
            Preco = preco;
        }

        public void Mostrar()
        {
            Console.WriteLine("Codigo: " + Codigo + "\tNome: " + Nome + "\tEstoque: " + Estoque + "\tPreco: " + Preco);
        }
    }
}
