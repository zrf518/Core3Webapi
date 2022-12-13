using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CeCheng.SmartScenicSpot.Commoms
{
    public class CeChengMd5Helper
    {
        public static string GetMd5Str(string password)
        {
            var md5 = MD5.Create();
            // 加密后是一个字节类型的数组，这里要注意编码UTF8/Unicode等的选择　
            byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            // 通过使用循环，将字节类型的数组转换为字符串，此字符串是常规字符格式化所得
            //密文
            var sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                // 将得到的字符串使用十六进制类型格式。
                //格式后的字符是小写的字母，如果使用大写（X）则格式后的字符是大写字符
                //X2表示16进制
                sb.Append(s[i].ToString("X2"));
                //sb.Append(s[i].ToString());
            }
            return sb.ToString();
        }
    }
}
