using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentosEntreObjetos
{
    public class Consultoria : Servico, IContratavel
    {
        public Consultoria(string nome) : base(nome) { }

    // 5. Implementação da mensagem específica[cite: 15]
    public void Contratar()
    {
        Console.WriteLine($"[Consultoria] O serviço de '{Nome}' foi agendado. O consultor entrará em contacto.");
    }
    }
}