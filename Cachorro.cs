using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentosEntreObjetos
{
    public class Cachorro : Animal
    {
     public Cachorro(string nome) : base(nome) { }

   
    public override void EmitirSom()
    {
        Console.WriteLine("Som: Au au"); //
    }   
    }
}