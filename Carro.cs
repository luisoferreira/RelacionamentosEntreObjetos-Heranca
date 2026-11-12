using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentosEntreObjetos
{
    public class Carro : Veiculo
    {
        public int QuantidadePortas { get; set; }

        public Carro(int quantidadePortas) : base("Marca do carro", "Modelo do carro")
        {
            QuantidadePortas = quantidadePortas;
        }
        public virtual void ExibirInformacoesCarro()
        {
            Console.WriteLine($"Marca: {Marca} , Modelo: {Modelo} , Quantidade de portas: {QuantidadePortas}");
        }

    }
}