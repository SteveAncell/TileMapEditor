using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MapEditor
{
    public class TileLib
    {
        public int loaded = 0;
        public int hScroll = 0;
        public int vScroll = 0;
        public int hScrollMax;
        public int vScrollMax;
        public int hScrollLargeChange;
        public int vScrollLargeChange;
        public int cellWidth;
        public int cellHeight;
        public int columnCount;
        public int rowCount;
        public int selected;
        public string imageFileName;
        public Bitmap[] imageCache;
        
        public void Load(string fileName)
        {
            Bitmap image;
            
            imageFileName = fileName;
            image = new Bitmap(fileName);
            
            if(image == null)
            {
                loaded = 0;
                return;

            }
            else
            {
                loaded = 1;

            }

            selected = -1;
            columnCount = image.Width / cellWidth;
            rowCount = image.Height / cellHeight;
            imageCache = new Bitmap[columnCount * rowCount];
            
            for(int row = 0; row < rowCount; row++)
            {
                for(int col = 0; col < columnCount; col++)
                {
                    int index = (columnCount * row) + col;
                    imageCache[index] = new Bitmap(cellWidth, cellHeight);
                    
                    Graffix.DrawImageToImage(image, new Rectangle(cellWidth * col, cellHeight * row, cellWidth, cellHeight), imageCache[index], new Rectangle(0, 0, cellWidth, cellHeight));

                }

            }

            image.Dispose();

        }

        public Bitmap GetImage(int index)
        {
            return imageCache[index];

        }

        public int GetImageIndex(int col, int row)
        {
            return (columnCount * row) + col;

        }

    }

}
