using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MapEditor
{
    public partial class Form1 : Form
    {
        public static int lmbState = 0;
        public static int rmbState = 0;

        public static int defaultTileWidth = 40;
        public static int defaultTileHeight= 32;

        public Button currentTool;

        public static TileMap tileMap;
        public static TileMapLayer currentMapLayer;
        public static List<CheckBox> mapLayerCheckBoxes = new List<CheckBox>();

        public static List<TileLib> tileLibs;
        public TileLib currentTileLib;
        

        public Form1()
        {
            InitializeComponent();
            Init();
            
        }

        


        private void Init()
        {
            DefaultTileLibList();
            DefaultTileLib();
            DefaultMapLayerList();
            DefaultTileMap();
            SelectTool(buttonEditMapCell);
            
        }
        


        
        private void SelectTool(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            SelectTool(button);

        }

        private void SelectTool(Button button)
        {
            try
            {
                currentTool.BackColor = Button.DefaultBackColor;

            }
            catch
            {

            }

            button.BackColor = Color.Blue;
            currentTool = button;

        }




        // TileLib
        public void DefaultTileLib()
        {
            int cellWidth = defaultTileWidth; ;
            int cellHeight = defaultTileHeight;
            
            hScrollBarTileLib.Value = 0;
            hScrollBarTileLib.Maximum = 0;
            vScrollBarTileLib.Value = 0;
            vScrollBarTileLib.Maximum = 0;

            textBoxCustomTileWidth.Text = cellWidth.ToString();
            textBoxCustomTileHeight.Text = cellHeight.ToString();

            textBoxCustomTileWidth.StoreText();
            textBoxCustomTileHeight.StoreText();
            
            try
            {
                tileLibs.Clear();

            }
            catch
            {

            }

            currentTileLib = null;
            tileLibs = new List<TileLib>();
            
            panelCustomTileWindow.Invalidate();
            panelCustomTileSelected.Invalidate();

        }
        
        public void LoadTileLib(string path)
        {
            int cellWidth = int.Parse(textBoxCustomTileWidth.Text);
            int cellHeight = int.Parse(textBoxCustomTileHeight.Text);
            
            TileLib tileLib = new TileLib();
            tileLib.cellWidth = cellWidth;
            tileLib.cellHeight = cellHeight;
            tileLib.imageFileName = path;

            tileLib.Load(path);

            if (tileLib.loaded == 0)
            {
                tileLib = null;
                return;

            }
            
            tileLibs.Add(tileLib);

            currentTileLib = tileLib;

            hScrollBarTileLib.Maximum = tileLib.columnCount - 1;
            hScrollBarTileLib.LargeChange = panelCustomTileWindow.Width / tileLib.cellWidth;
            hScrollBarTileLib.Value = 0;

            vScrollBarTileLib.Maximum = tileLib.rowCount - 1;
            vScrollBarTileLib.LargeChange = panelCustomTileWindow.Height / tileLib.cellHeight;
            vScrollBarTileLib.Value = 0;

            vScrollBarTileLibList.Maximum = tileLibs.Count - 1;
            vScrollBarTileLibList.LargeChange = panelCustomTileLibList.Height / this.FontHeight;
            vScrollBarTileLibList.Value = 0;

            SubmitTileLibScrollBars();

            panelCustomTileLibList.Invalidate();
            panelCustomTileWindow.Invalidate();
            
        }

        private void buttonLoadTileLib_Click(object sender, EventArgs e)
        {
            int cellWidth = 0;
            int cellHeight = 0;

            try
            {
                cellWidth = int.Parse(textBoxCustomTileWidth.Text);
                cellHeight = int.Parse(textBoxCustomTileHeight.Text);
                
            }
            catch
            {
                MessageBox.Show("Parameters must be integers above zero");
                textBoxCustomTileWidth.RevertText();
                textBoxCustomTileHeight.RevertText();
                return;

            }
            finally
            {
                textBoxCustomTileWidth.StoreText();
                textBoxCustomTileHeight.StoreText();

            }

            if (cellWidth <= 0 || cellHeight <= 0)
            {
                MessageBox.Show("Parameters must be integers above zero");
                return;

            }

            openFileDialog1.Filter = "Portable Network Graphics (.png)|*.png|Bitmap (.bmp)|*.bmp";
            openFileDialog1.Multiselect = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for(int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    LoadTileLib(openFileDialog1.FileNames[i]);

                }

            }
            
        }

        public void SubmitTileLibScrollBars()
        {
            try
            {
                currentTileLib.hScrollMax = hScrollBarTileLib.Maximum;
                currentTileLib.vScrollMax = vScrollBarTileLib.Maximum;
                currentTileLib.hScrollLargeChange = hScrollBarTileLib.LargeChange;
                currentTileLib.vScrollLargeChange = vScrollBarTileLib.LargeChange;
                currentTileLib.hScroll = hScrollBarTileLib.Value;
                currentTileLib.vScroll = vScrollBarTileLib.Value;

            }
            catch
            {

            }

        }
        
        private void panelCustomTileWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                try
                {
                    int col = (e.X / currentTileLib.cellWidth) + currentTileLib.hScroll;
                    int row = (e.Y / currentTileLib.cellHeight) + currentTileLib.vScroll;
                    int index = (currentTileLib.columnCount * row) + col;
                    
                    if(index >= currentTileLib.imageCache.Length)
                    {
                        currentTileLib.selected = -1;

                    }
                    else
                    {
                        currentTileLib.selected = index;

                    }

                }
                catch
                {
                    
                }

            }

            panelCustomTileSelected.Invalidate();

        }
        
        private void hScrollBarTileLib_ValueChanged(object sender, EventArgs e)
        {
            HScrollBar sb = (HScrollBar)sender;

            try
            {
                currentTileLib.hScroll = sb.Value;

            }
            catch
            {

            }

            panelCustomTileWindow.Invalidate();

        }

        private void vScrollBarTileLib_ValueChanged(object sender, EventArgs e)
        {
            VScrollBar sb = (VScrollBar)sender;

            try
            {
                currentTileLib.vScroll = sb.Value;

            }
            catch
            {

            }

            panelCustomTileWindow.Invalidate();

        }
        
        private void panelCustomTileWindow_Paint(object sender, PaintEventArgs e)
        {
            PanelCustom panel = (PanelCustom)sender;
            
            try
            {
                int cellWidth = currentTileLib.cellWidth;
                int cellHeight = currentTileLib.cellHeight;
                int cols = panel.Width / cellWidth;
                int rows = panel.Height / cellHeight;

                if(cols > currentTileLib.columnCount)
                {
                    cols = currentTileLib.columnCount;

                }

                if(rows > currentTileLib.rowCount)
                {
                    rows = currentTileLib.rowCount;

                }

                for(int row = 0; row < rows; row++)
                {
                    for(int col = 0; col < cols; col++)
                    {
                        int index = (currentTileLib.columnCount * (row + currentTileLib.vScroll)) + (col + currentTileLib.hScroll);

                        e.Graphics.DrawImage(currentTileLib.GetImage(index), cellWidth * col, cellHeight * row);
                        e.Graphics.DrawRectangle(Pens.Black, cellWidth * col, cellHeight * row, cellWidth, cellHeight);

                    }

                }

            }
            catch
            {

            }

        }

        private void panelDBTileSelected_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(currentTileLib.GetImage(currentTileLib.selected), 0, 0);
                
            }
            catch
            {

            }

        }




        // TileLibList
        private void DefaultTileLibList()
        {
            vScrollBarTileLibList.Value = 0;
            vScrollBarTileLibList.Maximum = 0;

            panelCustomTileLibList.Invalidate();

        }

        private void panelDBTileLibList_MouseMove(object sender, MouseEventArgs e)
        {
            PanelCustom panel = (PanelCustom)sender;
            panel.Invalidate();

        }

        private void panelDBTileLibList_MouseDown(object sender, MouseEventArgs e)
        {
            PanelCustom panel = (PanelCustom)sender;
            int start = vScrollBarTileLibList.Value;
            int index = (e.Y / this.FontHeight) + start;

            if (tileLibs.Count <= 0)
            {
                return;

            }

            if(index >= tileLibs.Count)
            {
                return;

            }

            if (e.Button == MouseButtons.Left)
            {
                SelectTileLib(index);

                textBoxCustomTileWidth.Text = currentTileLib.cellWidth.ToString();
                textBoxCustomTileHeight.Text = currentTileLib.cellHeight.ToString();
                
            }

            panel.Invalidate();

        }

        private void panelDBTileLibList_MouseLeave(object sender, EventArgs e)
        {
            PanelCustom panel = (PanelCustom)sender;
            panel.Invalidate();
            
        }
        
        private void vScrollBarTileLibList_ValueChanged(object sender, EventArgs e)
        {
            panelCustomTileLibList.Invalidate();

        }

        private void buttonRemoveTileLib_Click(object sender, EventArgs e)
        {
            tileLibs.Remove(currentTileLib);

            currentTileLib = null;

            if(tileLibs.Count > 1)
            {
                textBoxCustomTileWidth.Text = "";
                textBoxCustomTileHeight.Text = "";

            }

            panelCustomTileWindow.Invalidate();
            panelCustomTileLibList.Invalidate();

        }

        private void panelDBTileLibList_Paint(object sender, PaintEventArgs e)
        {
            PanelCustom panel = (PanelCustom)sender;
            Point mousePoint = panel.PointToClient(Cursor.Position);
            int fieldRows = panel.Height / this.FontHeight;
            int rowHeight = this.FontHeight;
            int index = GetCurrentTileLibIndex();
            int highlightIndex = mousePoint.Y / this.FontHeight;
            int start = vScrollBarTileLibList.Value;
            
            if (tileLibs.Count <= 0)
            {
                return;

            }
            
            if (index >= 0)
            {
                e.Graphics.FillRectangle(Brushes.PowderBlue, 0, rowHeight * (index - start), panelCustomTileLibList.Width, rowHeight);

            }
            
            if(highlightIndex + start < tileLibs.Count)
            {
                if (mousePoint.X > 0 && mousePoint.X < panelCustomTileLibList.Width - 3)
                {
                    if (mousePoint.Y > 0 && mousePoint.Y < panelCustomTileLibList.Height - 3)
                    {
                        e.Graphics.DrawRectangle(Pens.Blue, 0, rowHeight * highlightIndex, panel.Width, rowHeight);

                    }

                }
            }
            
            for(int i = 0; i < fieldRows; i++)
            {
                if(i >= tileLibs.Count)
                {
                    return;

                }

                e.Graphics.DrawString("TileLib: " + (i + start), this.Font, Brushes.Black, 0, rowHeight * i);

            }
            
        }

        public int GetCurrentTileLibIndex()
        {
            int index = -1;

            try
            {
                index = tileLibs.IndexOf(currentTileLib);

            }
            catch
            {
                
            }

            return index;
            
        }

        public void SelectTileLib(int index)
        {
            SubmitTileLibScrollBars();

            currentTileLib = tileLibs[index];
            
            hScrollBarTileLib.Maximum = currentTileLib.hScrollMax;
            hScrollBarTileLib.LargeChange = currentTileLib.hScrollLargeChange;
            hScrollBarTileLib.Value = currentTileLib.hScroll;

            vScrollBarTileLib.Maximum = currentTileLib.vScrollMax;
            vScrollBarTileLib.LargeChange = currentTileLib.vScrollLargeChange;
            vScrollBarTileLib.Value = currentTileLib.vScroll;

            panelCustomTileWindow.Invalidate();

        }

        


        // TileMap
        public void DefaultTileMap()
        {
            int cellWidth = defaultTileWidth; ;
            int cellHeight = defaultTileHeight;
            int colCount = (panelCustomMapWindow.Width / cellWidth);
            int rowCount = (panelCustomMapWindow.Height / cellHeight);

            hScrollBarTileMap.Value = 0;
            hScrollBarTileMap.Maximum = 0;
            vScrollBarTileMap.Value = 0;
            vScrollBarTileMap.Maximum = 0;

            textBoxCustomMapCellWidth.Text = cellWidth.ToString();
            textBoxCustomMapCellHeight.Text = cellHeight.ToString();
            textBoxCustomMapColumns.Text = colCount.ToString();
            textBoxCustomMapRows.Text = rowCount.ToString();
            
            textBoxCustomMapCellWidth.StoreText();
            textBoxCustomMapCellHeight.StoreText();
            textBoxCustomMapColumns.StoreText();
            textBoxCustomMapRows.StoreText();

            try
            {
                tileMap = null;

            }
            catch
            {

            }

            tileMap = new TileMap();
            panelCustomMapWindow.Invalidate();

        }

        public void NewTileMap()
        {
            try
            {
                tileMap = null;

            }
            catch
            {

            }

            tileMap = new TileMap();

        }

        public void SaveMap(string fileName)
        {
            if(tileLibs.Count > 0 && tileMap.layerList.Count > 0)
            {
                string[] fullpath = fileName.Split('\\');
                Console.WriteLine(fullpath[fullpath.Length - 2]);

                //if(Directory.Exists(fileName + "\\Graphics") == false)
                //{
                //    DirectoryInfo di = Directory.CreateDirectory(fileName + "\\Graphics");
                    
                //}

                using (StreamWriter stream = new StreamWriter(File.Open(fileName, FileMode.Create)))
                {
                    for (int tileLibIndex = 0; tileLibIndex < tileLibs.Count; tileLibIndex++)
                    {
                        string[] path = tileLibs[tileLibIndex].imageFileName.Split('\\');
                        
                        stream.WriteLine("[TILELIB]");
                        stream.WriteLine(tileLibs[tileLibIndex].imageFileName);
                        stream.Write(tileLibs[tileLibIndex].cellWidth + ",");
                        stream.Write(tileLibs[tileLibIndex].cellHeight);
                        stream.WriteLine();

                    }

                    for (int layerIndex = 0; layerIndex < tileMap.layerList.Count; layerIndex++)
                    {
                        TileMapLayer layer = tileMap.layerList[layerIndex];
                        MapCell[] mc = layer.cellCache;

                        stream.WriteLine("[LAYER]");
                        stream.Write(layer.cellWidth + ",");
                        stream.Write(layer.cellHeight + ",");
                        stream.Write(layer.columnCount + ",");
                        stream.Write(layer.rowCount);
                        stream.WriteLine();

                        for (int index = 0; index < mc.Length; index++)
                        {
                            int tileLibIndex = mc[index].tileLibIndex;
                            int tileIndex = mc[index].tileIndex;

                            stream.Write(tileLibIndex + ",");
                            stream.Write(tileIndex);

                            if (index < mc.Length - 1)
                            {
                                stream.Write(",");

                            }

                        }

                        stream.WriteLine();

                    }

                    stream.WriteLine("[END]");
                    stream.Close();

                }

            }

        }

        public void LoadMap(string fileName)
        {
            string data;

            DefaultTileMap();
            DefaultMapLayerList();
            DefaultTileLib();
            DefaultTileLibList();

            using(StreamReader stream = new StreamReader(fileName))
            {
                while (true)
                {
                    data = stream.ReadLine();
                    
                    if(data == "[END]")
                    {
                        Console.WriteLine("End Of File");
                        break;

                    }

                    if(data == "[TILELIB]")
                    {
                        string path = stream.ReadLine();
                        string[] dimensions = stream.ReadLine().Split(',');

                        Console.WriteLine("TileLib");
                        Console.WriteLine(path);
                        Console.WriteLine(dimensions[0]);
                        Console.WriteLine(dimensions[1]);

                        textBoxCustomTileWidth.Text = dimensions[0];
                        textBoxCustomTileHeight.Text = dimensions[1];

                        LoadTileLib(path);

                    }

                    if(data == "[LAYER]")
                    {
                        Console.WriteLine("Layer");

                        string[] dimensions = stream.ReadLine().Split(',');

                        textBoxCustomMapCellWidth.Text = dimensions[0];
                        textBoxCustomMapCellHeight.Text = dimensions[1];
                        textBoxCustomMapColumns.Text = dimensions[2];
                        textBoxCustomMapRows.Text = dimensions[3];

                        AddMapLayer();
                        currentMapLayer.cellCache = new MapCell[currentMapLayer.columnCount * currentMapLayer.rowCount];

                        string[] mapData = stream.ReadLine().Split(',');
                        
                        for(int i = 0; i < currentMapLayer.cellCache.Length; i++)
                        {
                            int tileLibIndex = int.Parse(mapData[i * 2]);
                            int tileIndex = int.Parse(mapData[(i * 2) + 1]);

                            currentMapLayer.cellCache[i] = new MapCell();
                            currentMapLayer.cellCache[i].tileLibIndex = tileLibIndex;
                            currentMapLayer.cellCache[i].tileIndex = tileIndex;

                        }

                        //Console.WriteLine("CellWidth: " + cellWidth);
                        //Console.WriteLine("CellHeight: " + cellHeight);
                        //Console.WriteLine("ColCount: : " + colCount);
                        //Console.WriteLine("RowCount: " + rowCount);

                    }

                }

                stream.Close();

                panelCustomTileWindow.Invalidate();
                panelCustomTileLibList.Invalidate();
                panelCustomMapWindow.Invalidate();
                panelCustomLayerList.Invalidate();

            }

        }

        public void NukeMap()
        {

        }

        public void AddMapLayer()
        {
            int cellWidth;
            int cellHeight;
            int columns;
            int rows;

            try
            {
                cellWidth = int.Parse(textBoxCustomMapCellWidth.Text);
                cellHeight = int.Parse(textBoxCustomMapCellHeight.Text);
                columns = int.Parse(textBoxCustomMapColumns.Text);
                rows = int.Parse(textBoxCustomMapRows.Text);

            }
            catch
            {
                MessageBox.Show("Parameters must be integers above zero");
                textBoxCustomMapCellWidth.RevertText();
                textBoxCustomMapCellHeight.RevertText();
                textBoxCustomMapColumns.RevertText();
                textBoxCustomMapRows.RevertText();

                return;

            }
            finally
            {
                textBoxCustomMapCellWidth.StoreText();
                textBoxCustomMapCellHeight.StoreText();
                textBoxCustomMapColumns.StoreText();
                textBoxCustomMapRows.StoreText();

            }

            if (cellWidth <= 0 || cellHeight <= 0)
            {
                MessageBox.Show("Parameters must be integers above zero");
                return;

            }

            CheckBox checkBox = new CheckBox();
            checkBox.Parent = panelCustomLayerList;
            checkBox.Size = new Size(checkBox.Height, this.FontHeight);
            checkBox.Checked = true;
            checkBox.CheckedChanged += delegate (object sender, EventArgs e) { panelCustomMapWindow.Invalidate(); };
            mapLayerCheckBoxes.Add(checkBox);

            TileMapLayer mapLayer = new TileMapLayer();
            mapLayer.cellWidth = cellWidth;
            mapLayer.cellHeight = cellHeight;
            mapLayer.columnCount = columns;
            mapLayer.rowCount = rows;
            mapLayer.cellCache = new MapCell[columns * rows];

            for(int i = 0; i < columns * rows; i++)
            {
                mapLayer.cellCache[i] = new MapCell();

            }

            tileMap.AddLayer(mapLayer);
            currentMapLayer = mapLayer;

            vScrollBarMapLayerList.Maximum = tileMap.layerList.Count - 1;
            vScrollBarMapLayerList.LargeChange = panelCustomLayerList.Height / this.FontHeight;
            vScrollBarMapLayerList.Value = 0;

            hScrollBarTileMap.Maximum = currentMapLayer.columnCount - 1;
            hScrollBarTileMap.LargeChange = panelCustomMapWindow.Width / currentMapLayer.cellWidth;
            hScrollBarTileMap.Value = 0;

            vScrollBarTileMap.Maximum = currentMapLayer.rowCount - 1;
            vScrollBarTileMap.LargeChange = panelCustomMapWindow.Width / currentMapLayer.cellHeight;
            vScrollBarTileMap.Value = 0;

        }

        private void ClickMapCell(int index)
        {
            if(currentTileLib != null && currentTileLib.selected >= 0)
            {
                if (currentTool == buttonEditMapCell)
                {
                    PaintMapCell(index);

                }

            }

            if (currentTool == buttonEraseMapCell)
            {
                EraseMapCell(index);

            }

        }

        private void PaintMapCell(int index)
        {
            try
            {
                if (currentTileLib.cellWidth != currentMapLayer.cellWidth && currentTileLib.cellHeight != currentMapLayer.cellHeight)
                {
                    return;

                }

                MapCell cell = currentMapLayer.GetCell(index);
                cell.tileLibIndex = GetCurrentTileLibIndex();
                cell.tileIndex = currentTileLib.selected;

            }
            catch
            {

            }
            
        }

        private void EraseMapCell(int index)
        {
            currentMapLayer.cellCache[index] = new MapCell();
            
        }
        
        private void buttonNewMap_Click(object sender, EventArgs e)
        {
            NewTileMap();

        }

        private void buttonNukeMap_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddMapLayer_Click(object sender, EventArgs e)
        {
            AddMapLayer();
            panelCustomMapWindow.Invalidate();
            panelCustomLayerList.Invalidate();
            
        }

        private void buttonSaveMap_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Data Files (.dat)|*.dat";
            
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveMap(saveFileDialog1.FileName);
                
            }

        }

        private void buttonLoadMap_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Data Files (.dat)|*.dat";
            openFileDialog1.Multiselect = false;
            
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadMap(openFileDialog1.FileName);

                string[] path = openFileDialog1.FileName.Split('\\');
                
            }

        }

        private void panelCustomMapWindow_MouseDown(object sender, MouseEventArgs e)
        {
            int cellWidth, cellHeight;
            int col, row;
            int fieldCols, fieldRows;
            int cellIndex;

            try
            {
                cellWidth = currentMapLayer.cellWidth;
                cellHeight = currentMapLayer.cellHeight;
                fieldCols = panelCustomMapWindow.Width / cellWidth;
                fieldRows = panelCustomMapWindow.Height / cellHeight;

                if (fieldCols > currentMapLayer.columnCount)
                {
                    fieldCols = currentMapLayer.columnCount;

                }

                if (fieldRows > currentMapLayer.rowCount)
                {
                    fieldRows = currentMapLayer.rowCount;

                }

            }
            catch
            {
                return;

            }
            
            col = e.X / cellWidth;
            row = e.Y / cellHeight;
            cellIndex = ((currentMapLayer.columnCount * row) + currentMapLayer.vScroll) + (col + currentMapLayer.hScroll);

            if(col >= currentMapLayer.columnCount || row >= currentMapLayer.rowCount)
            {
                return;

            }

            if (e.Button == MouseButtons.Left)
            {
                tileMap.mouseIsDown = 1;

                try
                {
                    ClickMapCell(cellIndex);

                }
                catch
                {

                }
                
                panelCustomMapWindow.Invalidate();

            }

        }

        private void panelCustomMapWindow_MouseUp(object sender, MouseEventArgs e)
        {
            tileMap.mouseIsDown = 0;

        }

        private void panelCustomMapWindow_MouseMove(object sender, MouseEventArgs e)
        {
            int cellWidth, cellHeight;
            int col, row;
            int fieldCols, fieldRows;
            int cellIndex;

            try
            {
                cellWidth = currentMapLayer.cellWidth;
                cellHeight = currentMapLayer.cellHeight;
                fieldCols = panelCustomMapWindow.Width / cellWidth;
                fieldRows = panelCustomMapWindow.Height / cellHeight;

                if (fieldCols > currentMapLayer.columnCount)
                {
                    fieldCols = currentMapLayer.columnCount;

                }

                if (fieldRows > currentMapLayer.rowCount)
                {
                    fieldRows = currentMapLayer.rowCount;

                }

            }
            catch
            {
                return;

            }
            
            col = e.X / cellWidth;
            row = e.Y / cellHeight;
            cellIndex = ((currentMapLayer.columnCount * row) + currentMapLayer.vScroll) + (col + currentMapLayer.hScroll);

            if (col >= currentMapLayer.columnCount || row >= currentMapLayer.rowCount)
            {
                return;

            }

            if (tileMap.mouseIsDown == 1)
            {
                ClickMapCell(cellIndex);
                panelCustomMapWindow.Invalidate();

            }

        }
        
        private void hScrollBarTileMap_ValueChanged(object sender, EventArgs e)
        {
            HScrollBar sb = (HScrollBar)sender;

            try
            {
                currentMapLayer.hScroll = sb.Value;

            }
            catch
            {

            }

            panelCustomMapWindow.Invalidate();

        }

        private void vScrollBarTileMap_ValueChanged(object sender, EventArgs e)
        {
            VScrollBar sb = (VScrollBar)sender;

            try
            {
                currentMapLayer.vScroll = sb.Value;

            }
            catch
            {

            }

            panelCustomMapWindow.Invalidate();

        }

        private void PanelCustomMapWindow_Paint(object sender, PaintEventArgs e)
        {
            PanelCustom panel = (PanelCustom)sender;
            int cellWidth, cellHeight;
            int fieldCols, fieldRows;
            int hScroll, vScroll;
            int cellIndex;
            int tileLibIndex;
            int tileIndex;
            TileMapLayer layer;
            Bitmap image;
            
            for(int layerIndex = 0; layerIndex < tileMap.layerList.Count; layerIndex++)
            {
                if(mapLayerCheckBoxes[layerIndex].Checked == true)
                {
                    layer = tileMap.layerList[layerIndex];
                    cellWidth = layer.cellWidth;
                    cellHeight = layer.cellHeight;
                    hScroll = layer.hScroll;
                    vScroll = layer.vScroll;
                    fieldCols = panel.Width / cellWidth;
                    fieldRows = panel.Height / cellHeight;

                    if (fieldCols > layer.columnCount)
                    {
                        fieldCols = layer.columnCount;

                    }

                    if (fieldRows > layer.rowCount)
                    {
                        fieldRows = layer.rowCount;

                    }

                    for (int row = 0; row < fieldRows; row++)
                    {
                        for (int col = 0; col < fieldCols; col++)
                        {
                            int index = ((layer.columnCount * row) + vScroll) + (col + hScroll);
                            tileLibIndex = layer.cellCache[index].tileLibIndex;
                            tileIndex = layer.cellCache[index].tileIndex;

                            if(tileIndex >= 0 && tileIndex >= 0)
                            {
                                image = tileLibs[tileLibIndex].GetImage(tileIndex);
                                e.Graphics.DrawImage(image, cellWidth * col, cellHeight * row);
                                
                            }

                            e.Graphics.DrawRectangle(new Pen(currentMapLayer.gridColour), cellWidth * col, cellHeight * row, cellWidth, cellHeight);

                        }

                    }
                    
                }
                
            }

        }




        // Map Layer List
        private void DefaultMapLayerList()
        {
            vScrollBarMapLayerList.Value = 0;
            vScrollBarMapLayerList.Maximum = 0;

            for(int i = 0; i < mapLayerCheckBoxes.Count; i++)
            {
                CheckBox c = mapLayerCheckBoxes[i];
                c.Dispose();
                c = null;
                mapLayerCheckBoxes.Remove(c);
                
            }

            panelCustomLayerList.Invalidate();

        }

        private void SelectMapLayer(int index)
        {
            try
            {
                currentMapLayer = tileMap.layerList[index];

            }
            catch
            {

            }

            textBoxCustomMapCellWidth.Text = currentMapLayer.cellWidth.ToString();
            textBoxCustomMapCellHeight.Text = currentMapLayer.cellHeight.ToString();
            textBoxCustomMapColumns.Text = currentMapLayer.columnCount.ToString();
            textBoxCustomMapRows.Text = currentMapLayer.rowCount.ToString();

            panelCustomLayerList.Invalidate();

        }

        public int GetCurrentLayerIndex()
        {
            int index = -1;

            try
            {
                index = tileMap.layerList.IndexOf(currentMapLayer);

            }
            catch
            {

            }

            return index;

        }

        private void buttonInsertMapLayer_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoveMapLayer_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBarMapLayerList_ValueChanged(object sender, EventArgs e)
        {
            panelCustomLayerList.Invalidate();

        }

        private void panelCustomLayerList_MouseMove(object sender, MouseEventArgs e)
        {
            PanelCustom panel = (PanelCustom)sender;
            panel.Invalidate();

        }

        private void panelCustomLayerList_MouseLeave(object sender, EventArgs e)
        {
            PanelCustom panel = (PanelCustom)sender;
            panel.Invalidate();

        }

        private void panelDBLayerList_MouseDown(object sender, MouseEventArgs e)
        {
            PanelCustom panel = (PanelCustom)sender;
            int start = vScrollBarMapLayerList.Value;
            int index = (e.Y / this.FontHeight) + start;

            if (tileMap.layerList.Count <= 0)
            {
                return;

            }

            if (index >= tileMap.layerList.Count)
            {
                return;

            }

            if (e.Button == MouseButtons.Left)
            {
                SelectMapLayer(index);
                
            }

            label11.Text = currentMapLayer.ToString() + ": " + tileMap.layerList.IndexOf(currentMapLayer).ToString();

            panel.Invalidate();
            panelCustomMapWindow.Invalidate();

        }

        private void panelDBLayerList_Paint(object sender, PaintEventArgs e)
        {
            PanelCustom panel = (PanelCustom)sender;
            Point mousePoint = panel.PointToClient(Cursor.Position);
            int fieldRows = panel.Height / this.FontHeight;
            int rowHeight = this.FontHeight;
            int index = GetCurrentLayerIndex();
            int highlightIndex = mousePoint.Y / this.FontHeight;
            int start = vScrollBarMapLayerList.Value;

            if(tileMap.layerList.Count <= 0)
            {
                return;

            }

            if (index >= 0)
            {
                e.Graphics.FillRectangle(Brushes.PowderBlue, 0, rowHeight * (index - start), panelCustomLayerList.Width, rowHeight);

            }

            if (highlightIndex + start < tileMap.layerList.Count)
            {
                if (mousePoint.X > 0 && mousePoint.X < panelCustomLayerList.Width - 3)
                {
                    if (mousePoint.Y > 0 && mousePoint.Y < panelCustomLayerList.Height - 3)
                    {
                        e.Graphics.DrawRectangle(Pens.Blue, 0, rowHeight * highlightIndex, panel.Width, rowHeight);

                    }

                }
            }

            for (int i = 0; i < fieldRows; i++)
            {
                if (i >= tileMap.layerList.Count)
                {
                    return;

                }
                
                string info = "MapLayer: " + (i + start).ToString();
                CheckBox checkBox = mapLayerCheckBoxes[i + start];
                checkBox.Location = new Point(panel.Width - checkBox.Width, rowHeight * i);

                e.Graphics.DrawString(info, this.Font, Brushes.Black, 0, rowHeight * i);
                
            }

        }




        private void buttonMapGridColour_Click(object sender, EventArgs e)
        {
            if (currentMapLayer != null)
            {
                int r = currentMapLayer.gridColour.R;
                int g = currentMapLayer.gridColour.G;
                int b = currentMapLayer.gridColour.B;

                using (ColourPicker cp = new ColourPicker(r, g, b))
                {
                    if (cp.ShowDialog() == DialogResult.OK)
                    {
                        r = cp.red;
                        g = cp.green;
                        b = cp.blue;

                        currentMapLayer.gridColour = Color.FromArgb(r, g, b);

                        labelGridR.Text = r.ToString();
                        labelGridG.Text = g.ToString();
                        labelGridB.Text = b.ToString();

                        panelCustomMapWindow.Invalidate();

                    }

                }

            }

        }

    }
    
}
