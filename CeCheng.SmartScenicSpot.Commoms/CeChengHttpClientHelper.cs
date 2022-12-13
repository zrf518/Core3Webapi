using CeCheng.SmartScenicSpot.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
namespace CeCheng.SmartScenicSpot.Commoms
{
    public class CeChengHttpClientHelper
    {
        /// <summary>
        ///  服务之间的同步网络请求Post（同步方法，非异步方法）
        /// </summary>
        /// <param name="apiFullpath">请求全路径如：http://wwwbaidu.com/api/aa/controllerNam/actionName </param>
        /// <param name="dataDto">约定为一个实体对象 如：var datatDto = new { Id = 1001, Name = "LMZ",Age=18 }</param>
        /// <param name="tokenStr">远程服务器需要的token</param>
        /// <returns></returns>
        public static string PostHost(string apiFullpath, string tokenStr = null, object dataDto = null)
        {
            if (string.IsNullOrEmpty(apiFullpath))
                throw new Exception("请求服务的具体接口地址不可以为空!");
            if (!apiFullpath.Contains("http") && !apiFullpath.Contains("https"))
                throw new Exception("接口地址错误，应该为如：http:www.qq.com/api/AbcService/Controller/Action");
            if (null == dataDto)
                throw new Exception("请求参数不可以为空!");

            WebClient webClient = new WebClient();
            webClient.Encoding = System.Text.Encoding.UTF8;//防止乱码
            webClient.Headers.Add("Content-Type", "application/json"); 
            webClient.Headers.Add(WebApiHeaderStrConst.Head_Authorization, tokenStr);
            string postString = JsonConvert.SerializeObject(dataDto);
            string responseData = webClient.UploadString(apiFullpath, "POST", postString);//得到返回字符流  
            return responseData;

        }

        /// <summary>
        ///  服务之间的网络请求Post
        /// </summary>
        /// <param name="apiFullpath">请求全路径如：http://wwwbaidu.com/api/aa/controllerNam/actionName </param>
        /// <param name="dataDto">约定为一个实体对象 如：var datatDto = new { Id = 1001, Name = "LMZ",Age=18 }</param>
        /// <param name="tokenStr">远程服务器需要的token</param>
        /// <param name="timeOut">默认连接超时时间为20秒</param>
        /// <returns></returns>
        public static async Task<T> PostSelfHostAsync<T>(string apiFullpath, string tokenStr = null, object dataDto = null, int timeOut = 50)
        {
            if (string.IsNullOrEmpty(apiFullpath))
                throw new Exception("请求服务的具体接口地址不可以为空!");
            if (!apiFullpath.Contains("http") && !apiFullpath.Contains("https"))
                throw new Exception("接口地址错误，应该为如：http:www.qq.com/api/AbcService/Controller/Action");
            string content = dataDto != null ? JsonConvert.SerializeObject(dataDto) : "0";
            var jsonDataStr = new StringContent(content, Encoding.UTF8, WebApiHeaderStrConst.Head_MediaType);
          //  using var client = _httpClientFactory.CreateClient();
            using  HttpClient client = new HttpClient();
            if (tokenStr != null)
                client.DefaultRequestHeaders.Add(WebApiHeaderStrConst.Head_Authorization, tokenStr);
            var connectTimeOut = timeOut <= 0 || timeOut > 180 ? 20 : timeOut;
            client.Timeout = TimeSpan.FromSeconds(connectTimeOut);
            using (var httpResponseMsg = await client.PostAsync(apiFullpath, jsonDataStr))
            {
                if (httpResponseMsg.IsSuccessStatusCode)
                {
                    var getstr = await httpResponseMsg.Content.ReadAsStringAsync();
                    Console.WriteLine("getStr=" + getstr);
                    return JsonConvert.DeserializeObject<T>(getstr);
                }
                else
                {
                    throw new Exception("服务调用异常失败，请检查服务之间的地址，端口等配置信息，路径是否正确！");
                }
            };
        }

        /// <summary>
        ///  服务之间的网络请求，GetSelfHostAsync,自定义全路径
        /// </summary>
        /// <param name="tokenStr">远程服务器需要的token</param>
        /// <param name="apiFullpath">请求的全路径, 如：http://wwwbaodu.com/api/acService/abc/testapi </param>
        /// <param name="requestDataDic">约定为一个实体对象 如：var datatDto = new { Id = 1001, Name = "LMZ",Age=18 }</param>
        /// <param name="timeOut">默认连接超时时间为20秒</param>
        /// <returns></returns>
        public static async Task<T> GetSelfHostAsync<T>(string apiFullpath, string tokenStr = null, Dictionary<string, object> requestDataDic = null, int timeOut = 20) where T : class, new()
        {
            if (string.IsNullOrEmpty(apiFullpath))
                throw new Exception("请求服务的具体接口地址不可以为空!");
            if (!apiFullpath.Contains("http") && !apiFullpath.Contains("https"))
                throw new Exception("接口地址错误，应该为如：http:www.qq.com/api/AbcService/ControllerName/Action");
            using HttpClient client =new HttpClient();
            if (!string.IsNullOrEmpty(tokenStr))
                client.DefaultRequestHeaders.Add(WebApiHeaderStrConst.Head_Authorization, tokenStr);
            var connectTimeOut = timeOut <= 0 || timeOut > 180 ? 20 : timeOut;
            client.Timeout = TimeSpan.FromSeconds(connectTimeOut);
            var sb = new StringBuilder();
            if (requestDataDic != null)
            {
                foreach (var dickey in requestDataDic.Keys)
                    sb.Append($"&{dickey}={requestDataDic[dickey]}");
            }
            string requestData = $"{apiFullpath}?lmz_temp=0{sb}";
            using (var httpResponseMsg = await client.GetAsync(requestData))
            {
                if (httpResponseMsg.IsSuccessStatusCode)
                {
                    var getstr = await httpResponseMsg.Content.ReadAsStringAsync();
                    Console.WriteLine("getStr=" + getstr + ", sbdata=" + sb);
                    return JsonConvert.DeserializeObject<T>(getstr);
                }
                else
                {
                    throw new Exception("服务调用异常失败，请检查服务之间的地址，端口等配置信息，路径是否正确！");
                }
            }
        }
    }
}
