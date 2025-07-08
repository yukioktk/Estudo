using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAVendas.entity
{
    internal class Vendas
    {
        public string NomeComprador { get; set; }
        public string EnderecoComprador { get; set; }
        public string NomeProdutoSelecionado { get; set; }
        public string DescricaoProdutoSelecionado { get; set; }
        public string QuantidadeProdutoSelecionado { get; set; }
    }
}
