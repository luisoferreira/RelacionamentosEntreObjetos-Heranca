using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentosEntreObjetos
{
    public class JogoDigital : Jogo
{
    public double TamanhoDownload { get; set; }

    public JogoDigital(string nome, string plataforma, double tamanhoDownload) 
        : base(nome, plataforma)
    {
        TamanhoDownload = tamanhoDownload;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Formato: Digital | Plataforma: {Plataforma} | Tamanho: {TamanhoDownload}GB");
    }
}
}