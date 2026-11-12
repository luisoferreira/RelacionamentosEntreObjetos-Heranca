using System;
using System.Dynamic;

namespace RelacionamentosEntreObjetos
{
    public abstract class ProdutoDigital
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; } // Alterado para decimal

        public ProdutoDigital(string nome, decimal preco) // Alterado para decimal
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual void ExibirProduto()
        {
            Console.WriteLine($"O seu Produto é: {Nome} , {Preco}");
        }
    }



}