using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;                     //DRAGOVER

namespace BoardGame
{
    public partial class Form1 : Form
    {
        





        Color backgroundTile = Color.Black;
        Color backgroundForm = Color.White;

        //dimentions of form1
        int hForm = 500;
        int wForm = 500;
        int zero;

        string imagePath;
        bool imageAdded;

        Form addImage = new Form();
        TextBox tbBrowse = new TextBox();
        Button btnImageOK = new Button();

        int ruler = 0;//for startup ruler marks
        List<Panel1> rulerList = new List<Panel1>();
        List<Label> rulerLabels = new List<Label>();


        public Form1()
        {
            InitializeComponent();
            //pbBackground.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rulerHori();//shows the startup ruler
        }

        private void Form1_Click(object sender, EventArgs e)
        {
        }

        private void pbBackground_Click(object sender, EventArgs e)
        {
            deleteList(allHighlight);//deletes all panels in list
            clearList(allClicked);
            clearList(allHighlight);
        }
        
         public void rulerHori()//got bored and made this to see where to start the tile
        {   //slightly ugly but it does what its supposed to
            if (ruler <= this.Width)
            {
                Panel1 p = new Panel1();
                p.Size = new Size(5, 5);
                p.Location = new Point(((pbBackground.Location.X) + ruler), pbBackground.Location.Y);
                p.BackColor = Color.Black;
                Label l = new Label();
                l.Text = ruler.ToString();
                l.Location = new Point(((pbBackground.Location.X + 3) + ruler), pbBackground.Location.Y + 2);
                l.BackColor = Color.Transparent;
                l.AutoSize = true;

                rulerLabels.Add(l);
                rulerList.Add(p);
                Controls.Add(p);
                Controls.Add(l);
                p.BringToFront();
                l.BringToFront();

                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newPanel = p.ClientRectangle;
                buttonPath.AddEllipse(newPanel);
                p.Region = new System.Drawing.Region(buttonPath);
                ruler += 50;
                rulerVert();
                rulerHori();
            }
        }
        public void rulerVert()
        {
                Panel1 p = new Panel1();
                p.Size = new Size(5, 5);
                p.Location = new Point(((pbBackground.Location.X)), pbBackground.Location.Y+ruler);
                p.BackColor = Color.Black;
                Label l = new Label();
                l.Text = ruler.ToString();
                l.Location = new Point(((pbBackground.Location.X + 3)), pbBackground.Location.Y + ruler);
                l.BackColor = Color.Transparent;
                l.AutoSize = true;

                rulerLabels.Add(l);
                rulerList.Add(p);
                Controls.Add(p);
                Controls.Add(l);
                p.BringToFront();
                l.BringToFront();

                System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
                System.Drawing.Rectangle newPanel = p.ClientRectangle;
                buttonPath.AddEllipse(newPanel);
                p.Region = new System.Drawing.Region(buttonPath);
        }

        
        

        //determines the sizes of the form and tile and sets initial tile start postition
        private void btnCreate_Click(object sender, EventArgs e)
        {
            gbInitialInfo.Visible = false;
            gbToolbox.Enabled = true; //hides toolbar

            int parsedH = 0;
            int parsedW = 0;
           /*parsedH = parseInput(tbFormHeight);//dont need this anymore, just starting screen full open
            parsedW = parseInput(tbFormWidth);

            if (parsedH == -1 || parsedH != hForm)//if the new input is NOT equal to the tile size
            {
                hForm = 507;
            }
            if (parsedW == -1 || parsedW != wForm)
            {
                wForm = 457;
            }
            this.Size = new Size(wForm, hForm);
            */
            parsedH = parseInput(tbTileHeight);
            parsedW = parseInput(tbTileWidth);

            //checks tile size text boxes, if empty or has !digits it sets to default 30x30
            if (parsedH == -1)
            {
                hTile = 50;
            }
            else
            {
                hTile = parsedH;
            }
            if (parsedW == -1)
            {
                wTile = 50;
            }
            else
            {
                wTile = parsedW;
            }


            parsedH = parseInput(tbStartY);
            parsedW = parseInput(tbStartX);

            //checks tile start position text boxes, if empty or has !digits it sets to default 300x400
            if (parsedH == -1)
            {
                position.Y = 0;
            }
            else
            {
                position.Y = parsedH;               
            }

            if (parsedW == -1)
            {
                position.X = 0;
            }
            else
            {
                position.X = parsedW;
            }
            fixPosition();//X and Y are relative to the whole form, this method moves position to backgroup position

            deleteList(rulerList);//deletes ruler after create board has been clicked
            foreach (Label l in rulerLabels)
            {
                Controls.Remove(l);
                l.Dispose();
            }

        }

        private void fixPosition()//moves point below toolbar
        {//X and Y are relative to the whole form, this method moves position to background XY
            position.X += 7;
            position.Y += 101;
        }

        public void clearList(List<Panel1> list)//receives list to be cleared
        {
            list.Clear();
        }

        private void deleteList(List<Panel1> list)
        {
            foreach (Panel1 p in list)//remove all panels that are clicked
            {
                Controls.Remove(p);
                p.Dispose();
            }
        }

        private void btnArrows_Click(object sender, EventArgs e)
        {
            Button btnDirection = (Button)sender;   //reads which arrow button was clicked

            if (placeClicked == false && arrowClicked == true) //if a second arrow has been click but has not been placed
            {
                //arrowX = 0;             //resets the arrow button
                //arrowY = 0;
                arrowClicked = false;
            }
            //checks if a tile has been placed. prevents moving multiple squares and creating an island tile
            if (arrowClicked == false)   //if an arrow has been clicked
            {
                if (btnDirection == btnUp)   //if the clicked button was up
                {
                    direction = 1200;             //move the starting point of the next tile up the distance of the tile
                }
                else if (btnDirection == btnDown) //if the clicked button was down
                {
                    direction = 6000;
                }
                else if (btnDirection == btnLeft) //if the clicked button was left
                {
                    direction = 9000;
                }
                else if (btnDirection == btnRight) //if the clicked button was right
                {
                    direction = 3000;
                }

            }

            arrowClicked = true;
            placeClicked = false;
        }

        private void btnColorDialog_Click(object sender, EventArgs e) //opens a color dialog to change color of tile
        {
            Button btn = (Button)sender; //sets button clicked to temp 'btn' / read which button was clicked
            ColorDialog colorDialogBox = new ColorDialog(); //pop up color dialog

            if (colorDialogBox.ShowDialog() == DialogResult.OK) //after a color has been chosen and OK clicked
            {
                if (btn == btnColorBG)  //if the background color button has been clicked
                {
                    this.BackColor = colorDialogBox.Color;   //changes color of background
                    pbBackground.BackgroundImage = null;
                }
                else if (btn == btnColorTile)   //if the tile color button has been clicked
                {
                     if (allClicked.Count == 0 && cbAllTiles.Checked == false)//if nothing(all tiles checkbox or an tiles) is clicked
                    {
                        backgroundTile = colorDialogBox.Color;
                    }
                    else if (cbAllTiles.Checked)//if the all tiles has been checked
                    {
                        foreach (Panel1 p in tilesCreated)//change color for all tiles
                        {
                            p.BackColor = colorDialogBox.Color; //get tile from panels selected
                            p.BackgroundImage = null;
                            imageAdded = false;
                            backgroundTile = colorDialogBox.Color; //sets all future tiles to this color
                            p.ForeColor = p.BackColor;
                        }
                    }
                    else//if all tiles has NOT been checked / just the tiles highlighted
                    {
                        foreach (Panel1 p in allClicked)
                        {
                            p.BackColor = colorDialogBox.Color; //get tile from panels selected
                            p.ForeColor = p.BackColor;
                            p.BackgroundImage = null;
                            imageAdded = false;
                        }
                    }
                }
                else if (btn == btnColorPawn)
                {
                    foreach (Panel1 p in allClicked)
                    {
                        foreach (Unit u in p.unitsOnThisPanel)
                        {
                            u.setColor(colorDialogBox.Color);
                            u.BackgroundImage = null;
                            imageAdded = false;
                        }
                    }

                }
            }
            
        }

        private void btnImage_Click(object sender, EventArgs e) //checks if the browse button has been clicked for image
        {
            imagePath = GetImage();
            if (imagePath == null)
            {
                return;
            }

            Button btn = (Button)sender; //sets button clicked to temp 'btn'

            if (btn == btnImageBG)  //if the background color button has been clicked
            {
                pbBackground.BackgroundImage = Image.FromFile(imagePath);
                pbBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            

            else if (btn == btnImageTile)   //if the tile image button has been clicked
            {
               /*if (allClicked.Count == 0 && cbAllTiles.Checked == false)//if nothing(all tiles checkbox or an tiles) is clicked
               {
                        backgroundTile = colorDialogBox.Color;
               }*///add this for creating new tile with image already on insteda of creating tile then adding image
                if (cbAllTiles.Checked)//if the all tiles has been checked
                {
                    foreach (Panel1 p in tilesCreated)//change image for all tiles
                    {
                        p.BackgroundImage = Image.FromFile(imagePath);
                        p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    }
                }
                else//if all tiles has NOT been checked / just the tiles highlighted
                {
                    foreach (Panel1 p in allClicked)
                    {
                        imageAdded = true;
                        p.BackgroundImage = Image.FromFile(imagePath); //get tile from panel selected
                        p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    }
                }
            }
            else if (btn == btnImagePawn)
            {
                foreach (Panel1 p in allClicked)
                {
                    foreach(Unit u in p.unitsOnThisPanel)
                    {
                        imageAdded = true;
                        u.BackgroundImage = Image.FromFile(imagePath); //get tile from panel selected
                        u.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    }
                    
                }
            }


        }

        public string GetImage()
        {
            OpenFileDialog fileDialog = new OpenFileDialog(); //creates fileDialog

            fileDialog.InitialDirectory = @"C:\Pictures"; //& RestoreDir
            fileDialog.Title = "Browse";    //btn text?

            fileDialog.CheckFileExists = true;
            fileDialog.CheckPathExists = true;

            fileDialog.DefaultExt = "png";
            fileDialog.Filter = "png files (*.png)|*.png|All files (*.*)|*.*";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                return fileDialog.FileName;
            }
            else if (fileDialog.ShowDialog() != DialogResult.OK)
            {
                return null;
            }
            else
            {
                return null;
            }
        }

        private List<Panel1> whichList()
        {
            List<Panel1> list;//placeholder name for list that will be converted to shape 

            if (cbAllTiles.Checked)//reads which list needs to be converted to shape
            {
                list = tilesCreated;
            }
            else
            {
                list = allClicked;
            }
            return list;
        }

        private void cbShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Panel1> list;//placeholder name for list that will be converted to shape                           
            int selection = cbShapes.SelectedIndex;//reads which shape was selected
            list = whichList();//figures out if i need allClicked or tilesCreated list

            if (selection == 0) //if selection is 'Circle'
            {
                foreach (Panel1 p in list)
                {
                    drawCircle(p);
                    p.Tag = "0";
                }
            }
            else if (selection == 1)//if selection is 'Triangle'
            {
                foreach (Panel1 p in list)
                {
                    drawTriangle(p);
                    p.Tag = "1";
                }
            }
            else
            {
                return;
            }
            cbShapes.SelectedIndex = -1;//resets the dropdown to empty instead of 'circle' or 'triangle'
        }
        #region shapes
        public void drawCircle(Panel p)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();

            //set a new rectangle to the same size as the button's ClientRectange property
            System.Drawing.Rectangle newPanel = p.ClientRectangle;

            //create a circle withing the new rectangle
            buttonPath.AddEllipse(newPanel);
            p.Region = new System.Drawing.Region(buttonPath);
        }

        public void drawTriangle(Panel p)
        {
            // Triangle button
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();

            //set a new rectangle to the same size as the button's ClientRectange property
            System.Drawing.Rectangle newPanel = p.ClientRectangle;

            Point[] points = {
                    new Point(p.Width / 2, 0),
                    new Point(0, p.Height),
                    new Point(p.Width, p.Height) };

            buttonPath.AddPolygon(points);
            p.Region = new System.Drawing.Region(buttonPath);
        }
        #endregion shapes

        private void formSize_Enter(object sender, KeyPressEventArgs e)//change size of form on toolbar
        {
            if (e.KeyChar == (char)Keys.Enter)
            {  
                int parsedH = 0;
                int parsedW = 0;
                parsedH = parseInput(tbHeight);
                parsedW = parseInput(tbWidth);

                if (parsedH != -1)//if the new input is NOT equal to the tile size
                {
                    hForm = parsedH;
                }

                if (parsedW != -1)//if the new input is NOT equal to the tile size
                {
                    wForm = parsedW;
                }

                this.Size = new Size(wForm, hForm);
                
                tbWidth.Clear();
                tbHeight.Clear();
            }
        }

        private int parseInput(TextBox input)//checks textboxes to make sure input is digits
        {
            int parsedInt = 0;

            if ((string.IsNullOrEmpty(input.Text) != true) && (Int32.TryParse(input.Text, out zero) != false))//hform matter?
            {
                parsedInt = int.Parse(input.Text);
                return parsedInt;
            }
            return -1;
        }

        private void tileSize_Enter(object sender, KeyPressEventArgs e)//changes size of tiles via the toolbar
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                List<Panel1> list;//placeholder name for list that will be   
                int parsedH = 0;
                int parsedW = 0;
                parsedH = parseInput(tbTileH);
                parsedW = parseInput(tbTileW);
                         
                list = whichList();

                if (parsedH != -1)//if the new input is NOT equal to the tile size
                {
                
                    if (list.Count != 0)//if nothing(all tiles checkbox or an tiles) is clicked
                    {
                        foreach (Panel1 p in list)
                        {

                            p.Size = new Size(p.Width, parsedH);//sets new size to new input with tile width - 
                                                                //wTile(standard tile size) would change the re-fix the width of the tile to original
                            intersectsWith(p);

                            if (p.Tag != null && p.Tag.ToString() == "0")//if it is circle
                            {
                                drawCircle(p);
                            }
                            if (p.Tag != null && p.Tag.ToString() == "1")
                            {
                                drawTriangle(p);
                            }
                        }
                    }
                    else
                    {
                        hTile = parsedH;//set default height to input
                    }

                }

                if (parsedW != -1)//if the new input is NOT equal to the tile size
                {
                    if (list.Count != 0)
                    {
                        foreach (Panel1 p in list)
                        {
                            p.Size = new Size(parsedW, p.Height);//sets new size to new input with tile width - 
                                                                 //wTile(standard tile size) would change the re-fix the width of the tile to original
                            intersectsWith(p);

                            if (p.Tag != null && p.Tag.ToString() == "0")//if it is circle
                            {
                                drawCircle(p);
                            }
                            if (p.Tag != null && p.Tag.ToString() == "1")
                            {
                                drawTriangle(p);
                            }
                            
                        }
                    }
                    else
                    {
                        wTile = parsedW;
                    }
                }
                tbTileH.Clear();
                tbTileW.Clear();
            }
        }
        
            private void unitSize_Enter(object sender, KeyPressEventArgs e)//change size of unita on toolbar
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int parsedH = 0;
                int parsedW = 0;
                parsedH = parseInput(tbUnitH);
                parsedW = parseInput(tbUnitW);

                if (cbAllUnits.Checked)
                {
                    foreach (Panel1 p in tilesCreated)
                    {
                        foreach (Unit u in p.unitsOnThisPanel)
                        {
                            if (parsedH != -1)//if the new input is NOT equal to the tile size
                            {
                                u.Height = parsedH;
                            }

                            if (parsedW != -1)//if the new input is NOT equal to the tile size
                            {
                                u.Width = parsedW;
                            }

                        }
                    }
                }
                else
                {
                    foreach (Panel1 p in allClicked)
                    {
                        foreach (Unit u in p.unitsOnThisPanel)
                        {
                            if (parsedH != -1)//if the new input is NOT equal to the tile size
                            {
                                u.Height = parsedH;
                            }

                            if (parsedW != -1)//if the new input is NOT equal to the tile size
                            {
                                u.Width = parsedW;
                            }
                        }
                    }
                }
                tbUnitH.Clear();
                tbUnitW.Clear();
            }
        }


        #region connectionTab 
        private void connection_Click(object sender, EventArgs e)
        {
            if (allClicked.Any())//checks if any tiles have been selected
            {
                if (allClicked.Count() > 1)//checks if multiple tiles selected
                {

                    Panel1 firstPanel = allClicked.First();
                    String a = "";//for use in verifying completion
                    foreach (Panel1 nextpanel in allClicked)
                    {
                        if (nextpanel == firstPanel)
                        {
                            continue;
                        }
                        else
                        {
                            if (firstPanel.connectedList.Any() == false)
                            {
                                firstPanel.connectedList.AddFirst(nextpanel);
                            }
                            else
                            {
                                firstPanel.connectedList.AddLast(nextpanel);
                            }
                            
                            a += nextpanel.Name + ", ";
                        }
                    }
                    //message to verify completion
                    MessageBox.Show("You have added the panels: " + a + "\n to the list of connected panels in " + firstPanel.Name);
                }
                else
                {
                    //error message
                    MessageBox.Show("you must ctrl click multiple squares to add connections. The blue highlighted tiles will be added to the list of connected tiles in the red tile ");
                }

            }
            else
            {
                //error message
                MessageBox.Show("You must ctrl click multiple tiles to be added.");
            }
        }

        private void showConnections_Click(object sender, EventArgs e)
        {
            if (allClicked.Any())
            {
                if (allClicked.Count == 1)
                {
                    foreach(Panel1 hilightedPanel in allClicked.First().connectedList)
                    {
                        Color green = Color.Green;
                        Panel1 greenHighlight = highlight(hilightedPanel, green);//highlights all of the tiles that are connected green
                        greenHighlight.BringToFront();//*******may cause issues with showing the unit******
                        hilightedPanel.BringToFront();//*******may cause issues with showing the unit******
                        allHighlight.Add(greenHighlight);//adds the highlight to the list so that the highlight can be deleted when you click away
                    }
                }
                else
                {
                    foreach (Panel1 hilightedPanel in allClicked.First().connectedList)
                    {
                        Color green = Color.Green;
                        Panel1 greenHighlight = highlight(hilightedPanel, green);//highlights all of the tiles that are connected green
                        greenHighlight.BringToFront();//*******may cause issues with showing the unit******
                        hilightedPanel.BringToFront();//*******may cause issues with showing the unit******
                        allHighlight.Add(greenHighlight);//adds the highlight to the list so that the highlight can be deleted when you click away
                    }
                    MessageBox.Show("this button only shows connections for the first selected tile, highlighted in green");
                }
            }
            else
            {
                //error message
                MessageBox.Show("Select a tile to show its connections highlighted in green.");
            }
        }


        #endregion connectionTab

        public void CHECKERS_Click(object sender, EventArgs e)
        {
            checker_rules_on = true;
           

            for (int i = 0; i < 12; i++)
            {
                unit_List_red.Add(masterUnitList[i]);
            }

            for (int i = 12; i < 23; i++)
            {
                unit_List_black.Add(masterUnitList[i]);
            }

            MessageBox.Show("Checker's Rule's successfully integrated." +
                "\n You may now play checkers");

        }
    }
}
