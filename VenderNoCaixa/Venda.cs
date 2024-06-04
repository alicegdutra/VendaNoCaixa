using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VenderNoCaixa
{
    public class Venda
    {
        public int Data { get; set; }
        public double Total { get; set; }
        public List<ItemVenda> Itens { get; set; }

        public Venda(int data)
        {
            Data = data;
            Total = 0;
            Itens = new List<ItemVenda>();
        }

        public void AdicionarItem(ItemVenda item)
        {
            Itens.Add(item);
            Total += item.Subtotal;
        }

        public void Mostrar()
        {
            Console.WriteLine("Data: " + Data + "\tTotal: " + Total);
            foreach (ItemVenda item in Itens)
            {
                item.Mostrar();
            }
        }
    }
}
