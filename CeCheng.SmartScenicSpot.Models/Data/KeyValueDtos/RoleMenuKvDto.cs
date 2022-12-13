using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 当做key value 来使用的通用模型
    /// </summary>
    public class RoleMenuKvDto
    {
        /// <summary>
        /// 角色id
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// 菜单id集合数据
        /// </summary>
        public List<int> MenuId { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class IntStringDicDto
    {
        /// <summary>
        /// 角色id
        /// </summary>
        public int role_id { get; set; }
        /// <summary>
        /// key 菜单id
        /// </summary>
        public int menu_id { get; set; }
        /// <summary>
        /// value
        /// </summary>
        public string namevalue { get; set; }
    }
}
