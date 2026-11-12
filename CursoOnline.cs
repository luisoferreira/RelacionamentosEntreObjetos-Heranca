using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionamentosEntreObjetos
{
    public class CursoOnline : ProdutoDigital
    {
        public int CargaHoraria { get; set; }

        public CursoOnline(string nome , decimal preco , int cargaHoraria) : base(nome,preco)
        {
            CargaHoraria = cargaHoraria;
        }
          public virtual void ExibirCursoOnline()
        {
            Console.WriteLine($"O seu Curso é: {Nome} ,custa:{Preco} e possui {CargaHoraria} horas de duração.");
        }
    }
    }

