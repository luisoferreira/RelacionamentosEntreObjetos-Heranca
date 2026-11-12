using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentosEntreObjetos
{
    public class Relatorio : IImprimivel , IExportavel  
    {
        public void Imprimir()
    {
        Console.WriteLine("A imprimir o relatório financeiro...");
    }

    public void Exportar()
    {
        Console.WriteLine("A exportar o relatório para formato PDF...");
    }
    }
}