using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models.Consts
{
    /// <summary>
    /// 
    /// </summary>
    public static  class RSAKeyValueInfo
    {
        /// <summary>
        /// pri key
        /// </summary>
        public static string Prikey { get; set; }
        /// <summary>
        /// pub key
        /// </summary>
        public static string Pubkey { get; set; }

        /// <summary>
        /// RSAKeyValueInfo:IfUseRSA
        /// </summary>
        public static bool IfUseRSA { get; set; }
        /// <summary>
        /// _config["RSAKeyValueInfo:IfUseMd5Sign"]
        /// </summary>
        public static bool IfUseMd5Sign { get; set; }
    }
}
