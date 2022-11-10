using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class cProduto
{
    public static bool InserirProduto(string nome, int quantidade, float precoUnitario, string fornecedor)
    {
        return ConsultarProduto.InserirProduto(nome, quantidade, precoUnitario, fornecedor);
    }

    public static bool ExcluirProduto(int id)
    {
        return ConsultarProduto.ExcluirProduto(id);
    }

    public static bool AlterarProduto(int id, string nome, int quantidade, float precoUnitario, string fornecedor)
    {
        return ConsultarProduto.AlterarProduto(id, nome, quantidade, precoUnitario, fornecedor);
    }

    public static List<Produto> ObterTodosProdutos()
    {
        return ConsultarProduto.ObterTodosProdutos();
    }
}


