namespace MapEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.vScrollBarTileMap = new System.Windows.Forms.VScrollBar();
            this.hScrollBarTileMap = new System.Windows.Forms.HScrollBar();
            this.vScrollBarTileLib = new System.Windows.Forms.VScrollBar();
            this.hScrollBarTileLib = new System.Windows.Forms.HScrollBar();
            this.buttonRemoveMapLayer = new System.Windows.Forms.Button();
            this.vScrollBarTileLibList = new System.Windows.Forms.VScrollBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonRemoveTileLib = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonNukeMap = new System.Windows.Forms.Button();
            this.buttonNewMap = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.vScrollBarMapLayerList = new System.Windows.Forms.VScrollBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonMapGridColour = new System.Windows.Forms.Button();
            this.labelGridR = new System.Windows.Forms.Label();
            this.labelGridG = new System.Windows.Forms.Label();
            this.labelGridB = new System.Windows.Forms.Label();
            this.buttonLoadMap = new System.Windows.Forms.Button();
            this.buttonSaveMap = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelCustomLayerList = new MapEditor.PanelCustom();
            this.panelCustomTileLibList = new MapEditor.PanelCustom();
            this.panelCustomTileSelected = new MapEditor.PanelCustom();
            this.panelCustom3 = new MapEditor.PanelCustom();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLoadTileLib = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCustomTileHeight = new MapEditor.TextBoxCustom();
            this.textBoxCustomTileWidth = new MapEditor.TextBoxCustom();
            this.panelCustom2 = new MapEditor.PanelCustom();
            this.textBoxCustomMapRows = new MapEditor.TextBoxCustom();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCustomMapCellHeight = new MapEditor.TextBoxCustom();
            this.textBoxCustomMapColumns = new MapEditor.TextBoxCustom();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCustomMapCellWidth = new MapEditor.TextBoxCustom();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddMapLayer = new System.Windows.Forms.Button();
            this.buttonInsertLayer = new System.Windows.Forms.Button();
            this.panelCustomTileWindow = new MapEditor.PanelCustom();
            this.panelCustomMapWindow = new MapEditor.PanelCustom();
            this.panelCustom1 = new MapEditor.PanelCustom();
            this.buttonSaveAll = new System.Windows.Forms.Button();
            this.buttonOpenMap = new System.Windows.Forms.Button();
            this.buttonSelectMapCells = new System.Windows.Forms.Button();
            this.buttonEraseMapCell = new System.Windows.Forms.Button();
            this.buttonEditMapCell = new System.Windows.Forms.Button();
            this.panelCustom3.SuspendLayout();
            this.panelCustom2.SuspendLayout();
            this.panelCustom1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vScrollBarTileMap
            // 
            this.vScrollBarTileMap.LargeChange = 1;
            this.vScrollBarTileMap.Location = new System.Drawing.Point(819, 68);
            this.vScrollBarTileMap.Name = "vScrollBarTileMap";
            this.vScrollBarTileMap.Size = new System.Drawing.Size(17, 600);
            this.vScrollBarTileMap.TabIndex = 26;
            this.vScrollBarTileMap.ValueChanged += new System.EventHandler(this.vScrollBarTileMap_ValueChanged);
            // 
            // hScrollBarTileMap
            // 
            this.hScrollBarTileMap.LargeChange = 1;
            this.hScrollBarTileMap.Location = new System.Drawing.Point(12, 671);
            this.hScrollBarTileMap.Name = "hScrollBarTileMap";
            this.hScrollBarTileMap.Size = new System.Drawing.Size(800, 17);
            this.hScrollBarTileMap.TabIndex = 25;
            this.hScrollBarTileMap.ValueChanged += new System.EventHandler(this.hScrollBarTileMap_ValueChanged);
            // 
            // vScrollBarTileLib
            // 
            this.vScrollBarTileLib.LargeChange = 1;
            this.vScrollBarTileLib.Location = new System.Drawing.Point(1678, 68);
            this.vScrollBarTileLib.Name = "vScrollBarTileLib";
            this.vScrollBarTileLib.Size = new System.Drawing.Size(17, 600);
            this.vScrollBarTileLib.TabIndex = 30;
            this.vScrollBarTileLib.ValueChanged += new System.EventHandler(this.vScrollBarTileLib_ValueChanged);
            // 
            // hScrollBarTileLib
            // 
            this.hScrollBarTileLib.LargeChange = 1;
            this.hScrollBarTileLib.Location = new System.Drawing.Point(1275, 671);
            this.hScrollBarTileLib.Name = "hScrollBarTileLib";
            this.hScrollBarTileLib.Size = new System.Drawing.Size(400, 17);
            this.hScrollBarTileLib.TabIndex = 29;
            this.hScrollBarTileLib.ValueChanged += new System.EventHandler(this.hScrollBarTileLib_ValueChanged);
            // 
            // buttonRemoveMapLayer
            // 
            this.buttonRemoveMapLayer.Location = new System.Drawing.Point(902, 373);
            this.buttonRemoveMapLayer.Name = "buttonRemoveMapLayer";
            this.buttonRemoveMapLayer.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveMapLayer.TabIndex = 37;
            this.buttonRemoveMapLayer.Text = "Remove";
            this.buttonRemoveMapLayer.UseVisualStyleBackColor = true;
            this.buttonRemoveMapLayer.Click += new System.EventHandler(this.buttonRemoveMapLayer_Click);
            // 
            // vScrollBarTileLibList
            // 
            this.vScrollBarTileLibList.Location = new System.Drawing.Point(1241, 167);
            this.vScrollBarTileLibList.Name = "vScrollBarTileLibList";
            this.vScrollBarTileLibList.Size = new System.Drawing.Size(17, 200);
            this.vScrollBarTileLibList.TabIndex = 40;
            this.vScrollBarTileLibList.ValueChanged += new System.EventHandler(this.vScrollBarTileLibList_ValueChanged);
            // 
            // buttonRemoveTileLib
            // 
            this.buttonRemoveTileLib.Location = new System.Drawing.Point(1141, 373);
            this.buttonRemoveTileLib.Name = "buttonRemoveTileLib";
            this.buttonRemoveTileLib.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveTileLib.TabIndex = 41;
            this.buttonRemoveTileLib.Text = "Remove";
            this.buttonRemoveTileLib.UseVisualStyleBackColor = true;
            this.buttonRemoveTileLib.Click += new System.EventHandler(this.buttonRemoveTileLib_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1145, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Tile Libraries";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(920, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Layers";
            // 
            // buttonNukeMap
            // 
            this.buttonNukeMap.Image = global::MapEditor.Properties.Resources.NukeMap;
            this.buttonNukeMap.Location = new System.Drawing.Point(1407, 12);
            this.buttonNukeMap.Name = "buttonNukeMap";
            this.buttonNukeMap.Size = new System.Drawing.Size(41, 41);
            this.buttonNukeMap.TabIndex = 5;
            this.buttonNukeMap.UseVisualStyleBackColor = true;
            this.buttonNukeMap.Click += new System.EventHandler(this.buttonNukeMap_Click);
            // 
            // buttonNewMap
            // 
            this.buttonNewMap.Image = global::MapEditor.Properties.Resources.NewMap;
            this.buttonNewMap.Location = new System.Drawing.Point(1354, 12);
            this.buttonNewMap.Name = "buttonNewMap";
            this.buttonNewMap.Size = new System.Drawing.Size(41, 41);
            this.buttonNewMap.TabIndex = 6;
            this.buttonNewMap.UseVisualStyleBackColor = true;
            this.buttonNewMap.Click += new System.EventHandler(this.buttonNewMap_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(922, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Layers";
            // 
            // vScrollBarMapLayerList
            // 
            this.vScrollBarMapLayerList.Location = new System.Drawing.Point(1002, 167);
            this.vScrollBarMapLayerList.Name = "vScrollBarMapLayerList";
            this.vScrollBarMapLayerList.Size = new System.Drawing.Size(17, 200);
            this.vScrollBarMapLayerList.TabIndex = 35;
            this.vScrollBarMapLayerList.ValueChanged += new System.EventHandler(this.vScrollBarMapLayerList_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(847, 422);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "label11";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(847, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(847, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 46;
            this.label14.Text = "label14";
            // 
            // buttonMapGridColour
            // 
            this.buttonMapGridColour.Location = new System.Drawing.Point(624, 702);
            this.buttonMapGridColour.Name = "buttonMapGridColour";
            this.buttonMapGridColour.Size = new System.Drawing.Size(75, 23);
            this.buttonMapGridColour.TabIndex = 47;
            this.buttonMapGridColour.Text = "Grid Colour";
            this.buttonMapGridColour.UseVisualStyleBackColor = true;
            this.buttonMapGridColour.Click += new System.EventHandler(this.buttonMapGridColour_Click);
            // 
            // labelGridR
            // 
            this.labelGridR.AutoSize = true;
            this.labelGridR.Location = new System.Drawing.Point(705, 707);
            this.labelGridR.Name = "labelGridR";
            this.labelGridR.Size = new System.Drawing.Size(13, 13);
            this.labelGridR.TabIndex = 48;
            this.labelGridR.Text = "0";
            // 
            // labelGridG
            // 
            this.labelGridG.AutoSize = true;
            this.labelGridG.Location = new System.Drawing.Point(752, 707);
            this.labelGridG.Name = "labelGridG";
            this.labelGridG.Size = new System.Drawing.Size(13, 13);
            this.labelGridG.TabIndex = 49;
            this.labelGridG.Text = "0";
            // 
            // labelGridB
            // 
            this.labelGridB.AutoSize = true;
            this.labelGridB.Location = new System.Drawing.Point(799, 707);
            this.labelGridB.Name = "labelGridB";
            this.labelGridB.Size = new System.Drawing.Size(13, 13);
            this.labelGridB.TabIndex = 50;
            this.labelGridB.Text = "0";
            // 
            // buttonLoadMap
            // 
            this.buttonLoadMap.Location = new System.Drawing.Point(847, 632);
            this.buttonLoadMap.Name = "buttonLoadMap";
            this.buttonLoadMap.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadMap.TabIndex = 51;
            this.buttonLoadMap.Text = "Load Map";
            this.buttonLoadMap.UseVisualStyleBackColor = true;
            this.buttonLoadMap.Click += new System.EventHandler(this.buttonLoadMap_Click);
            // 
            // buttonSaveMap
            // 
            this.buttonSaveMap.Location = new System.Drawing.Point(937, 632);
            this.buttonSaveMap.Name = "buttonSaveMap";
            this.buttonSaveMap.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveMap.TabIndex = 52;
            this.buttonSaveMap.Text = "Save Map";
            this.buttonSaveMap.UseVisualStyleBackColor = true;
            this.buttonSaveMap.Click += new System.EventHandler(this.buttonSaveMap_Click);
            // 
            // panelCustomLayerList
            // 
            this.panelCustomLayerList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCustomLayerList.Location = new System.Drawing.Point(879, 167);
            this.panelCustomLayerList.Name = "panelCustomLayerList";
            this.panelCustomLayerList.Size = new System.Drawing.Size(120, 200);
            this.panelCustomLayerList.TabIndex = 34;
            this.panelCustomLayerList.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDBLayerList_Paint);
            this.panelCustomLayerList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDBLayerList_MouseDown);
            this.panelCustomLayerList.MouseLeave += new System.EventHandler(this.panelCustomLayerList_MouseLeave);
            this.panelCustomLayerList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCustomLayerList_MouseMove);
            // 
            // panelCustomTileLibList
            // 
            this.panelCustomTileLibList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCustomTileLibList.Location = new System.Drawing.Point(1118, 167);
            this.panelCustomTileLibList.Name = "panelCustomTileLibList";
            this.panelCustomTileLibList.Size = new System.Drawing.Size(120, 200);
            this.panelCustomTileLibList.TabIndex = 39;
            this.panelCustomTileLibList.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDBTileLibList_Paint);
            this.panelCustomTileLibList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDBTileLibList_MouseDown);
            this.panelCustomTileLibList.MouseLeave += new System.EventHandler(this.panelDBTileLibList_MouseLeave);
            this.panelCustomTileLibList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDBTileLibList_MouseMove);
            // 
            // panelCustomTileSelected
            // 
            this.panelCustomTileSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCustomTileSelected.Location = new System.Drawing.Point(1169, 568);
            this.panelCustomTileSelected.Name = "panelCustomTileSelected";
            this.panelCustomTileSelected.Size = new System.Drawing.Size(100, 100);
            this.panelCustomTileSelected.TabIndex = 33;
            this.panelCustomTileSelected.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDBTileSelected_Paint);
            // 
            // panelCustom3
            // 
            this.panelCustom3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCustom3.Controls.Add(this.label9);
            this.panelCustom3.Controls.Add(this.label3);
            this.panelCustom3.Controls.Add(this.buttonLoadTileLib);
            this.panelCustom3.Controls.Add(this.label4);
            this.panelCustom3.Controls.Add(this.textBoxCustomTileHeight);
            this.panelCustom3.Controls.Add(this.textBoxCustomTileWidth);
            this.panelCustom3.Location = new System.Drawing.Point(847, 68);
            this.panelCustom3.Name = "panelCustom3";
            this.panelCustom3.Size = new System.Drawing.Size(422, 56);
            this.panelCustom3.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Cell Dimensions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tile Width";
            // 
            // buttonLoadTileLib
            // 
            this.buttonLoadTileLib.Location = new System.Drawing.Point(340, 24);
            this.buttonLoadTileLib.Name = "buttonLoadTileLib";
            this.buttonLoadTileLib.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadTileLib.TabIndex = 40;
            this.buttonLoadTileLib.Text = "Load Tiles";
            this.buttonLoadTileLib.UseVisualStyleBackColor = true;
            this.buttonLoadTileLib.Click += new System.EventHandler(this.buttonLoadTileLib_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Tile Height";
            // 
            // textBoxCustomTileHeight
            // 
            this.textBoxCustomTileHeight.Location = new System.Drawing.Point(234, 26);
            this.textBoxCustomTileHeight.Name = "textBoxCustomTileHeight";
            this.textBoxCustomTileHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomTileHeight.TabIndex = 45;
            // 
            // textBoxCustomTileWidth
            // 
            this.textBoxCustomTileWidth.Location = new System.Drawing.Point(64, 26);
            this.textBoxCustomTileWidth.Name = "textBoxCustomTileWidth";
            this.textBoxCustomTileWidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomTileWidth.TabIndex = 44;
            // 
            // panelCustom2
            // 
            this.panelCustom2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCustom2.Controls.Add(this.textBoxCustomMapRows);
            this.panelCustom2.Controls.Add(this.label7);
            this.panelCustom2.Controls.Add(this.textBoxCustomMapCellHeight);
            this.panelCustom2.Controls.Add(this.textBoxCustomMapColumns);
            this.panelCustom2.Controls.Add(this.label10);
            this.panelCustom2.Controls.Add(this.textBoxCustomMapCellWidth);
            this.panelCustom2.Controls.Add(this.label8);
            this.panelCustom2.Controls.Add(this.label1);
            this.panelCustom2.Controls.Add(this.label2);
            this.panelCustom2.Controls.Add(this.buttonAddMapLayer);
            this.panelCustom2.Controls.Add(this.buttonInsertLayer);
            this.panelCustom2.Location = new System.Drawing.Point(847, 441);
            this.panelCustom2.Name = "panelCustom2";
            this.panelCustom2.Size = new System.Drawing.Size(422, 111);
            this.panelCustom2.TabIndex = 31;
            // 
            // textBoxCustomMapRows
            // 
            this.textBoxCustomMapRows.Location = new System.Drawing.Point(278, 52);
            this.textBoxCustomMapRows.Name = "textBoxCustomMapRows";
            this.textBoxCustomMapRows.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomMapRows.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Cell Width";
            // 
            // textBoxCustomMapCellHeight
            // 
            this.textBoxCustomMapCellHeight.Location = new System.Drawing.Point(278, 25);
            this.textBoxCustomMapCellHeight.Name = "textBoxCustomMapCellHeight";
            this.textBoxCustomMapCellHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomMapCellHeight.TabIndex = 47;
            // 
            // textBoxCustomMapColumns
            // 
            this.textBoxCustomMapColumns.Location = new System.Drawing.Point(108, 52);
            this.textBoxCustomMapColumns.Name = "textBoxCustomMapColumns";
            this.textBoxCustomMapColumns.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomMapColumns.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(214, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Cell Height";
            // 
            // textBoxCustomMapCellWidth
            // 
            this.textBoxCustomMapCellWidth.Location = new System.Drawing.Point(108, 26);
            this.textBoxCustomMapCellWidth.Name = "textBoxCustomMapCellWidth";
            this.textBoxCustomMapCellWidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomMapCellWidth.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(163, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Layer Dimensions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Column Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Row Count";
            // 
            // buttonAddMapLayer
            // 
            this.buttonAddMapLayer.Location = new System.Drawing.Point(224, 77);
            this.buttonAddMapLayer.Name = "buttonAddMapLayer";
            this.buttonAddMapLayer.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMapLayer.TabIndex = 36;
            this.buttonAddMapLayer.Text = "Add Layer";
            this.buttonAddMapLayer.UseVisualStyleBackColor = true;
            this.buttonAddMapLayer.Click += new System.EventHandler(this.buttonAddMapLayer_Click);
            // 
            // buttonInsertLayer
            // 
            this.buttonInsertLayer.Location = new System.Drawing.Point(305, 77);
            this.buttonInsertLayer.Name = "buttonInsertLayer";
            this.buttonInsertLayer.Size = new System.Drawing.Size(75, 23);
            this.buttonInsertLayer.TabIndex = 38;
            this.buttonInsertLayer.Text = "Insert";
            this.buttonInsertLayer.UseVisualStyleBackColor = true;
            this.buttonInsertLayer.Click += new System.EventHandler(this.buttonInsertMapLayer_Click);
            // 
            // panelCustomTileWindow
            // 
            this.panelCustomTileWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCustomTileWindow.Location = new System.Drawing.Point(1275, 68);
            this.panelCustomTileWindow.Name = "panelCustomTileWindow";
            this.panelCustomTileWindow.Size = new System.Drawing.Size(400, 600);
            this.panelCustomTileWindow.TabIndex = 28;
            this.panelCustomTileWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCustomTileWindow_Paint);
            this.panelCustomTileWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCustomTileWindow_MouseDown);
            // 
            // panelCustomMapWindow
            // 
            this.panelCustomMapWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCustomMapWindow.Location = new System.Drawing.Point(12, 68);
            this.panelCustomMapWindow.Name = "panelCustomMapWindow";
            this.panelCustomMapWindow.Size = new System.Drawing.Size(800, 600);
            this.panelCustomMapWindow.TabIndex = 27;
            this.panelCustomMapWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCustomMapWindow_Paint);
            this.panelCustomMapWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelCustomMapWindow_MouseDown);
            this.panelCustomMapWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCustomMapWindow_MouseMove);
            this.panelCustomMapWindow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelCustomMapWindow_MouseUp);
            // 
            // panelCustom1
            // 
            this.panelCustom1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCustom1.Controls.Add(this.buttonSaveAll);
            this.panelCustom1.Controls.Add(this.buttonOpenMap);
            this.panelCustom1.Controls.Add(this.buttonSelectMapCells);
            this.panelCustom1.Controls.Add(this.buttonEraseMapCell);
            this.panelCustom1.Controls.Add(this.buttonEditMapCell);
            this.panelCustom1.Location = new System.Drawing.Point(12, 12);
            this.panelCustom1.Name = "panelCustom1";
            this.panelCustom1.Size = new System.Drawing.Size(800, 50);
            this.panelCustom1.TabIndex = 24;
            // 
            // buttonSaveAll
            // 
            this.buttonSaveAll.Image = global::MapEditor.Properties.Resources.SaveAll;
            this.buttonSaveAll.Location = new System.Drawing.Point(51, 4);
            this.buttonSaveAll.Name = "buttonSaveAll";
            this.buttonSaveAll.Size = new System.Drawing.Size(41, 41);
            this.buttonSaveAll.TabIndex = 4;
            this.buttonSaveAll.UseVisualStyleBackColor = true;
            // 
            // buttonOpenMap
            // 
            this.buttonOpenMap.Image = global::MapEditor.Properties.Resources.Open;
            this.buttonOpenMap.Location = new System.Drawing.Point(4, 4);
            this.buttonOpenMap.Name = "buttonOpenMap";
            this.buttonOpenMap.Size = new System.Drawing.Size(41, 41);
            this.buttonOpenMap.TabIndex = 3;
            this.buttonOpenMap.UseVisualStyleBackColor = true;
            // 
            // buttonSelectMapCells
            // 
            this.buttonSelectMapCells.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSelectMapCells.Image = global::MapEditor.Properties.Resources.Select;
            this.buttonSelectMapCells.Location = new System.Drawing.Point(192, 4);
            this.buttonSelectMapCells.Name = "buttonSelectMapCells";
            this.buttonSelectMapCells.Size = new System.Drawing.Size(41, 41);
            this.buttonSelectMapCells.TabIndex = 2;
            this.buttonSelectMapCells.UseVisualStyleBackColor = true;
            this.buttonSelectMapCells.Click += new System.EventHandler(this.SelectTool);
            // 
            // buttonEraseMapCell
            // 
            this.buttonEraseMapCell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEraseMapCell.Image = global::MapEditor.Properties.Resources.Eraser;
            this.buttonEraseMapCell.Location = new System.Drawing.Point(145, 4);
            this.buttonEraseMapCell.Name = "buttonEraseMapCell";
            this.buttonEraseMapCell.Size = new System.Drawing.Size(41, 41);
            this.buttonEraseMapCell.TabIndex = 1;
            this.buttonEraseMapCell.UseVisualStyleBackColor = true;
            this.buttonEraseMapCell.Click += new System.EventHandler(this.SelectTool);
            // 
            // buttonEditMapCell
            // 
            this.buttonEditMapCell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEditMapCell.Image = global::MapEditor.Properties.Resources.Edit;
            this.buttonEditMapCell.Location = new System.Drawing.Point(98, 4);
            this.buttonEditMapCell.Name = "buttonEditMapCell";
            this.buttonEditMapCell.Size = new System.Drawing.Size(41, 41);
            this.buttonEditMapCell.TabIndex = 0;
            this.buttonEditMapCell.UseVisualStyleBackColor = true;
            this.buttonEditMapCell.Click += new System.EventHandler(this.SelectTool);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1784, 762);
            this.Controls.Add(this.buttonSaveMap);
            this.Controls.Add(this.buttonLoadMap);
            this.Controls.Add(this.labelGridB);
            this.Controls.Add(this.labelGridG);
            this.Controls.Add(this.labelGridR);
            this.Controls.Add(this.buttonMapGridColour);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panelCustomLayerList);
            this.Controls.Add(this.vScrollBarMapLayerList);
            this.Controls.Add(this.buttonNewMap);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonNukeMap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonRemoveTileLib);
            this.Controls.Add(this.vScrollBarTileLibList);
            this.Controls.Add(this.panelCustomTileLibList);
            this.Controls.Add(this.buttonRemoveMapLayer);
            this.Controls.Add(this.panelCustomTileSelected);
            this.Controls.Add(this.panelCustom3);
            this.Controls.Add(this.panelCustom2);
            this.Controls.Add(this.vScrollBarTileLib);
            this.Controls.Add(this.hScrollBarTileLib);
            this.Controls.Add(this.panelCustomTileWindow);
            this.Controls.Add(this.panelCustomMapWindow);
            this.Controls.Add(this.vScrollBarTileMap);
            this.Controls.Add(this.hScrollBarTileMap);
            this.Controls.Add(this.panelCustom1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MapEditor";
            this.panelCustom3.ResumeLayout(false);
            this.panelCustom3.PerformLayout();
            this.panelCustom2.ResumeLayout(false);
            this.panelCustom2.PerformLayout();
            this.panelCustom1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MapEditor.PanelCustom panelCustom1;
        private System.Windows.Forms.Button buttonNewMap;
        private System.Windows.Forms.Button buttonNukeMap;
        private System.Windows.Forms.Button buttonSaveAll;
        private System.Windows.Forms.Button buttonOpenMap;
        private System.Windows.Forms.Button buttonSelectMapCells;
        private System.Windows.Forms.Button buttonEraseMapCell;
        private System.Windows.Forms.Button buttonEditMapCell;
        private MapEditor.PanelCustom panelCustomMapWindow;
        private System.Windows.Forms.VScrollBar vScrollBarTileMap;
        private System.Windows.Forms.HScrollBar hScrollBarTileMap;
        private PanelCustom panelCustomTileWindow;
        private System.Windows.Forms.VScrollBar vScrollBarTileLib;
        private System.Windows.Forms.HScrollBar hScrollBarTileLib;
        private PanelCustom panelCustom2;
        private PanelCustom panelCustom3;
        private PanelCustom panelCustomTileSelected;
        private PanelCustom panelCustomLayerList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLoadTileLib;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddMapLayer;
        private System.Windows.Forms.Button buttonRemoveMapLayer;
        private System.Windows.Forms.Button buttonInsertLayer;
        private System.Windows.Forms.VScrollBar vScrollBarTileLibList;
        private PanelCustom panelCustomTileLibList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonRemoveTileLib;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.VScrollBar vScrollBarMapLayerList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private TextBoxCustom textBoxCustomTileWidth;
        private TextBoxCustom textBoxCustomTileHeight;
        private TextBoxCustom textBoxCustomMapCellWidth;
        private TextBoxCustom textBoxCustomMapCellHeight;
        private TextBoxCustom textBoxCustomMapRows;
        private TextBoxCustom textBoxCustomMapColumns;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonMapGridColour;
        private System.Windows.Forms.Label labelGridR;
        private System.Windows.Forms.Label labelGridG;
        private System.Windows.Forms.Label labelGridB;
        private System.Windows.Forms.Button buttonLoadMap;
        private System.Windows.Forms.Button buttonSaveMap;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

