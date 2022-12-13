using CeCheng.SmartScenicSpot.Models.Consts;
using System.Threading.Tasks;
using Alipay.AopSdk.Core;
using Alipay.AopSdk.Core.Util;
using CeCheng.SmartScenicSpot.Models;
using System;
using System.Text;

namespace CeCheng.SmartScenicSpot.Webapi.Controller
{
    /// <summary>
    /// 
    /// </summary>
    public class CeChengRSASign
    {
        //string pubkey = "MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCthNkZ2+IDVhfKbUO4cgeUOo1yIG1L4rCIcSYIAjaJGfihJdUzSmIIylc/2SKHuWQ2asgZNAZ/1Irw3/YUadTCD8ZqFfPiL3fbpS3DxIx97pz1vseWmT0zjq5Wps0butkxf6qH2dNV+8nwpIvdKZED+B6mEYjMx5qcPQq+T+4CSwIDAQAB";
        //string prikey = "MIICXQIBAAKBgQCthNkZ2+IDVhfKbUO4cgeUOo1yIG1L4rCIcSYIAjaJGfihJdUzSmIIylc/2SKHuWQ2asgZNAZ/1Irw3/YUadTCD8ZqFfPiL3fbpS3DxIx97pz1vseWmT0zjq5Wps0butkxf6qH2dNV+8nwpIvdKZED+B6mEYjMx5qcPQq+T+4CSwIDAQABAoGASmzm6c6EXMX6olrHZz+RvKR4svDxsFDlQ0C0/U5lsdyv5f7iOYO4FOklDz/FLc35C9Y1SYolF4NErRiC5jKWjIgkhtrT15UjvW2qGnOMZf0LHT4cqq2+xCRwsNsG93O0srUCQZf4I85QwOxT4MGu7/2vRWyrMcZ3LEPQwEjByAECQQDuemNP0oOsj0jTmqAlFkHT4O8lmcNWduM1OYyUTXio1PhZcjABtDBjC//alLR+s9Al4l1NVjbYPiU+IA8AmuBLAkEAukSfV3RsCRkuksbPyUrDBZPqZESH9bKIyLy0i7J8jzzK630ml1FwLfJ+0CamyUjVNhLyO0IG+aTACzO5ARgmAQJBAIrUJMxrOMxT/YlyEpiEhH3cDFxPTzAetdZeUkBjeUKP+KPZnajgROrkKWYN+6Vm+F2VkctbzUHFq9imwRURFFECQQCmYCkbiqf9MHsDK4XpvFeaIdbZHMV8Vq4K71Ms/I55usldsnnH6zwSLmnLLtsHK4EWPbIT8BQe5GONHfP/4DwBAkAQp+IQwedkBxdRSDIc3OqdR4GlcKDXKC7vs+nRdWTUHj0ALaGS+tpR2yhkhT7bTqGYM1YaLkzoQGW2NRSlQbK7";
        //var data = Newtonsoft.Json.JsonConvert.SerializeObject(new { id = 1001, nameInfo = "Jason笑傲江湖", Price = 10.10, ctime = "2022-09-21" });
        //var encrypt = AlipaySignature.RSAEncrypt(data, pubkey, StringRsaFromartConst.UTF8, false);

        //var deCrypt = AlipaySignature.RSADecrypt(encrypt, prikey, StringRsaFromartConst.UTF8, StringRsaFromartConst.RAS, false).Replace(@"\", "");
        //return ApiResultDto.ToResultSuccess(data: deCrypt, msg: $"encrypt={encrypt}, decrypt={deCrypt}");

        /// <summary>
        /// 该函数不给到前段，给到前端公钥 前段自己加密
        /// </summary>
        /// <param name="jsondata"></param>
        /// <param name="pubkey"></param>
        /// <returns></returns>
        public static string RSAEnCrypt(string jsondata, string pubkey)
        {
            try
            {
                var encrypt = AlipaySignature.RSAEncrypt(jsondata, pubkey, StringRsaFromartConst.UTF8, false);
                return encrypt;
            }
            catch (Exception ex)
            {
                return String.Empty;
            }
        }
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="encryptData">加密后的数据</param>
        /// <param name="encodingUTF8">StringRsaFromartConst.UTF8</param>
        /// <returns></returns>
        public static string RSADecrypt(string encryptData, string encodingUTF8 = StringRsaFromartConst.UTF8)
        {
            try
            {
               //var deCrypt = AlipaySignature.RSADecrypt(encrypt, prikey, StringRsaFromartConst.UTF8, StringRsaFromartConst.RAS, false).Replace(@"\", "");
                var encrypt = AlipaySignature.RSADecrypt(encryptData, RSAKeyValueInfo.Prikey, encodingUTF8 , StringRsaFromartConst.RAS, false);
                return encrypt;
            }
            catch (Exception ex)
            {
                return String.Empty;
            }
        }
    }
}
