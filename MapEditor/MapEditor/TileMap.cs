using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapEditor
{
    public class TileMap
    {
        public int mouseIsDown = 0;
        public List<TileMapLayer> layerList = new List<TileMapLayer>();
        public TileMapLayer currentLayer;

        public TileMap()
        {

        }

        public void AddLayer(TileMapLayer tileMapLayer)
        {
            this.layerList.Add(tileMapLayer);

        }
        
    }

    public class TileMapLayer
    {
        public int cellWidth;
        public int cellHeight;
        public int columnCount;
        public int rowCount;
        public int hScroll;
        public int vScroll;
        public MapCell[] cellCache;
        public Color gridColour;

        public TileMapLayer()
        {
            gridColour = Color.Black;
            hScroll = 0;
            vScroll = 0;
            
        }

        private void refresh(object sender, EventArgs e)
        {
            
        }

        public MapCell GetCell(int index)
        {
            return cellCache[index];

        }

        public int GetCellIndex(int col, int row)
        {
            return (columnCount * row) + col;

        }

        public void SetCellTileIndex(int cellIndex, int tileIndex)
        {
            cellCache[cellIndex].tileIndex = tileIndex;

        }

        public void ClearCellIndex(int cellIndex)
        {
            cellCache[cellIndex].tileIndex = -1;

        }

        public void ClearCell(int cellIndex)
        {
            cellCache[cellIndex] = null;
            cellCache[cellIndex] = new MapCell();

        }

    }

    public class MapCell
    {
        public int tileLibIndex = -1;
        public int tileIndex = -1;

        public MapCell Clone()
        {
            return this;

        }

    }
    
}
