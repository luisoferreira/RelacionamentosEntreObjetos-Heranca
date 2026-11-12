using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentosEntreObjetos
{
    public class Moto : Veiculo
    {
         
        public int Cilindrada { get; set; }

        public Moto(int cilindrada) : base("Marca do carro", "Modelo do carro")
        {
            Cilindrada = cilindrada;
        }
        public virtual void ExibirCilindradas()
        {
            Console.WriteLine($"Marca: {Marca} , Modelo: {Modelo} , Cilindradas: {Cilindrada}");
        }

    };
    }
