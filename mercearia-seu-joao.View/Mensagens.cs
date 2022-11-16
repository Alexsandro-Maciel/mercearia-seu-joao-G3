using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

public static class Mensagens
{
    public static void MensagemContateGerente()
    {
        MessageBox.Show("Por favor, contate seu gerente.",
                        "Informação",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information
                        );
    }

    public static void MensagemPreenchaTodosCampos()
    {
        MessageBox.Show("Preencha todos os campos.",
                        "Atenção",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning
                        );
    }

    public static void MensagemDadosIncorretos()
    {
        MessageBox.Show("Email e/ou senha incorretos.",
                        "Atenção",
                        MessageBoxButton.OK,
                        MessageBoxImage.Warning
                        );
    }

    public static void ExibirMensagemIdCampoPreenchido()
    {
        MessageBoxResult result = MessageBox.Show(
                            "Limpe o campo Id para poder inserir!",
                            "Atenção",
                            MessageBoxButton.OK,
                            MessageBoxImage.Warning);
    }

    public static void ExibirMensagemPreencherCampos()
    {
        MessageBoxResult result2 = MessageBox.Show(
                    "Preencha todos os campos",
                    "Atenção",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
    }



    public static void ExibirMensagemProdutoCadastrado()
    {
        MessageBoxResult result3 = MessageBox.Show(
                    "O produto foi adicionado com sucesso!",
                    "Informação",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
    }

    public static void ExibirMensagemErroProdutoCadastrado()
    {
        MessageBoxResult result4 = MessageBox.Show(
                            "Não possível inserir o Produto, tente novamente mais tarde!",
                            "Atenção",
                            MessageBoxButton.OK,
                            MessageBoxImage.Warning);
    }

    public static void ExibirMensagemErroProdutoAtualizado()
    {
        MessageBoxResult result5 = MessageBox.Show(
                         "Não possível atualizar o Produto, tente novamente mais tarde!",
                         "Atenção",
                          MessageBoxButton.OK,
                          MessageBoxImage.Error);
    }

    public static void ExibirMensagemProdutoAtualizado()
    {
        MessageBoxResult result6 = MessageBox.Show(
                         "Produto foi atualizado com sucesso!",
                         "Informação",
                          MessageBoxButton.OK,
                          MessageBoxImage.Information);
    }

    public static void ExibirMensagemProdutoExcluido()
    {
        MessageBoxResult result7 = MessageBox.Show(
                            "Produto foi excluido com sucesso!",
                            "Informação",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
    }

    public static void ExibirMensagemErroProdutoExcluido()
    {
        MessageBoxResult result8 = MessageBox.Show(
                             "Não possível excluir o Produto, tente novamente mais tarde!",
                             "Error",
                             MessageBoxButton.OK,
                             MessageBoxImage.Error);
    }
    public static void ExibirMensagemUsuarioAdicionado()
    {
        MessageBoxResult result9 = MessageBox.Show(
                             "O produto foi adicionado com sucesso!",
                             "Informação",
                             MessageBoxButton.OK,
                             MessageBoxImage.Error);
    }
    public static void ExibirMensagemErroUsuarioCadastrado()
    {
        MessageBoxResult result10 = MessageBox.Show(
                            "Não possível inserir o Usuario, tente novamente mais tarde!",
                            "Atenção",
                            MessageBoxButton.OK,
                            MessageBoxImage.Warning);
    }
    public static void ExibirMensagemUsuarioAtualizado()
    {
        MessageBoxResult result11 = MessageBox.Show(
                         "Usuario foi atualizado com sucesso!",
                         "Informação",
                          MessageBoxButton.OK,
                          MessageBoxImage.Information);
    }
    public static void ExibirMensagemErroUsuarioAtualizado()
    {
        MessageBoxResult result12 = MessageBox.Show(
                         "Não possível atualizar o Usuario, tente novamente mais tarde!",
                         "Atenção",
                          MessageBoxButton.OK,
                          MessageBoxImage.Error);
    }
    public static void ExibirMensagemUsuarioExcluido()
    {
        MessageBoxResult result13 = MessageBox.Show(
                            "Usuario foi excluido com sucesso!",
                            "Informação",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
    }

    public static void ExibirMensagemErroUsuarioExcluido()
    {
        MessageBoxResult result14 = MessageBox.Show(
                             "Não possível excluir o usuario, tente novamente mais tarde!",
                             "Error",
                             MessageBoxButton.OK,
                             MessageBoxImage.Error);
    }
}

