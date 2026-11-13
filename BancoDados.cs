using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentosEntreObjetos
{
    public class BancoDados : IArmazenavel
{
    public void Salvar(string conteudo)
    {
        Console.WriteLine($"A guardar '{conteudo}' na base de dados...");
    }

    public void Ler()
    {
        Console.WriteLine("A ler os dados a partir da base de dados...");
    }
}
}