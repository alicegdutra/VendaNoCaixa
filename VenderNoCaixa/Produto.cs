using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    public class Produto
    {
        private int Codigo { get; set; }
        private string Nome { get; set; }
        private int Estoque { get; set; }
        private double Preco { get; set; }

        public Produto(int codigo, string nome, int estoque, double preco)
        {
            Codigo = codigo;
            Nome = nome;
            Estoque = estoque;
            Preco = preco;
        }

        public void Mostrar()
            {
                Console.WriteLine("Codigo: " + Codigo + "\tNome: " + Nome + "\tEstoque: " + Estoque + "\tPreco: " + Estoque);
            }

        public int codigo
        {
            get { return Codigo; }
            set { Codigo = value; }
        }

        public string nome
        {
            get{return Nome;}
            set{Nome = value;}
        }

        public int estoque
        {
            get{return Estoque;}
            set{Estoque = value;}
        }

        public double preco
        {
            get{return Preco;}
            set{Preco = value;}
        }


    }
}