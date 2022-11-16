using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class cUsuario
{
    public static Usuario ObterUsuarioPeloEmailSenha(string email, string senha)
    {
        return ConsultasUsuario.ObterUsuarioPeloEmailSenha(email, senha);
    }
    public static bool VerificarUsuarioExistente(string email)
    {
        return ConsultasUsuario.VerificarUsuarioExistente(email);
    }

    public static bool NovoUsuario(string email, string senha, string nome, string data, string tipoUsuario)
    {
        return ConsultasUsuario.NovoUsuario(email, senha, nome, data, tipoUsuario);
    }
    public static List<Usuario> ObterTodosUsuarios()
    {
        return ConsultasUsuario.ObterTodosUsuarios();
    }
    public static bool AlterarUsuario(int id, string nome, string email, string senha, string data, string tipoUsuario)
    {
        return ConsultasUsuario.AlterarUsuario(id, nome, email, senha, data, tipoUsuario);
    }
    public static bool ExcluirUsuario(string data)
    {
        return ConsultasUsuario.ExcluirUsuario(data);
    }
}

