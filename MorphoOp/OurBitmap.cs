using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MorphoOp
{
    class OurBitmap
    {
        public Bitmap image;

        public OurBitmap(Bitmap img)
        {
            image = (Bitmap)img.Clone();
        }

        public OurBitmap(int width, int height)
        {
            image = new Bitmap(width, height);
        }

        /*public int Height
        {
            get { return image.Height; };
        }

        public int Width
        {
            get { return image.Width; };
        }*/

        public int LimitedHeight
        {
            get { return 2 * image.Height + 1; }
        }

        public int LimitedWidth
        {
            get { return 2 * image.Width + 1; }
        }
    }
}
