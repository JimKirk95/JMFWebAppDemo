using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JMFWebAPI.Models
{
    /// <summary>
    /// Dados da semana e totais do jogador
    /// </summary>
    public class PlayerWeekStats
    {
        /// <summary>
        /// Nickname
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        /// Status Semanal 1, é inteiro, mas vai como string
        /// </summary>
        public string WSO { get; set; } = "";
        /// <summary>
        /// Status Semanal 2, é inteiro, mas vai como string
        /// </summary>
        public string WSTw { get; set; } = "";
        /// <summary>
        /// Status Total 1, é inteiro, mas vai como string
        /// </summary>
        public string WSTh { get; set; } = "";
        /// <summary>
        /// Status Total 2, é inteiro, mas vai como string
        /// </summary>
        public string WSF { get; set; } = "";
    }
}