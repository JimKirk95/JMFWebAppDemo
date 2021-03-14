using JMFWebAPI.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace JMFWebAPI.Controllers
{
    /// <summary>
    /// JMF API CONTROLLER
    /// </summary>
    public class JMFController : ApiController
    {
        /// <summary>
        /// JMF Player TOTS
        /// </summary>
        /// <returns>Players</returns>
        // GET: api/JMF
        public List<PlayerTotStats> Get()
        {
            List<PlayerTotStats> LTP = new List<PlayerTotStats>();
            List<string[]> LTD = Database.DatabaseConnect.GetTopWins();

            if (LTD.Count == 3)
            {
                foreach (string[] p in LTD)
                {
                    LTP.Add(new PlayerTotStats { Name = p[0], StOne = p[1], StTwo = p[2] });
                }
            }
            else
            {
                string[] message = LTD[0];
                LTP.Add(new PlayerTotStats { Name = "Erro", StOne = message[0], StTwo = message[1] });
            }
            return LTP;
        }
        /// <summary>
        /// Here here
        /// </summary>
        /// <param name="id">Just test</param>
        /// <returns></returns>
        // GET: api/JMF/5
        public List<PlayerWeekStats> Get(int id)
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
    }
}