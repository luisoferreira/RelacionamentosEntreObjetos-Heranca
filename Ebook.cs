using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentosEntreObjetos
{
    public class Ebook : ProdutoDigital
    {
        public int QuantidadePaginas { get; set; }

        public Ebook(string nome, decimal preco, int quantidadePaginas) : base(nome, preco)

        {
            QuantidadePaginas = quantidadePaginas;
        }
  public virtual void ExibirEbook()
        {
            Console.WriteLine($"O seu Produto é: {Nome} ,Custa: {Preco},e tem {QuantidadePaginas} páginas.");
        }
    }
    }
