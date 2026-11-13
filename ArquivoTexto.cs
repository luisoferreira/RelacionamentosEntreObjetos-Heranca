using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentosEntreObjetos
{
    public class ArquivoTexto : IArmazenavel
{
    public void Salvar(string conteudo)
    {
        Console.WriteLine($"A guardar '{conteudo}' num ficheiro de texto...");
    }

    public void Ler()
    {
        Console.WriteLine("A ler os dados a partir do ficheiro de texto...");
    }
}
}