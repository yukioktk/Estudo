using EPAVendas.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EPAVendas
{
    public partial class Form1 : Form
    {
        List<Produtos> listaDeProdutos = new List<Produtos>();
        List<Vendas> listaDeVendas = new List<Vendas>();

        public Form1()
        {
            InitializeComponent();
            this.carregarJson();
            dataGridView1.DataSource = this.pegaDataTable();
        }

        private void button1_Click(object sender, EventArgs e) //botão salvar
        {
            Produtos produto = this.pegarDados();
            listaDeProdutos.Add(produto);
            this.limparCampos();
            dataGridView1.DataSource = this.pegaDataTable();
        }

        private Produtos pegarDados()
        {
            Produtos produtos = new Produtos();

            produtos.Nome = textBoxNome.Text;
            produtos.Descricao = textBoxDescricao.Text;
            produtos.Quantidade = textBoxQuantidade.Text;

            return produtos;
        }

        private Vendas pegarDadosVenda()
        {
            Vendas vendas = new Vendas();

            vendas.NomeComprador = textBoxNomeComprador.Text;
            vendas.EnderecoComprador = textBoxEnderecoComprador.Text;

            return vendas;
        }

        private DataTable pegaDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Nome");
            dt.Columns.Add("Descrição");
            dt.Columns.Add("Quantidade");

            foreach (Produtos umaVenda in listaDeProdutos)
            {
                dt.Rows.Add(umaVenda.Nome, umaVenda.Descricao, umaVenda.Quantidade);
            }

            return dt;
        }

        private void limparCampos()
        {
            textBoxNome.Text = "";
            textBoxDescricao.Text = "";
            textBoxQuantidade.Text = "";
        }

        private void limparCamposVenda()
        {
            textBoxNomeComprador.Text = "";
            textBoxEnderecoComprador.Text = "";
        }

        private void buttonSalvarEmjson_Click(object sender, EventArgs e)
        {
            string vendasEmJson = JsonSerializer.Serialize(listaDeProdutos);
            File.WriteAllText("Produtos.json", vendasEmJson);
        }


        private void carregarJson()
        {
            if (File.Exists("Produtos.json"))
            {
                string json = File.ReadAllText("Produtos.json");
                listaDeProdutos = JsonSerializer.Deserialize<List<Produtos>>(json) ?? new List<Produtos>();
            }
            else
            {
                listaDeProdutos = new List<Produtos>();
            }
        }

        private void buttonFinalizarVenda_Click(object sender, EventArgs e)
        {
            Vendas DadosVendas = this.pegarDadosVenda();
            List<Vendas> vendasSelecionadas = pegarDadosdataGridView();
            this.limparCamposVenda();

            foreach (var produto in vendasSelecionadas)
            {
                produto.NomeComprador = DadosVendas.NomeComprador;
                produto.EnderecoComprador = DadosVendas.EnderecoComprador;
                listaDeVendas.Add(produto);
            }


            string venda = JsonSerializer.Serialize(listaDeVendas);
            File.WriteAllText("Vendas.json", venda);
        
        }
        private List<Vendas> pegarDadosdataGridView()
        {
            List<Vendas> vendasSelecionadas = new List<Vendas>();

            foreach (DataGridViewRow linha in dataGridView1.Rows)
            {
                bool selecionado = Convert.ToBoolean(linha.Cells[0].Value);
                if (selecionado)
                {
                    Vendas vendas = new Vendas
                    {
                        NomeProdutoSelecionado = linha.Cells["Nome"].Value?.ToString(),
                        DescricaoProdutoSelecionado = linha.Cells["Descrição"].Value?.ToString(),
                        QuantidadeProdutoSelecionado = linha.Cells["Quantidade"].Value?.ToString()
                    };

                    vendasSelecionadas.Add(vendas);
                }
            }

            return vendasSelecionadas;
        }
    }
}
