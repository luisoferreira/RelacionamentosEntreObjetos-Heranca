using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentosEntreObjetos
{
    public class Notificacao
    {
        public virtual void Enviar()
        {
            Console.WriteLine("Enviando uma notificação ");
        }
    }
}