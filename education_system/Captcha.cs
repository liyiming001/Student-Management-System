using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace education_system
{
    class Captcha
    {
        //本类用于生成图形验证码

        /// <summary>
        /// 产生纯数字验证码
        /// </summary>
        /// <param name="num">输入需要产生几位验证码</param>
        /// <returns>返回生成的验证码</returns>
        public static string GetRandomNum(int Num)
        {
            string str = null;
            //创建随机数
            Random rng = new Random();
            for (int i = 0; i < Num; i++)
            {
                str += (rng.Next(0, 10)).ToString();
            }
            return str;
        }

        /// <summary>
        /// 获取验证码图片流
        /// </summary>
        /// <param name="CheckCode">验证码字符串</param>
        /// <returns>返回验证码图片</returns>
        public static Bitmap CreateCodeImg(string CheckCode)
        {
            if (CheckCode.Length == 0)
            {
                return null;
            }
            //设置位图宽高
            Bitmap image = new Bitmap((int)Math.Ceiling(CheckCode.Length * 14.5), 32);
            //
            Graphics graphic = Graphics.FromImage(image);

            try
            {
                Random rng = new Random();
                graphic.Clear(Color.White);

                //用于产生随机的25根线条
                int x1 = 0, y1 = 0, x2 = 0, y2 = 0;
                for (int index = 0; index < 50; index++)
                {
                    x1 = rng.Next(image.Width);
                    x2 = rng.Next(image.Width);
                    y1 = rng.Next(image.Height);
                    y2 = rng.Next(image.Height);
                    //画随机线
                    graphic.DrawLine(new Pen(Color.Silver), x1, y1, x2, y2);
                }

                //绘制验证码信息
                Font font = new Font("Arial", 16, (FontStyle.Bold | FontStyle.Italic));
                SolidBrush brush = new SolidBrush(Color.Black);
                graphic.DrawString(CheckCode, font, brush, 2, 2);

                int x = 0, y = 0;
                //画图片的前景噪音
                for (int i = 0; i < 100; i++)
                {
                    x = rng.Next(image.Width);
                    y = rng.Next(image.Height);
                    image.SetPixel(x, y, Color.FromArgb(rng.Next()));
                }

                //画图片的边框线
                graphic.DrawRectangle(new Pen(Color.Silver), 0, 0, image.Width - 1, image.Height - 1);
                //将图片验证码保存为stream返回
                //MemoryStream ms = new MemoryStream();
                //image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return image;
            }
            finally
            {
                //释放资源
                graphic.Dispose();
                //image.Dispose();
            }
        }

    }
}
