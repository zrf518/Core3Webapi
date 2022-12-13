using CeCheng.SmartScenicSpot.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
namespace CeCheng.SmartScenicSpot.Commoms.GrapCode
{
    /// <summary>
    /// 验证码生成
    /// </summary>
    public class CeChengGraphImgHelper
    {
        /// <summary>
        /// 生成随机验证码图片
        /// </summary>
        /// <param name="captchaCode">随机验证码</param>
        /// <param name="width">宽为0将根据验证码长度自动匹配合适宽度</param>
        /// <param name="height">高</param>
        /// <returns></returns>
        private static MemoryStream GenerateCaptchaImage(string captchaCode, int width = 0, int height = 30)
        {
            //验证码颜色集合
            Color[] c = { Color.Black, Color.Red, Color.DarkBlue, Color.Green, Color.Orange, Color.Brown, Color.DarkCyan, Color.Purple };

            //验证码字体集合
            string[] fonts = { "Verdana", "Microsoft Sans Serif", "Comic Sans MS", "Arial" };

            //定义图像的大小，生成图像的实例
            var image = new Bitmap(width == 0 ? captchaCode.Length * 21 : width, height);

            var g = Graphics.FromImage(image);

            //背景设为白色
            g.Clear(Color.WhiteSmoke);

            var random = new Random();
            //绘制干扰点
            for (var i = 0; i < 30; i++)
            {
                var x = random.Next(image.Width);
                var y = random.Next(image.Height);
                g.DrawRectangle(new Pen(c[random.Next(c.Length)], 0), x, y, 1, 1);
            }

            //验证码绘制在g中
            for (var i = 0; i < captchaCode.Length; i++)
            {
                //随机颜色索引值
                var cindex = random.Next(c.Length);

                //随机字体索引值
                var findex = random.Next(fonts.Length);

                //字体
                var f = new Font(fonts[findex], 15, FontStyle.Bold);

                //颜色
                Brush b = new SolidBrush(c[cindex]);

                var ii = 4;
                if ((i + 1) % 2 == 0)
                    ii = 2;

                //绘制一个验证字符
                g.DrawString(captchaCode.Substring(i, 1), f, b, 10 + (i * 15), ii);
            }

            var ms = new MemoryStream();
            image.Save(ms, ImageFormat.Png);

            g.Dispose();
            image.Dispose();

            return ms;
        }

        public static ImageCodeInfoDto GetImgCode(int codelength = 4)
        {
            int[] intarry = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            List<int> listtemp = new List<int>();
            while (listtemp.Count < codelength)//小于
            {
                int code = intarry[new Random().Next(0, intarry.Length)];
                if (!listtemp.Contains(code))
                    listtemp.Add(code);
            }
            string captchaCode = string.Join("", listtemp);
            //    captchaCode = captchaCode.Length > 4 ? captchaCode.Substring(0, 4) : captchaCode;
            var gid = Guid.NewGuid().ToString("d");
            var img = new ImageCodeInfoDto();
            CeChengRedisHelper.GetRedisDB(1).StringSet(Guid.NewGuid().ToString("d"), captchaCode, TimeSpan.FromMinutes(3));
            MemoryStream ms = GenerateCaptchaImage(captchaCode);
            string arrystr = ImageToBase64(ms);
            ms.Dispose();
            img.CodeKey = gid;
            img.ImagePath = arrystr;
            return img;
        }

        private static string ImageToBase64(MemoryStream src)
        {
            return "data:image/png;base64," + Convert.ToBase64String(src.ToArray());
        }
    }
}