using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentosEntreObjetos
{
    public class Contrato: IImprimivel
{
    public void Imprimir()
    {
        Console.WriteLine("A imprimir o contrato ");
    }
}
}