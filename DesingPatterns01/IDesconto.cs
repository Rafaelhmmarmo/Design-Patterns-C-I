using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPatterns01
{
    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);
        IDesconto Proximo { get; set; }
    }
}
