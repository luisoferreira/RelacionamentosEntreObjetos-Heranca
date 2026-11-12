using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentosEntreObjetos
{
   public class JogoFisico : Jogo
{
    public bool RequerInstalacao { get; set; }

    public JogoFisico(string nome, string plataforma, bool requerInstalacao) 
        : base(nome, plataforma)
    {
        RequerInstalacao = requerInstalacao;
    }
    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        string instalacao = RequerInstalacao ? "Sim" : "Não";
        Console.WriteLine($"Formato: Físico | Plataforma: {Plataforma} , Requer Instalação: {instalacao}");
    }
}
}