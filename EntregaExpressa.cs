using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace RelacionamentosEntreObjetos
{
    public class EntregaExpressa : Entrega
    {
            public EntregaExpressa(double distancia) : base(distancia)
        {}
            public override decimal CalcularFrete()
        {
             return (decimal) Distancia * 5.00m + 20;
        }
        }
       
 }

    
