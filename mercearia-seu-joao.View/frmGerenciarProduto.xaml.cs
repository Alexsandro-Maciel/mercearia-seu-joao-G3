using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

public class GerenciarProduto
{
    public static bool InserirProduto(string nome, int qtdEstoque, float precoUnitario, string fornecedor)
    {
        return ConsultarProduto.InserirProduto(nome, qtdEstoque, precoUnitario, fornecedor);
    }

    public static bool ExcluirProduto(int id)
    {
        return ConsultarProduto.ExcluirProduto(id);
    }

    public static bool AlterarProduto(int id, string nome, int qtdEstoque, float precoUnitario, string fornecedor)
    {
        return ConsultarProduto.AlterarProduto(id, nome, qtdEstoque, precoUnitario, fornecedor);
    }

    public static List<Produto> ObterTodosProdutos()
    {
        return ConsultarProduto.ObterTodosProdutos();
    }

    private void LimpaTodosOsCampos(int boxId, string boxNome, int boxQuantidade, float boxPrecoUnitario, string boxFornecedor)
    {
        boxId.Text = "";
        boxNome.Text = "";
        boxQuantidade.Text = "";
        boxPrecoUnitario.Text = "";
        boxFornecedor.Text = "";
    }

    private void LimparCampos(object sender, RoutedEventArgs e)
    {
        LimpaTodosOsCampos();
    }
}

