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
    /// <summary>
    /// Lógica interna para frmMenu.xaml
    /// </summary>
    public partial class frmMenu : Window
    {

        public frmMenu()
        {
            InitializeComponent();
            Main();
        }

        private void Produto(object sender, RoutedEventArgs e)
        {
            AbrirfrmGerenciarProduto();
        }

        private void AbrirfrmGerenciarProduto()
        {
            frmGerenciarProduto frmGerenciarProduto = new frmGerenciarProduto();
            frmGerenciarProduto.Show();
            
        }
        private void EfetuarVenda(object sender, RoutedEventArgs e)
        {
            
        }
        private void Abrirfrmlogin()
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            Close();
        }
        private void Usuario(object sender, RoutedEventArgs e)
        {
            AbrirfrmGerenciarUsuario();
        }
        private void AbrirfrmGerenciarUsuario()
        {
            frmGerenciarUsuario frmGerenciarUsuarios = new frmGerenciarUsuario();
            frmGerenciarUsuarios.Show();
        }

        private void Sair(object sender, RoutedEventArgs e)
        {
            Abrirfrmlogin();
        }

        public void Main()
        {
            string data = DateTime.Now.ToString(" d MMMM yyyy ");
            txtblockNome.Text = $"Olá , hoje é dia {data}";
        }
        

    }



}
