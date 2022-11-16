using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class cProduto
{
    public static bool InserirProduto(string nome, int quantidade, float precoUnitario, string fornecedor, string dataInserido)
    {
        return ConsultarProduto.InserirProduto(nome, quantidade, precoUnitario, fornecedor, dataInserido);
    }

    public static bool ExcluirProduto(int id, string dataExcluido)
    {
        return ConsultarProduto.ExcluirProduto(id, dataExcluido);
    }

    public static bool AlterarProduto(int id, string nome, int quantidade, float precoUnitario, string fornecedor, string dataAlterado)
    {
        return ConsultarProduto.AlterarProduto(id, nome, quantidade, precoUnitario, fornecedor, dataAlterado);
    }

    public static List<Produto> ObterTodosProdutos()
    {
        return ConsultarProduto.ObterTodosProdutos();
    }
}


