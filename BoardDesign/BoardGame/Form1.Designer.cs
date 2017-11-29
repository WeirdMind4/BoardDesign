namespace BoardGame
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
            this.lblHbg = new System.Windows.Forms.Label();
            this.lblWbg = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.btnColorBG = new System.Windows.Forms.Button();
            this.cbAllTiles = new System.Windows.Forms.CheckBox();
            this.btnImageBG = new System.Windows.Forms.Button();
            this.btnImagePawn = new System.Windows.Forms.Button();
            this.btnColorPawn = new System.Windows.Forms.Button();
            this.tbUnitW = new System.Windows.Forms.TextBox();
            this.tbUnitH = new System.Windows.Forms.TextBox();
            this.lblWp = new System.Windows.Forms.Label();
            this.lblHp = new System.Windows.Forms.Label();
            this.cbShapes = new System.Windows.Forms.ComboBox();
            this.btnDeleteTile = new System.Windows.Forms.Button();
            this.btnImageTile = new System.Windows.Forms.Button();
            this.btnColorTile = new System.Windows.Forms.Button();
            this.lblWt = new System.Windows.Forms.Label();
            this.lblHt = new System.Windows.Forms.Label();
            this.gbInitialInfo = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbStartX = new System.Windows.Forms.TextBox();
            this.tbStartY = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTileWidth = new System.Windows.Forms.TextBox();
            this.tbTileHeight = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbTileW = new System.Windows.Forms.TextBox();
            this.tbTileH = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDeleteUnit = new System.Windows.Forms.Button();
            this.cbAllUnits = new System.Windows.Forms.CheckBox();
            this.addUnit = new System.Windows.Forms.Button();
            this.connectionsTab = new System.Windows.Forms.TabPage();
            this.showConnections = new System.Windows.Forms.Button();
            this.connection = new System.Windows.Forms.Button();
            this.SaveLoadTab = new System.Windows.Forms.TabPage();
            this.LoadFile = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.gbToolbox = new System.Windows.Forms.GroupBox();
            this.gbArrows = new System.Windows.Forms.GroupBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnPlace = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.gbInitialInfo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.connectionsTab.SuspendLayout();
            this.SaveLoadTab.SuspendLayout();
            this.gbToolbox.SuspendLayout();
            this.gbArrows.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHbg
            // 
            this.lblHbg.AutoSize = true;
            this.lblHbg.Location = new System.Drawing.Point(9, 15);
            this.lblHbg.Name = "lblHbg";
            this.lblHbg.Size = new System.Drawing.Size(38, 13);
            this.lblHbg.TabIndex = 0;
            this.lblHbg.Text = "Height";
            // 
            // lblWbg
            // 
            this.lblWbg.AutoSize = true;
            this.lblWbg.Location = new System.Drawing.Point(9, 42);
            this.lblWbg.Name = "lblWbg";
            this.lblWbg.Size = new System.Drawing.Size(35, 13);
            this.lblWbg.TabIndex = 1;
            this.lblWbg.Text = "Width";
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(51, 13);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(26, 20);
            this.tbHeight.TabIndex = 2;
            this.tbHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.formSize_Enter);
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(51, 39);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(26, 20);
            this.tbWidth.TabIndex = 7;
            this.tbWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.formSize_Enter);
            // 
            // btnColorBG
            // 
            this.btnColorBG.Location = new System.Drawing.Point(98, 10);
            this.btnColorBG.Name = "btnColorBG";
            this.btnColorBG.Size = new System.Drawing.Size(44, 23);
            this.btnColorBG.TabIndex = 6;
            this.btnColorBG.Text = "Color";
            this.btnColorBG.UseVisualStyleBackColor = true;
            this.btnColorBG.Click += new System.EventHandler(this.btnColorDialog_Click);
            // 
            // cbAllTiles
            // 
            this.cbAllTiles.AutoSize = true;
            this.cbAllTiles.Location = new System.Drawing.Point(280, 42);
            this.cbAllTiles.Name = "cbAllTiles";
            this.cbAllTiles.Size = new System.Drawing.Size(62, 17);
            this.cbAllTiles.TabIndex = 6;
            this.cbAllTiles.Text = "All Tiles";
            this.cbAllTiles.UseVisualStyleBackColor = true;
            // 
            // btnImageBG
            // 
            this.btnImageBG.Location = new System.Drawing.Point(98, 37);
            this.btnImageBG.Name = "btnImageBG";
            this.btnImageBG.Size = new System.Drawing.Size(44, 23);
            this.btnImageBG.TabIndex = 5;
            this.btnImageBG.Text = "Image";
            this.btnImageBG.UseVisualStyleBackColor = true;
            this.btnImageBG.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnImagePawn
            // 
            this.btnImagePawn.Location = new System.Drawing.Point(98, 37);
            this.btnImagePawn.Name = "btnImagePawn";
            this.btnImagePawn.Size = new System.Drawing.Size(44, 23);
            this.btnImagePawn.TabIndex = 5;
            this.btnImagePawn.Text = "Image";
            this.btnImagePawn.UseVisualStyleBackColor = true;
            this.btnImagePawn.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnColorPawn
            // 
            this.btnColorPawn.Location = new System.Drawing.Point(98, 10);
            this.btnColorPawn.Name = "btnColorPawn";
            this.btnColorPawn.Size = new System.Drawing.Size(44, 23);
            this.btnColorPawn.TabIndex = 4;
            this.btnColorPawn.Text = "Color";
            this.btnColorPawn.UseVisualStyleBackColor = true;
            this.btnColorPawn.Click += new System.EventHandler(this.btnColorDialog_Click);
            // 
            // tbUnitW
            // 
            this.tbUnitW.Location = new System.Drawing.Point(51, 39);
            this.tbUnitW.Name = "tbUnitW";
            this.tbUnitW.Size = new System.Drawing.Size(26, 20);
            this.tbUnitW.TabIndex = 3;
            this.tbUnitW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tileSize_Enter);
            // 
            // tbUnitH
            // 
            this.tbUnitH.Location = new System.Drawing.Point(51, 13);
            this.tbUnitH.Name = "tbUnitH";
            this.tbUnitH.Size = new System.Drawing.Size(26, 20);
            this.tbUnitH.TabIndex = 2;
            this.tbUnitH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unitSize_Enter);
            // 
            // lblWp
            // 
            this.lblWp.AutoSize = true;
            this.lblWp.Location = new System.Drawing.Point(9, 42);
            this.lblWp.Name = "lblWp";
            this.lblWp.Size = new System.Drawing.Size(35, 13);
            this.lblWp.TabIndex = 1;
            this.lblWp.Text = "Width";
            // 
            // lblHp
            // 
            this.lblHp.AutoSize = true;
            this.lblHp.Location = new System.Drawing.Point(9, 15);
            this.lblHp.Name = "lblHp";
            this.lblHp.Size = new System.Drawing.Size(38, 13);
            this.lblHp.TabIndex = 0;
            this.lblHp.Text = "Height";
            // 
            // cbShapes
            // 
            this.cbShapes.FormattingEnabled = true;
            this.cbShapes.Items.AddRange(new object[] {
            "Circle",
            "Triangle"});
            this.cbShapes.Location = new System.Drawing.Point(159, 13);
            this.cbShapes.Name = "cbShapes";
            this.cbShapes.Size = new System.Drawing.Size(63, 21);
            this.cbShapes.TabIndex = 7;
            this.cbShapes.SelectedIndexChanged += new System.EventHandler(this.cbShapes_SelectedIndexChanged);
            // 
            // btnDeleteTile
            // 
            this.btnDeleteTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTile.Location = new System.Drawing.Point(280, 9);
            this.btnDeleteTile.Name = "btnDeleteTile";
            this.btnDeleteTile.Size = new System.Drawing.Size(62, 25);
            this.btnDeleteTile.TabIndex = 6;
            this.btnDeleteTile.Text = "Delete";
            this.btnDeleteTile.UseVisualStyleBackColor = true;
            this.btnDeleteTile.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnImageTile
            // 
            this.btnImageTile.Location = new System.Drawing.Point(98, 37);
            this.btnImageTile.Name = "btnImageTile";
            this.btnImageTile.Size = new System.Drawing.Size(44, 23);
            this.btnImageTile.TabIndex = 5;
            this.btnImageTile.Text = "Image";
            this.btnImageTile.UseVisualStyleBackColor = true;
            this.btnImageTile.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnColorTile
            // 
            this.btnColorTile.Location = new System.Drawing.Point(98, 10);
            this.btnColorTile.Name = "btnColorTile";
            this.btnColorTile.Size = new System.Drawing.Size(44, 23);
            this.btnColorTile.TabIndex = 4;
            this.btnColorTile.Text = "Color";
            this.btnColorTile.UseVisualStyleBackColor = true;
            this.btnColorTile.Click += new System.EventHandler(this.btnColorDialog_Click);
            // 
            // lblWt
            // 
            this.lblWt.AutoSize = true;
            this.lblWt.Location = new System.Drawing.Point(9, 42);
            this.lblWt.Name = "lblWt";
            this.lblWt.Size = new System.Drawing.Size(35, 13);
            this.lblWt.TabIndex = 1;
            this.lblWt.Text = "Width";
            // 
            // lblHt
            // 
            this.lblHt.AutoSize = true;
            this.lblHt.Location = new System.Drawing.Point(9, 15);
            this.lblHt.Name = "lblHt";
            this.lblHt.Size = new System.Drawing.Size(38, 13);
            this.lblHt.TabIndex = 0;
            this.lblHt.Text = "Height";
            // 
            // gbInitialInfo
            // 
            this.gbInitialInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbInitialInfo.Controls.Add(this.label16);
            this.gbInitialInfo.Controls.Add(this.btnCreate);
            this.gbInitialInfo.Controls.Add(this.label13);
            this.gbInitialInfo.Controls.Add(this.tbStartX);
            this.gbInitialInfo.Controls.Add(this.tbStartY);
            this.gbInitialInfo.Controls.Add(this.label14);
            this.gbInitialInfo.Controls.Add(this.label15);
            this.gbInitialInfo.Controls.Add(this.label10);
            this.gbInitialInfo.Controls.Add(this.tbTileWidth);
            this.gbInitialInfo.Controls.Add(this.tbTileHeight);
            this.gbInitialInfo.Controls.Add(this.label11);
            this.gbInitialInfo.Controls.Add(this.label12);
            this.gbInitialInfo.Location = new System.Drawing.Point(127, 130);
            this.gbInitialInfo.Name = "gbInitialInfo";
            this.gbInitialInfo.Size = new System.Drawing.Size(197, 168);
            this.gbInitialInfo.TabIndex = 7;
            this.gbInitialInfo.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 131);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Leave Empty for Defaults";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(42, 90);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(101, 29);
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(103, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Start Position";
            // 
            // tbStartX
            // 
            this.tbStartX.Location = new System.Drawing.Point(140, 64);
            this.tbStartX.Name = "tbStartX";
            this.tbStartX.Size = new System.Drawing.Size(26, 20);
            this.tbStartX.TabIndex = 17;
            // 
            // tbStartY
            // 
            this.tbStartY.Location = new System.Drawing.Point(140, 37);
            this.tbStartY.Name = "tbStartY";
            this.tbStartY.Size = new System.Drawing.Size(26, 20);
            this.tbStartY.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(89, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "Horizontal";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(96, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Vertical";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Tile Size";
            // 
            // tbTileWidth
            // 
            this.tbTileWidth.Location = new System.Drawing.Point(57, 64);
            this.tbTileWidth.Name = "tbTileWidth";
            this.tbTileWidth.Size = new System.Drawing.Size(26, 20);
            this.tbTileWidth.TabIndex = 12;
            // 
            // tbTileHeight
            // 
            this.tbTileHeight.Location = new System.Drawing.Point(57, 37);
            this.tbTileHeight.Name = "tbTileHeight";
            this.tbTileHeight.Size = new System.Drawing.Size(26, 20);
            this.tbTileHeight.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Width";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Height";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.connectionsTab);
            this.tabControl1.Controls.Add(this.SaveLoadTab);
            this.tabControl1.Location = new System.Drawing.Point(-3, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(361, 92);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnColorBG);
            this.tabPage1.Controls.Add(this.btnImageBG);
            this.tabPage1.Controls.Add(this.lblHbg);
            this.tabPage1.Controls.Add(this.tbHeight);
            this.tabPage1.Controls.Add(this.lblWbg);
            this.tabPage1.Controls.Add(this.tbWidth);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(353, 66);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Background";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbTileW);
            this.tabPage2.Controls.Add(this.tbTileH);
            this.tabPage2.Controls.Add(this.btnDeleteTile);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.cbShapes);
            this.tabPage2.Controls.Add(this.cbAllTiles);
            this.tabPage2.Controls.Add(this.lblHt);
            this.tabPage2.Controls.Add(this.lblWt);
            this.tabPage2.Controls.Add(this.btnImageTile);
            this.tabPage2.Controls.Add(this.btnColorTile);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(353, 66);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tiles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbTileW
            // 
            this.tbTileW.Location = new System.Drawing.Point(51, 39);
            this.tbTileW.Name = "tbTileW";
            this.tbTileW.Size = new System.Drawing.Size(26, 20);
            this.tbTileW.TabIndex = 22;
            this.tbTileW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tileSize_Enter);
            // 
            // tbTileH
            // 
            this.tbTileH.Location = new System.Drawing.Point(51, 13);
            this.tbTileH.Name = "tbTileH";
            this.tbTileH.Size = new System.Drawing.Size(26, 20);
            this.tbTileH.TabIndex = 21;
            this.tbTileH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tileSize_Enter);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(228, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "Shape";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDeleteUnit);
            this.tabPage3.Controls.Add(this.cbAllUnits);
            this.tabPage3.Controls.Add(this.addUnit);
            this.tabPage3.Controls.Add(this.btnImagePawn);
            this.tabPage3.Controls.Add(this.tbUnitH);
            this.tabPage3.Controls.Add(this.btnColorPawn);
            this.tabPage3.Controls.Add(this.lblHp);
            this.tabPage3.Controls.Add(this.tbUnitW);
            this.tabPage3.Controls.Add(this.lblWp);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(353, 66);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Units";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUnit
            // 
            this.btnDeleteUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUnit.Location = new System.Drawing.Point(280, 9);
            this.btnDeleteUnit.Name = "btnDeleteUnit";
            this.btnDeleteUnit.Size = new System.Drawing.Size(62, 25);
            this.btnDeleteUnit.TabIndex = 8;
            this.btnDeleteUnit.Text = "Delete";
            this.btnDeleteUnit.UseVisualStyleBackColor = true;
            // 
            // cbAllUnits
            // 
            this.cbAllUnits.AutoSize = true;
            this.cbAllUnits.Location = new System.Drawing.Point(280, 42);
            this.cbAllUnits.Name = "cbAllUnits";
            this.cbAllUnits.Size = new System.Drawing.Size(62, 17);
            this.cbAllUnits.TabIndex = 7;
            this.cbAllUnits.Text = "All Tiles";
            this.cbAllUnits.UseVisualStyleBackColor = true;
            // 
            // addUnit
            // 
            this.addUnit.Location = new System.Drawing.Point(148, 10);
            this.addUnit.Name = "addUnit";
            this.addUnit.Size = new System.Drawing.Size(75, 23);
            this.addUnit.TabIndex = 6;
            this.addUnit.Text = "Add Unit";
            this.addUnit.UseVisualStyleBackColor = true;
            this.addUnit.Click += new System.EventHandler(this.addUnit_Click);
            // 
            // connectionsTab
            // 
            this.connectionsTab.Controls.Add(this.showConnections);
            this.connectionsTab.Controls.Add(this.connection);
            this.connectionsTab.Location = new System.Drawing.Point(4, 22);
            this.connectionsTab.Name = "connectionsTab";
            this.connectionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.connectionsTab.Size = new System.Drawing.Size(353, 66);
            this.connectionsTab.TabIndex = 3;
            this.connectionsTab.Text = "Connections";
            this.connectionsTab.UseVisualStyleBackColor = true;
            // 
            // showConnections
            // 
            this.showConnections.Location = new System.Drawing.Point(120, 7);
            this.showConnections.Name = "showConnections";
            this.showConnections.Size = new System.Drawing.Size(116, 23);
            this.showConnections.TabIndex = 24;
            this.showConnections.Text = "Show Connections";
            this.showConnections.UseVisualStyleBackColor = true;
            this.showConnections.Click += new System.EventHandler(this.showConnections_Click);
            // 
            // connection
            // 
            this.connection.Location = new System.Drawing.Point(6, 6);
            this.connection.Name = "connection";
            this.connection.Size = new System.Drawing.Size(107, 23);
            this.connection.TabIndex = 23;
            this.connection.Text = "Add Connection";
            this.connection.UseVisualStyleBackColor = true;
            this.connection.Click += new System.EventHandler(this.connection_Click);
            // 
            // SaveLoadTab
            // 
            this.SaveLoadTab.Controls.Add(this.LoadFile);
            this.SaveLoadTab.Controls.Add(this.Save);
            this.SaveLoadTab.Location = new System.Drawing.Point(4, 22);
            this.SaveLoadTab.Name = "SaveLoadTab";
            this.SaveLoadTab.Padding = new System.Windows.Forms.Padding(3);
            this.SaveLoadTab.Size = new System.Drawing.Size(353, 66);
            this.SaveLoadTab.TabIndex = 4;
            this.SaveLoadTab.Text = "Save / Load";
            this.SaveLoadTab.UseVisualStyleBackColor = true;
            // 
            // LoadFile
            // 
            this.LoadFile.Location = new System.Drawing.Point(101, 13);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(75, 23);
            this.LoadFile.TabIndex = 1;
            this.LoadFile.Text = "Load";
            this.LoadFile.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(19, 13);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // gbToolbox
            // 
            this.gbToolbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbToolbox.BackColor = System.Drawing.SystemColors.Control;
            this.gbToolbox.Controls.Add(this.tabControl1);
            this.gbToolbox.Controls.Add(this.gbArrows);
            this.gbToolbox.Enabled = false;
            this.gbToolbox.Location = new System.Drawing.Point(5, -4);
            this.gbToolbox.Name = "gbToolbox";
            this.gbToolbox.Size = new System.Drawing.Size(447, 100);
            this.gbToolbox.TabIndex = 14;
            this.gbToolbox.TabStop = false;
            // 
            // gbArrows
            // 
            this.gbArrows.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbArrows.Controls.Add(this.btnDown);
            this.gbArrows.Controls.Add(this.btnPlace);
            this.gbArrows.Controls.Add(this.btnRight);
            this.gbArrows.Controls.Add(this.btnLeft);
            this.gbArrows.Controls.Add(this.btnUp);
            this.gbArrows.Location = new System.Drawing.Point(362, 9);
            this.gbArrows.Name = "gbArrows";
            this.gbArrows.Padding = new System.Windows.Forms.Padding(0);
            this.gbArrows.Size = new System.Drawing.Size(80, 88);
            this.gbArrows.TabIndex = 7;
            this.gbArrows.TabStop = false;
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.Transparent;
            this.btnDown.BackgroundImage = global::BoardGame.Properties.Resources.DownArrow2;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDown.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDown.Location = new System.Drawing.Point(28, 57);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(24, 28);
            this.btnDown.TabIndex = 13;
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnArrows_Click);
            // 
            // btnPlace
            // 
            this.btnPlace.BackColor = System.Drawing.Color.Transparent;
            this.btnPlace.BackgroundImage = global::BoardGame.Properties.Resources.PlaceButton;
            this.btnPlace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlace.Location = new System.Drawing.Point(28, 34);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(24, 24);
            this.btnPlace.TabIndex = 11;
            this.btnPlace.UseVisualStyleBackColor = false;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Transparent;
            this.btnRight.BackgroundImage = global::BoardGame.Properties.Resources.RightArrow;
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRight.Location = new System.Drawing.Point(51, 34);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(28, 24);
            this.btnRight.TabIndex = 12;
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnArrows_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnLeft.BackgroundImage = global::BoardGame.Properties.Resources.LeftArrow;
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeft.Location = new System.Drawing.Point(1, 34);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(28, 24);
            this.btnLeft.TabIndex = 8;
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnArrows_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Transparent;
            this.btnUp.BackgroundImage = global::BoardGame.Properties.Resources.UpArrow;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUp.Location = new System.Drawing.Point(28, 7);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(24, 28);
            this.btnUp.TabIndex = 11;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnArrows_Click);
            // 
            // pbBackground
            // 
            this.pbBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBackground.BackColor = System.Drawing.Color.Transparent;
            this.pbBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbBackground.Location = new System.Drawing.Point(4, 98);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(447, 404);
            this.pbBackground.TabIndex = 8;
            this.pbBackground.TabStop = false;
            this.pbBackground.Click += new System.EventHandler(this.pbBackground_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 507);
            this.Controls.Add(this.gbToolbox);
            this.Controls.Add(this.gbInitialInfo);
            this.Controls.Add(this.pbBackground);
            this.MinimumSize = new System.Drawing.Size(473, 330);
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.gbInitialInfo.ResumeLayout(false);
            this.gbInitialInfo.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.connectionsTab.ResumeLayout(false);
            this.SaveLoadTab.ResumeLayout(false);
            this.gbToolbox.ResumeLayout(false);
            this.gbArrows.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblHbg;
        private System.Windows.Forms.Label lblWbg;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Button btnImageBG;
        private System.Windows.Forms.Button btnImagePawn;
        private System.Windows.Forms.Button btnColorPawn;
        private System.Windows.Forms.TextBox tbUnitW;
        private System.Windows.Forms.TextBox tbUnitH;
        private System.Windows.Forms.Label lblWp;
        private System.Windows.Forms.Label lblHp;
        private System.Windows.Forms.Button btnImageTile;
        private System.Windows.Forms.Button btnColorTile;
        private System.Windows.Forms.Label lblWt;
        private System.Windows.Forms.Label lblHt;
        private System.Windows.Forms.CheckBox cbAllTiles;
        private System.Windows.Forms.GroupBox gbInitialInfo;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbStartX;
        private System.Windows.Forms.TextBox tbStartY;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbTileWidth;
        private System.Windows.Forms.TextBox tbTileHeight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnColorBG;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.Button btnDeleteTile;
        private System.Windows.Forms.ComboBox cbShapes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox gbToolbox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox gbArrows;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.TextBox tbTileH;
        private System.Windows.Forms.TextBox tbTileW;
        private System.Windows.Forms.Button connection;
        private System.Windows.Forms.TabPage connectionsTab;
        private System.Windows.Forms.Button showConnections;
        private System.Windows.Forms.Button addUnit;
        private System.Windows.Forms.TabPage SaveLoadTab;
        private System.Windows.Forms.Button LoadFile;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.CheckBox cbAllUnits;
        private System.Windows.Forms.Button btnDeleteUnit;
    }
}
