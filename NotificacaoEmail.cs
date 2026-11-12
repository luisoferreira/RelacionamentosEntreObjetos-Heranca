using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentosEntreObjetos
{
    public class NotificacaoEmail : Notificacao
    {
         public override void Enviar()
       {
        Console.WriteLine("Enviando notificação deE-mail");
       }
    }
}