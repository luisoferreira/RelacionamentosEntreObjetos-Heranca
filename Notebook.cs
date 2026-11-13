

namespace RelacionamentosEntreObjetos
{
    public class Notebook : Equipamento
    {
        public int MemoriaRAM { get; set; }

    public Notebook(string modelo, string numeroSerie, int memoriaRAM)   : base(modelo, numeroSerie)
    {
        MemoriaRAM = memoriaRAM;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Especificação: {MemoriaRAM}GB de RAM");
    }
    }
}