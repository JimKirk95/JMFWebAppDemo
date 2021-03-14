using JMFWebAPI.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace JMFWebAPI.Controllers
{/// <summary>
/// Retorna os 3 maiores vencedores
/// </summary>
    public class TopWinnersController : ApiController
    {
        /// <summary>
        /// Lista com os 3 maiores vencedores
        /// </summary>
        /// <returns>3 Top winners, em caso de erro retorna mensagem</returns>
        // GET: api/TopWinners
        public List<PlayerTotStats> Get()
        {
            List<PlayerTotStats> LTP = new List<PlayerTotStats>();
            List<string[]> LTD = Database.DatabaseConnect.GetTopWins();
            if (LTD.Count == 3) //Tem top 3
            {
                foreach (string[] p in LTD)
                {
                    LTP.Add(new PlayerTotStats { Name = p[0], StOne = p[1], StTwo = p[2] });
                }
            }
            else //Erro
            {
                string[] message = LTD[0];
                LTP.Add(new PlayerTotStats { Name = "Erro", StOne = message[0], StTwo = message[1] });
            }
            return LTP;
        }
        /// <summary>
        /// Um dos 3 maiores (1, 2 ou 3)
        /// Ou o maior vencedor
        /// </summary>
        /// <param name="id">Colocação</param>
        /// <returns>Jogador nessa colocação, em caso de erro retorna mensagem</returns>
        // GET: api/TopWinners/2
        public PlayerTotStats Get(int id)
        {
            PlayerTotStats P = new PlayerTotStats();
            List<string[]> LTD = Database.DatabaseConnect.GetTopWins();
            if ((id < 1) || id > 3) //Ajusta índice
                id = 1;
            if (LTD.Count == 3) //Tem top 3
            {
                string[] p = LTD[id - 1];
                P.Name = p[0];
                P.StOne = p[1];
                P.StTwo = p[2];
            }
            else //Erro
            {
                string[] message = LTD[0];
                P.Name = "Erro";
                P.StOne = message[0];
                P.StTwo = message[1];
            }
            return P;
        }
    }
}
