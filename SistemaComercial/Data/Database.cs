using Microsoft.Data.Sqlite;

public class Database
{
    private static string connectionString =
        $"Data Source={AppDomain.CurrentDomain.BaseDirectory}estoque.db";

    public static SqliteConnection GetConnection()
    {
        return new SqliteConnection(connectionString);
    }

    public static void CriarTabela()
    {
        using (var conn = GetConnection())
        {
            conn.Open();

            // CRIA PRODUTOS SE NÃO EXISTIR
            string sqlProdutos = @"
            CREATE TABLE IF NOT EXISTS Produtos (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Nome TEXT NOT NULL,
                Preco REAL NOT NULL,
                Quantidade INTEGER NOT NULL,
                Validade TEXT
            );";
            new SqliteCommand(sqlProdutos, conn).ExecuteNonQuery();


            // CRIA VENDAS SE NÃO EXISTIR
            string sqlVendas = @"
            CREATE TABLE IF NOT EXISTS Vendas (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                ProdutoId INTEGER NOT NULL,
                Quantidade INTEGER NOT NULL,
                DataVenda TEXT NOT NULL,
                MetodoPagamento TEXT NOT NULL,
                FOREIGN KEY (ProdutoId) REFERENCES Produtos(Id)
            );";
            new SqliteCommand(sqlVendas, conn).ExecuteNonQuery();


            // CRIA CAIXA SE NÃO EXISTIR
            string sqlCaixa = @"
            CREATE TABLE IF NOT EXISTS Caixa (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Tipo TEXT NOT NULL,
                Valor REAL NOT NULL,
                Descricao TEXT,
                DataMovimento TEXT NOT NULL,
                MetodoPagamento TEXT NOT NULL
            );";
            new SqliteCommand(sqlCaixa, conn).ExecuteNonQuery();
        }
    }
}