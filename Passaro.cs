using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentosEntreObjetos
{
    public class Passaro : Animal
    {
        public Passaro(string nome) : base(nome) { }

    public override void EmitirSom()
    {
        Console.WriteLine("Som:piu piu"); 
    }
    }
}