using Microsoft.Data.Sqlite;
using SistemaComercial.Models;
using System;
using System.Collections.Generic;

public class ProdutoRepository
{
    // LISTAR TODOS
    public static List<Produto> Listar()
    {
        var lista = new List<Produto>();

        using (var conn = Database.GetConnection())
        {
            conn.Open();

            string sql = "SELECT * FROM Produtos";

            using (var cmd = new SqliteCommand(sql, conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var produto = new Produto
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nome = reader["Nome"].ToString(),
                        Preco = Convert.ToDecimal(reader["Preco"]),
                        Quantidade = Convert.ToInt32(reader["Quantidade"]),
                        Validade = reader["Validade"] != DBNull.Value
                            ? DateTime.Parse(reader["Validade"].ToString())
                            : DateTime.MinValue
                    };

                    lista.Add(produto);
                }
            }
        }

        return lista;
    }

    // INSERIR
    public static void Inserir(Produto produto)
    {
        using (var conn = Database.GetConnection())
        {
            conn.Open();

            string sql = @"INSERT INTO Produtos 
                           (Nome, Preco, Quantidade, Validade)
                           VALUES 
                           (@nome, @preco, @quantidade, @validade)";

            using (var cmd = new SqliteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@nome", produto.Nome);
                cmd.Parameters.AddWithValue("@preco", produto.Preco);
                cmd.Parameters.AddWithValue("@quantidade", produto.Quantidade);
                cmd.Parameters.AddWithValue("@validade", produto.Validade);

                cmd.ExecuteNonQuery();
            }
        }
    }

    // ATUALIZAR
    public static void Atualizar(Produto p)
    {
        using (var connection = Database.GetConnection())
        {
            connection.Open();

            string sql = @"UPDATE Produtos 
                           SET Nome = @Nome,
                               Preco = @Preco,
                               Quantidade = @Quantidade,
                               Validade = @Validade
                           WHERE Id = @Id";

            using (var command = new SqliteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Nome", p.Nome);
                command.Parameters.AddWithValue("@Preco", p.Preco);
                command.Parameters.AddWithValue("@Quantidade", p.Quantidade);
                command.Parameters.AddWithValue("@Validade", p.Validade);
                command.Parameters.AddWithValue("@Id", p.Id);

                command.ExecuteNonQuery();
            }
        }
    }

    // EXCLUIR
    public static void Excluir(int id)
    {
        using (var connection = Database.GetConnection())
        {
            connection.Open();

            string sql = "DELETE FROM Produtos WHERE Id = @Id";

            using (var command = new SqliteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqliteException ex)
                {
                    MessageBox.Show("Não é possível excluir. Produto possui registros vinculados.");
                }
            }
        }
    }
    public static bool ProdutoEstaEmUso(int id)
    {
        using (var conn = Database.GetConnection())
        {
            conn.Open();

            string sql = "SELECT COUNT(*) FROM ItensVenda WHERE ProdutoId = @id";

            using (var cmd = new SqliteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);

                long count = (long)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }

    // BUSCAR
    public static List<Produto> Buscar(string termo)
    {
        var lista = new List<Produto>();

        using (var conn = Database.GetConnection())
        {
            conn.Open();

            string sql = "SELECT * FROM Produtos WHERE Nome LIKE @termo";

            using (var cmd = new SqliteCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@termo", "%" + termo + "%");

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Produto
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nome = reader["Nome"].ToString(),
                            Preco = Convert.ToDecimal(reader["Preco"]),
                            Quantidade = Convert.ToInt32(reader["Quantidade"]),
                            Validade = reader["Validade"] != DBNull.Value
                                ? DateTime.Parse(reader["Validade"].ToString())
                                : DateTime.MinValue
                        });
                    }
                }
            }
        }

        return lista;
    }
}