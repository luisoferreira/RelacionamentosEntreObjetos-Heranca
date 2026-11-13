using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentosEntreObjetos
{
    public class Hospedagem : Servico, IContratavel, ICancelavel
    {
      public Hospedagem(string nome) : base(nome) { }

    public void Contratar()
    {
        Console.WriteLine($"[Hospedagem] A reserva para '{Nome}' foi efetuada com sucesso.");
    }

    public void Cancelar()
    {
        Console.WriteLine($"[Hospedagem] A reserva para '{Nome}' foi cancelada sem custos.");
    }  
    }
}