using System;
using System.Collections.Generic;
using System.Text;
namespace CeCheng.SmartScenicSpot.Services
{
    using CeCheng.SmartScenicSpot.Commoms;
    using CeCheng.SmartScenicSpot.Models;
    using Microsoft.AspNetCore.Http;
    using AutoMapper;
    public class CeChengBaseService
    {
        /// <summary>
        /// 用户数据
        /// </summary>
        public UserTokenInfo _UserTokenInfo { get; set; }
        /// <summary>
        /// 访问上下文访问者
        /// </summary>
        public CeChengBaseService(IHttpContextAccessor httpContextAccessor)
        {
            if (httpContextAccessor.HttpContext != null)
                _UserTokenInfo = CeChengTokenHelper.GetTockenUserInfo(httpContextAccessor.HttpContext);
        }
    }
    public class CeChengBaseWithMapperService
    {
        /// <summary>
        /// 用户数据
        /// </summary>
        public UserTokenInfo _UserTokenInfo { get; set; }
        public IMapper _Mapper { get; set; }
        /// <summary>
        /// 访问上下文访问者
        /// </summary>
        public CeChengBaseWithMapperService(IHttpContextAccessor httpContextAccessor, IMapper mapper)
        {
            if (httpContextAccessor.HttpContext != null)
                _UserTokenInfo = CeChengTokenHelper.GetTockenUserInfo(httpContextAccessor.HttpContext);
            _Mapper = mapper;
        }
    }
}
