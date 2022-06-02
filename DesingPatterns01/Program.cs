using System;

namespace DesingPatterns01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region[Exemplo Uso de varios impostos diferentes]
            IImposto iss = new ISS();
            IImposto icms = new ICMS();
            IImposto iccc = new ICCC();
            Orcamento orcamento = new Orcamento(500.0);
            CalculadorDeImposto calculador = new CalculadorDeImposto();
            Console.WriteLine("Impostos calculado");
            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento, icms);
            calculador.RealizaCalculo(orcamento, iccc);
            Console.WriteLine("----------");
            Console.WriteLine("");
            #endregion

            #region[Exemplo de calculo com varios descontos]
            CalculadorDeDescontos calculador2 = new CalculadorDeDescontos();
            Orcamento orcamento2 = new Orcamento(500.0);
            orcamento2.AdicionaItem(new Item("CANETA", 250.0));
            orcamento2.AdicionaItem(new Item("LAPIS", 250.0));

            double desconto = calculador2.Calcula(orcamento);

            Console.WriteLine("Desconto: " + desconto);
            #endregion

            Console.ReadKey();           
        }
    }
}
