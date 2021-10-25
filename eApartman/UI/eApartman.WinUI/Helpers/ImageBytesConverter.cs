using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eApartman.WinUI.Helpers
{
    public class ImageBytesConverter
    {
        public static Image BytesToImage(byte[] bytes)
        {
            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }
            return image;
        }
        public static byte[] ImageToBytes(Image image)
        {
            using(MemoryStream ms=new MemoryStream())
            {
                image.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
    }
}
