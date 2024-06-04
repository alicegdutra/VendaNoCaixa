using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceVendas
{
    public class Venda
    {
        private int Data { get; set; }
        private double Total { get; set; }

        public List<ItemVenda> VItens {get; set;}

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

            VItens.Add(item);
        }
        public void ItemVenda()
        {
            Console.WriteLine("\nListagem dos itens de venda: " + Total);
            foreach (ItemVenda v in VItens)
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
            Console.WriteLine(VItens.Count);
            return VItens.Count;
        }
}
}