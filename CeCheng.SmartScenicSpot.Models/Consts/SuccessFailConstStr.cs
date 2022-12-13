using System;
using System.Collections.Generic;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models.Consts
{
    /// <summary>
    /// 接口成功失败等 字符串
    /// </summary>
    public class SuccessFailConstStr
    {
        /// <summary>
        /// 查询成功
        /// </summary>
        public const string SuccessQuery = "查询成功";
        /// <summary>
        /// 查询失败
        /// </summary>
        public const string FailQuery = "查询失败";

        /// <summary>
        /// 查询异常
        /// </summary>
        public const string ErrorQuery = "查询异常";
        /// <summary>
        /// 操作成功
        /// </summary>
        public const string SuccessOpration = "操作成功";
        /// <summary>
        /// 操作失败
        /// </summary>
        public const string FailOpration = "操作失败";

        /// <summary>
        /// 操作异常
        /// </summary>
        public const string ErrorOpration = "操作异常";

        /// <summary>
        /// 新增成功
        /// </summary>
        public const string  SuccessAdd= "新增成功";
        /// <summary>
        /// 新增失败
        /// </summary>
        public const string FailAdd = "新增失败";

        /// <summary>
        /// 新增异常
        /// </summary>
        public const string ErrorAdd = "新增异常";

        /// <summary>
        /// 编辑成功
        /// </summary>
        public const string SuccessEdit = "编辑成功";
        /// <summary>
        /// 编辑失败
        /// </summary>
        public const string FailEdit = "编辑失败";
        /// <summary>
        /// 编辑异常
        /// </summary>
        public const string ErrorEdit = "编辑异常";

        /// <summary>
        /// 租户id必填
        /// </summary>
        public const string TenantIdNoData = "租户id必填";



        /// <summary>
        /// 存在必填参数，请检查
        /// </summary>
        public const string ValidateError = "输入的数据存在错误或者必填项，请检查";

        /// <summary>
        /// 存在必填参数或者数据格式不正确的情况，请检查
        /// </summary>
        public const string ValidaDataNotFonud = "存在必填参数或者数据格式不正确的情况，请检查";

        /// <summary>
        /// 该数据已经存在关联关系不可以删除
        /// </summary>
        public const string ThisDataHaveRerationCantRemove = "该数据已经存在关联关系不可以删除";


    }
}
