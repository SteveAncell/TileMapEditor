using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapEditor
{
    public static class Graffix
    {
        public static void DrawImageToImage(Bitmap srcImage, Rectangle srcRect, Bitmap destImage, Rectangle destRect)
        {
            using (Graphics gD = Graphics.FromImage(destImage))
            {
                gD.DrawImage(srcImage, destRect, srcRect, GraphicsUnit.Pixel);

            }

        }

    }

}
