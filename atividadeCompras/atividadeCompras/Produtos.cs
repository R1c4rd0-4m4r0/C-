using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeCompras
{
    internal class Produtos
    {
        public string Codigo;
        public string Descricao;
        public float Preco;
        public float QuantEstoque;
        public string Unidade;

        public Produtos(string codigo, string descricao, float preco, string quantEstoque)
        {
            Codigo = codigo;
            Descricao = descricao;
            Preco = preco;
            QuantEstoque = quantEstoque;
        }


    }
}
