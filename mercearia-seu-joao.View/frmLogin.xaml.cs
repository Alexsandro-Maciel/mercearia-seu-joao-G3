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
    public partial class frmLogin : Window
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void EsqueceuSenha(object sender, MouseButtonEventArgs e)
        {
            Mensagens.MensagemContateGerente();
        }

        private void RealizarLogin(object sender, RoutedEventArgs e)
        {

        }

        private void Fechar(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}
