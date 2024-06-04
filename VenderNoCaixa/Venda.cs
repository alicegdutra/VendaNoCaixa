using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    public class Venda
    {
        private int Data { get; set; }
        private double Total { get; set; }

        public List<ItemVenda> Itens {get; set;}

        public Venda(int data, double total)
        {
            Data = data;
            Total = total;
        }
        public void Mostrar()
            {
                Console.WriteLine("Data: " + Data + "\tTotal: " + Total);
            }

        public void AdicionarItem(ItemVenda item)
        {

            Itens.Add(item);
        }
        public void ItemVenda()
        {
            Console.WriteLine("\nListagem dos itens de venda: " + Total);
            foreach (ItemVenda v in Itens)
                v.Mostrar();
        }

        public double total
        {
            get{return Total;}
            set{Total = value;}
        }

        public int data
        {
            get{return Data;}
            set{Data = value;}
        }
        public int CalcularTotalItens()
        {
            Console.WriteLine(Itens.Count);
            return Itens.Count;
        }
}
}