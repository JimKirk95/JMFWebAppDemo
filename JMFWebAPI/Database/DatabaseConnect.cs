using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace JMFWebAPI.Database
{/// <summary>
/// Classe que conecta à base de dados, mas apenas para consulta
/// A criação e atualização é feita por outra API, com outras credenciais
/// </summary>
    public class DatabaseConnect
    {
        private static string ConnectionString;
        private static void SetConnectionString()
        {
            string Server = Environment.GetEnvironmentVariable("JMFSERVER");
            string Username = Environment.GetEnvironmentVariable("JMFGET");
            string Password = Environment.GetEnvironmentVariable("JMFWORD");
            string Database = Environment.GetEnvironmentVariable("JMFDB");
            //UPDATE TO USER SECRETS OR AZURE KEY VAULT
            ConnectionString = "Data Source=" + Server + ";";
            ConnectionString += "User ID=" + Username + ";";
            ConnectionString += "Password=" + Password + ";";
            ConnectionString += "Initial Catalog=" + Database;
        }
        /// <summary>
        /// Recupera os três jogadores com mais vitórias no total
        /// </summary>
        /// <returns>Lista com o Nick e dados dos jogadores</returns>
        public static List<string[]> GetTopWins()
        {
            return GetTop($"TopWins");
        }
        /// <summary>
        /// Recupera os três jogadores com mais jogos no total
        /// </summary>
        /// <returns>Lista com o Nick e dados dos jogadores</returns>
        public static List<string[]> GetTopGames()
        {
            return GetTop($"TopGames");
        }
        /// <summary>
        /// Recupera os três jogadores com mais vitórias na semana
        /// </summary>
        /// <returns>Lista com o Nick e dados dos jogadores</returns>
        public static List<string[]> GetWeekWins()
        {
            return GetTop($"TopWeekWins");
        }
        /// <summary>
        /// Recupera os três jogadores com mais jogos na semana
        /// </summary>
        /// <returns>Lista com o Nick e dados dos jogadores</returns>
        public static List<string[]> GetWeekGames()
        {
            return GetTop($"TopWeekGames");
        }
        /// <summary>
        /// Apenas para mostrar/verificar que as credenciais não deixam acessar a tabela principal
        /// </summary>
        public static void GetPlayers()
        {   //Will not work due to permissions... just to test the permissions
            GetTop($"select * from AppUsers");
        }
        private static List<string[]> GetTop(string View)
        {
            SetConnectionString();
            string myQuery = $"select * from {View}";
            List<string[]> res = new List<string[]>(); //Retorno da função, os Top3!
            SqlDataReader dr = null; //Retorno da Query
            using (SqlConnection connection = new SqlConnection(ConnectionString))  //Cria conexão com o DB
            {
                SqlCommand command = new SqlCommand(myQuery, connection); //Cria a Query propriamente dita 
                try
                {
                    command.Connection.Open(); //Abre a conexão com o DB, que é fechada pelo "using"
                    dr = command.ExecuteReader(); //Executa a Query.
                    if (dr.HasRows) //Tem pelo menos 1 linha
                    {
                        while (dr.Read())
                        { //Para cada linha
                            string[] line = new string[dr.FieldCount];
                            for (int i = 0; i < dr.FieldCount; i++)
                            {
                                line[i] = dr[i].ToString(); //Lê as colunas
                            }
                            res.Add(line);
                        }
                    }
                    else
                    {
                        string[] error = { "Erro", "Dados não encontrados" };
                        res.Add(error);
                    }
                }
                catch (Exception e)
                {                    
                    string[] error = { "Problemas de conexão", e.Message };
                    res.Add(error);
                }
                finally
                {
                    if (dr != null)
                    {
                        dr.Close();
                    }
                }
                return res;
            }
        }
    }
}