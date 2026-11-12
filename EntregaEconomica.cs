using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentosEntreObjetos
{
    public class EntregaEconomica : Entrega
    {
            public EntregaEconomica(double distancia) : base(distancia)
        {}
            public override decimal CalcularFrete()
        {
             return (decimal) Distancia * 5.00m + 10;
        }
        }
    
}