using System.Collections.Generic;

namespace DesingPatterns01
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public List<Item> Itens { get; set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
