using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentosEntreObjetos
{
    public abstract class Entrega
    {
        public double Distancia {get; set;}

            public Entrega(double distancia)
            {
                Distancia =distancia;
        
            }

            public abstract decimal CalcularFrete();
    
    }
}