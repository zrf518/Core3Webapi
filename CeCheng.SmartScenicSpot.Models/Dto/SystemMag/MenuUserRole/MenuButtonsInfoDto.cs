using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    /// <summary>
    /// 菜单下面的按钮信息
    /// </summary>
    public class MenuButtonsInfoDto
    {
        //menu_id,menu_name,parent_id,order_number 
        /// <summary>
        /// 按钮主键id
        /// </summary>
        public int menu_id { get; set; }
        /// <summary>
        /// 按钮名称
        /// </summary>
        public string menu_name { get; set; }
        /// <summary>
        /// 属于菜单的按钮的菜单id
        /// </summary>
        public int parent_id { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int order_number { get; set; }

    }
}
