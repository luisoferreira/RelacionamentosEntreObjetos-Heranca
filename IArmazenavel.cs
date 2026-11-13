using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentosEntreObjetos
{
    public interface IArmazenavel
    {
        void Salvar(string conteudo);
        void Ler();
    }
    
}