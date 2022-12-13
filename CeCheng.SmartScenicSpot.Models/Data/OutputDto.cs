using CeCheng.SmartScenicSpot.Models.Consts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace CeCheng.SmartScenicSpot.Models
{
    #region MyRegion
    /// <summary>
    /// 接口数据格式返回，非泛型
    /// </summary>
    public class ApiResultDto : BaseOutputDto
    {
        /// <summary>
        /// 
        /// </summary>
        public ApiResultDto() : base()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        public object Data { get; set; }


        /// <summary>
        /// 成功返回
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="data"></param>
        /// <param name="succeed"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static ApiResultDto ToResultSuccess(string msg = SuccessFailConstStr.SuccessOpration, object data = null, bool succeed = true, int code = 200)
        {
            return new ApiResultDto()
            {
                Succeed = succeed,
                Code = code,
                Msg = msg,
                Data = data
            };
        }
        /// <summary>
        /// 失败返回
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="succeed"></param>
        /// <param name="code"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static ApiResultDto ToResultFail(string msg = SuccessFailConstStr.FailOpration, bool succeed = false, int code = 500, object data = null)
        {
            return new ApiResultDto()
            {
                Succeed = succeed,
                Code = code,
                Msg = msg,
                Data = data
            };
        }
        /// <summary>
        /// 异常返回
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="succeed"></param>
        /// <param name="code"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static ApiResultDto ToResultError(string msg = SuccessFailConstStr.ErrorOpration, bool succeed = false, int code = 500, object data = null)
        {
            return new ApiResultDto()
            {
                Succeed = succeed,
                Code = code,
                Msg = msg,
                Data = data
            };
        }
    }
    #endregion


    #region 泛型 接口返回类型
    /// <summary>
    /// 泛型 接口返回类型 强类型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ApiResultDto<T> : BaseOutputDto //// where T : class
    {
        /// <summary>
        /// 
        /// </summary>
        public ApiResultDto() : base()
        {
            Succeed = true;
            Code = 200;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        public ApiResultDto(T data) : base()
        {
            Succeed = true;
            Code = 200;
            Data = data;
        }
        /// <summary>
        /// 
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// 成功返回
        /// </summary>
        /// <param name="succeed"></param>
        /// <param name="code"></param>
        /// <param name="msg"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static ApiResultDto<T> ToResultSuccess(bool succeed = true, int code = 200, string msg = SuccessFailConstStr.SuccessOpration, T data = default)
        {
            return new ApiResultDto<T>()
            {
                Succeed = succeed,
                Code = code,
                Msg = msg,
                Data = data
            };
        }
        /// <summary>
        /// 失败返回
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="succeed"></param>
        /// <param name="code"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static ApiResultDto<T> ToResultFail(string msg = SuccessFailConstStr.FailOpration, bool succeed = false, int code = 500, T data = default)
        {
            return new ApiResultDto<T>()
            {
                Succeed = succeed,
                Code = code,
                Msg = msg,
                Data = data
            };
        }
        /// <summary>
        /// 异常返回
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="succeed"></param>
        /// <param name="code"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static ApiResultDto<T> ToResultError(string msg = SuccessFailConstStr.ErrorOpration, bool succeed = false, int code = 500, T data = default)
        {
            return new ApiResultDto<T>()
            {
                Succeed = succeed,
                Code = code,
                Msg = msg,
                Data = data
            };
        }
    }
    #endregion


    #region 分页模式
    /// <summary>
    /// 
    /// </summary>
    public class OutputPageBaseDto
    {
        /// <summary>
        /// 
        /// </summary>
        public bool Succeed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Msg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Code { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ApiResultPageNationDataDto : OutputPageBaseDto
    {
        /// <summary>
        /// 页码索引 如第几页，默认第1页
        /// </summary>
        [Range(1, int.MaxValue, ErrorMessage = "超出页码索引范围：正常应该为>=1")]
        public int PageIndex { get; set; } = 1;
        /// <summary>
        /// 一页的大小,默认20
        /// </summary>
        public int PageSize { get; set; } = 20;
        /// <summary>
        /// 总行数
        /// </summary>
        public int TotalRow { get; set; }
        /// <summary>
        /// 总的页数
        /// </summary>
        public int TotalPage
        {
            get
            {
                return TotalRow % PageSize > 0 ? (TotalRow / PageSize) + 1 : TotalRow / PageSize;
            }
        }
        /// <summary>
        /// 数据
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        ///弱类型分页，成功
        /// </summary>
        /// <param name="data"></param>
        /// <param name="succeed"></param>
        /// <param name="code"></param>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <param name="TotalRow"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static ApiResultPageNationDataDto ToResultSuccess(object data = default, bool succeed = true, int code = 200, int PageIndex = 1, int PageSize = 10, int TotalRow = 0, string msg = SuccessFailConstStr.SuccessQuery)
        {
            if (PageIndex <= 0 || PageSize <= 0)
                throw new Exception("PageIndex与PageSize不可以<=0");
            return new ApiResultPageNationDataDto()
            {
                Succeed = succeed,
                Code = code,
                Msg = msg,
                Data = data,
                PageIndex = PageIndex,
                PageSize = PageSize,
                TotalRow = TotalRow
            };
        }

        /// <summary>
        /// 弱类型分页 失败
        /// </summary>
        /// <param name="data"></param>
        /// <param name="succeed"></param>
        /// <param name="code"></param>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <param name="TotalRow"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static ApiResultPageNationDataDto ToResultFail(object data = default, bool succeed = false, int code = 500, int PageIndex = 1, int PageSize = 10, int TotalRow = 0, string msg = SuccessFailConstStr.FailQuery)
        {
            if (PageIndex <= 0 || PageSize <= 0)
                throw new Exception("PageIndex与PageSize不可以<=0");
            return new ApiResultPageNationDataDto()
            {
                Succeed = succeed,
                Code = code,
                Msg = msg,
                Data = data,
                PageIndex = PageIndex,
                PageSize = PageSize,
                TotalRow = TotalRow
            };
        }
        /// <summary>
        /// 弱类型分页 异常
        /// </summary>
        /// <param name="data"></param>
        /// <param name="succeed"></param>
        /// <param name="code"></param>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <param name="TotalRow"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static ApiResultPageNationDataDto ToResultError(object data = default, bool succeed = false, int code = 500, int PageIndex = 1, int PageSize = 10, int TotalRow = 0, string msg = SuccessFailConstStr.ErrorQuery)
        {
            if (PageIndex <= 0 || PageSize <= 0)
                throw new Exception("PageIndex与PageSize不可以<=0");
            return new ApiResultPageNationDataDto()
            {
                Succeed = succeed,
                Code = code,
                Msg = msg,
                Data = data,
                PageIndex = PageIndex,
                PageSize = PageSize,
                TotalRow = TotalRow
            };
        }
    }

    /// <summary>
    /// 强类型，泛型分页
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ApiResultPageNationTDataDto<T> : OutputPageBaseDto // where T : class, new()
    {
        /// <summary>
        /// 页码索引 如第几页，默认第1页
        /// </summary>
        [Range(1, int.MaxValue, ErrorMessage = "超出页码索引范围：正常应该为>=1")]
        public int PageIndex { get; set; } = 1;
        /// <summary>
        /// 一页的大小,默认20
        /// </summary>
        public int PageSize { get; set; } = 20;
        /// <summary>
        /// 总行数
        /// </summary>
        public int TotalRow { get; set; }
        /// <summary>
        /// 总的页数
        /// </summary>
        public int TotalPage
        {
            get
            {
                return TotalRow % PageSize > 0 ? (TotalRow / PageSize) + 1 : TotalRow / PageSize;
            }
        }
        /// <summary>
        /// 数据
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// 分页查询 成功
        /// </summary>
        /// <param name="succeed"></param>
        /// <param name="code"></param>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize">默认页大小为10</param>
        /// <param name="TotalRow"></param>
        /// <param name="msg"></param>
        /// <param name="data"></param>
        /// <returns></returns>

        public static ApiResultPageNationTDataDto<T> ToResultSuccess(T data = default, bool succeed = true, int code = 200, int PageIndex = 1, int PageSize = 10, int TotalRow = 0, string msg = SuccessFailConstStr.SuccessQuery)
        {
            if (PageIndex <= 0 || PageSize <= 0)
                throw new Exception("PageIndex与PageSize不可以<=0");

            return new ApiResultPageNationTDataDto<T>()
            {
                Succeed = succeed,
                Code = code,
                Msg = msg,
                Data = data,
                PageIndex = PageIndex,
                PageSize = PageSize,
                TotalRow = TotalRow
            };
        }

        /// <summary>
        /// 分页查询 失败
        /// </summary>
        /// <param name="succeed"></param>
        /// <param name="code"></param>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize">默认页大小为10</param>
        /// <param name="TotalRow"></param>
        /// <param name="msg"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static ApiResultPageNationTDataDto<T> ToResultFail(T data = default, bool succeed = false, int code = 500, int PageIndex = 1, int PageSize = 10, int TotalRow = 0, string msg = SuccessFailConstStr.FailQuery)
        {
            if (PageIndex <= 0 || PageSize <= 0)
                throw new Exception("PageIndex与PageSize不可以<=0");
            return new ApiResultPageNationTDataDto<T>()
            {
                Succeed = succeed,
                Code = code,
                Msg = msg,
                Data = data,
                PageIndex = PageIndex,
                PageSize = PageSize,
                TotalRow = TotalRow
            };
        }
        /// <summary>
        /// 分页查询 异常
        /// </summary>
        /// <param name="succeed"></param>
        /// <param name="code"></param>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize">默认页大小为10</param>
        /// <param name="TotalRow"></param>
        /// <param name="msg"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static ApiResultPageNationTDataDto<T> ToResultError(T data = default, bool succeed = false, int code = 500, int PageIndex = 1, int PageSize = 10, int TotalRow = 0, string msg = SuccessFailConstStr.ErrorQuery)
        {
            if (PageIndex <= 0 || PageSize <= 0)
                throw new Exception("PageIndex与PageSize不可以<=0");
            return new ApiResultPageNationTDataDto<T>()
            {
                Succeed = succeed,
                Code = code,
                Msg = msg,
                Data = data,
                PageIndex = PageIndex,
                PageSize = PageSize,
                TotalRow = TotalRow
            };
        }
    }
    #endregion
}