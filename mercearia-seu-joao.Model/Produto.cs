using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Produto
{
    public int id { get; set; }
    public string nome { get; set; }
    public int qtdEstoque { get; set; }
    public float precoUnitario { get; set; }
    public string fornecedor { get; set; }
    public string dataInserido { get; set; }
    public string dataAlterado { get; set; }
    public string dataExcluido { get; set; }
}

