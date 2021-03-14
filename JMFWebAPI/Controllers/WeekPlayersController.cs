using JMFWebAPI.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace JMFWebAPI.Controllers
{/// <summary>
/// Retorna os 3 maiores jogadores da semana
/// </summary>
    public class WeekPlayersController : ApiController
    {/// <summary>
     /// Lista com os 3 maiores jogadores da semana
     /// </summary>
     /// <returns>3 Top players, em caso de erro retorna mensagem</returns>
        // GET: api/WeekPlayers
        public List<PlayerWeekStats> Get()
        {
            List<PlayerWeekStats> LTP = new List<PlayerWeekStats>();
            List<string[]> LTD = Database.DatabaseConnect.GetWeekGames();
            if (LTD.Count == 3)
            {
                foreach (string[] p in LTD)
                {
                    LTP.Add(new PlayerWeekStats { Name = p[0], WSO = p[1], WSTw = p[2], WSTh = p[3], WSF = p[4] });
                }
            }
            else
            {
                string[] message = LTD[0];
                LTP.Add(new PlayerWeekStats { Name = "Erro", WSO = message[0], WSTw = message[1], WSTh = "", WSF = "" });
            }
            return LTP;
        }
        /// <summary>
        /// Um dos 3 maiores (1, 2 ou 3)
        /// Ou o maior jogador da semana
        /// </summary>
        /// <param name="id">Colocação</param>
        /// <returns>Jogador nessa colocação, em caso de erro retorna mensagem</returns>
        // GET: api/WeekPlayers/2
        public PlayerWeekStats Get(int id)
        {
            PlayerWeekStats P = new PlayerWeekStats();
            List<string[]> LTD = Database.DatabaseConnect.GetWeekGames();
            if ((id < 1) || id > 3) //Ajusta índice
                id = 1;
            if (LTD.Count == 3) //Tem top 3
            {
                string[] p = LTD[id - 1];
                P.Name = p[0];
                P.WSO = p[1];
                P.WSTw = p[2];
                P.WSTh = p[3];
                P.WSF = p[4];
            }
            else //Erro
            {
                string[] message = LTD[0];
                P.Name = "Erro";
                P.WSO = message[0];
                P.WSTw = message[1];
                P.WSTh = "";
                P.WSF = "";
            }
            return P;
        }
    }
}
