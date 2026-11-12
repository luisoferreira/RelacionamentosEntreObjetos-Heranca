using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentosEntreObjetos
{
   public class NotificacaoPush : Notificacao
    {
       public override void Enviar()
       {
        Console.WriteLine("Enviando Notificação de push");
       }
    }
}