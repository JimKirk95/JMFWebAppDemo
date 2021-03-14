using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JMFWebAPI.Models
{
    /// <summary>
    /// Dados totais do jogador
    /// </summary>
    public class PlayerTotStats
    {
        /// <summary>
        /// NickName
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        /// Status One - é um inteiro, mas vai como string
        /// </summary>
        public string StOne { get; set; } = "";
        /// <summary>
        /// Status Two - também é um inteiro e vai como string
        /// </summary>
        public string StTwo { get; set; } = "";
    }
}