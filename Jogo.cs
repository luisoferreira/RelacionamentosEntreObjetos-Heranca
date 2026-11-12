using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentosEntreObjetos
{
   public abstract class Jogo
{
    // Propriedade
    public string Nome { get; set; }
    
    protected string Plataforma; 
    public Jogo(string nome, string plataforma)
    {
        Nome = nome;
        Plataforma = plataforma;
    }

    
    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Jogo: {Nome}");
    }
}
}