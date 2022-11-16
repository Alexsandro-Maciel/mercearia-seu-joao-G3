using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

public static class ConsultasUsuario
{
    public static Usuario ObterUsuarioPeloEmailSenha(string email, string senha)
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        Usuario usuario = null;
        string senhaCriptografada = Criptografia.CriptografarMD5(senha);

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"Select * from usuario Where email = @email and senha = @senha";
            comando.Parameters.AddWithValue("@senha", senhaCriptografada);
            comando.Parameters.AddWithValue("@email", email);
            var leitura = comando.ExecuteReader();

            while (leitura.Read())
            {
                usuario = new Usuario();
                usuario.id = leitura.GetInt32("id");
                usuario.nome = leitura.GetString("nome");
                usuario.tipoUsuario = leitura.GetString("tipoUsuario");
                usuario.email = leitura.GetString("email");
                usuario.senha = leitura.GetString("senha");
                usuario.dataInserido = leitura.GetString("dataInserido");
                usuario.dataAlterado = leitura.GetString("dataAlterado");
                usuario.dataExcluido = leitura.GetString("dataExcluido");
                break;
            }
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        finally
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        return usuario;
    }
    public static bool VerificarUsuarioExistente(string email)
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        bool usuarioExiste = false;

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"Select * from usuario Where email = @email";
            comando.Parameters.AddWithValue("@email", email);
            var leitura = comando.ExecuteReader();
            while (leitura.Read())
            {
                usuarioExiste = true;
                break;
            }
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        finally
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        return usuarioExiste;
    }
    public static bool NovoUsuario(string email, string senha, string nome, string data, string tipoUsuario)
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        bool foiInserido = false;
        string senhaCriptografada = Criptografia.CriptografarMD5(senha);

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"Insert Into usuario (email, senha, nome, dataInserido, dataExcluido, tipoUsuario) Values (@email, @senha, @nome, @data, null, @tipoUsuario )";
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@senha", senhaCriptografada);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@data", data);
            comando.Parameters.AddWithValue("@tipoUsuario", tipoUsuario);
            var leitura = comando.ExecuteReader();
            foiInserido = true;
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        finally
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        return foiInserido;
    }
    public static bool ExcluirUsuario(string data)
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        bool foiExcluido = false;

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"Insert Into usuario(dataExcluido) Values(@data) WHERE id = @id;";
            comando.Parameters.AddWithValue("@data", data);
            var leitura = comando.ExecuteReader();
            foiExcluido = true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
        return foiExcluido;
    }
    public static bool AlterarUsuario(int id, string nome, string email, string senha, string data, string tipoUsuario)
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        bool foiAtualizado = false;
        string senhaCriptografada = Criptografia.CriptografarMD5(senha);

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"
                UPDATE usuario 
                SET nome = @nome, email = @email, senha = @senha, dataAlterado = @data, tipoUsuario = @tipoUsuario, dataExcluido = null
                WHERE id = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@senha", senhaCriptografada);
            comando.Parameters.AddWithValue("@data", data);
            comando.Parameters.AddWithValue("@tipoUsuario", tipoUsuario);
            var leitura = comando.ExecuteReader();
            foiAtualizado = true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
        return foiAtualizado;
    }
    public static List<Usuario> ObterTodosUsuarios()
    {
        var conexao = new MySqlConnection(ConexaoBD.Connection.ConnectionString);
        List<Usuario> listaDeUsuarios = new List<Usuario>();

        try
        {
            conexao.Open();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"
                SELECT * FROM usuario ";
            var leitura = comando.ExecuteReader();
            while (leitura.Read())
            {
                Usuario usuario = new Usuario();
                usuario.id = leitura.GetInt32("id");
                usuario.nome = leitura.GetString("nome");
                usuario.email = leitura.GetString("email");
                usuario.senha = leitura.GetString("senha");
                listaDeUsuarios.Add(usuario);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
        return listaDeUsuarios;
    }
}
