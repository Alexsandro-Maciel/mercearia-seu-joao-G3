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


namespace mercearia_seu_joao.View
{
    public partial class frmGerenciarProduto : Window
    {
        List<Produto> listaDeProdutos = new List<Produto>();
        public frmGerenciarProduto()
        {
            InitializeComponent();
        }

        private bool VerificaCampos()
        {
            if (txtNome.Text != "" && boxNome.Text != "" && boxPrecoUnitario.Text != "" && boxQuantidade.Text != "" && boxFornecedor.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void NovoProduto(object sender, RoutedEventArgs e)
        {
            if (VerificaCampos() == true)
            {
                if (boxId.Text == "")
                {
                    AdicionaProduto();
                }
                else
                {
                    Mensagens.ExibirMensagemIdCampoPreenchido();
                }
            }
            else
            {
                Mensagens.ExibirMensagemPreencherCampos();
            }
        }

        private void LimpaTodosOsCampos()
        {
            boxId.Text = "";
            boxNome.Text = "";
            boxQuantidade.Text = "";
            boxFornecedor.Text = "";
            boxPrecoUnitario.Text = "";
        }

        private void LimparCampos(object sender, RoutedEventArgs e)
        {
            LimpaTodosOsCampos();
        }

        private void AtualizarProduto(object sender, RoutedEventArgs e)
        {
            if (boxId.Text != "")
            {
                int id = int.Parse(boxId.Text);
                MessageBoxResult result = MessageBox.Show(
                    $"Deseja alterar o produto id:{id} ?",
                    "Alterar Produto",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    string dataAlterado = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    bool foiAtualizado = cProduto.AlterarProduto(
                        id,
                        boxNome.Text,
                        Int32.Parse(boxQuantidade.Text),
                        Single.Parse(boxPrecoUnitario.Text),
                        boxFornecedor.Text,
                        dataAlterado
                        );

                    if (foiAtualizado == true)
                    {
                        Mensagens.ExibirMensagemProdutoAtualizado();
                        LimpaTodosOsCampos();
                        AtualizaDataGrid();
                    }
                    else
                    {
                        Mensagens.ExibirMensagemErroProdutoAtualizado();
                    }
                }
            }
        }

        private void ExcluirProduto(object sender, RoutedEventArgs e)
        {
            if (boxId.Text != "")
            {
                int id = int.Parse(boxId.Text);
                MessageBoxResult result = MessageBox.Show(
                    $"Deseja excluir o produto id:{id} ?",
                    "Excluir Produto",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    string dataExcluido = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    bool foiExcluido = cProduto.ExcluirProduto(id, dataExcluido);
                    if (foiExcluido == true)
                    {
                        Mensagens.ExibirMensagemProdutoExcluido();

                        LimpaTodosOsCampos();
                        AtualizaDataGrid();
                    }
                    else
                    {
                        Mensagens.ExibirMensagemErroProdutoExcluido();
                    }
                }
            }
        }

        private void AdicionaProduto()
        {
            string dataInserido = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            bool foiInserido = cProduto.InserirProduto(
                boxNome.Text,
                Int32.Parse(boxQuantidade.Text),
                Single.Parse(boxPrecoUnitario.Text),
                boxFornecedor.Text,
                dataInserido
                );
           

            if (foiInserido == false)
            {
                Mensagens.ExibirMensagemProdutoCadastrado();
                AtualizaDataGrid();
                LimpaTodosOsCampos();
            }
            else
            {
                Mensagens.ExibirMensagemErroProdutoCadastrado();
            }
        }

        private void AtualizaDataGrid()
        {
            listaDeProdutos.Clear();
            listaDeProdutos = cProduto.ObterTodosProdutos();
            dgvProdutos.ItemsSource = listaDeProdutos;
            dgvProdutos.Items.Refresh();
        }

        private void PegarItemNoGrid(object sender, MouseButtonEventArgs e)
        {
            Produto produto = (Produto)
            dgvProdutos.SelectedItem;
            boxId.Text = produto.id.ToString();
            boxNome.Text = produto.nome;
            boxQuantidade.Text = produto.qtdEstoque.ToString();
            boxPrecoUnitario.Text = produto.precoUnitario.ToString();
            boxFornecedor.Text = produto.fornecedor;
        }

        private void Sair(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
