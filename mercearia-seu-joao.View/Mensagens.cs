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
}
