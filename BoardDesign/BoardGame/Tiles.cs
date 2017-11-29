using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGame
{
    public partial class Form1 : Form
    {

        //height and width of tiles
        int hTile = 30;
        int wTile = 30;

        //number of tiles
        List<Panel1> tilesCreated = new List<Panel1>();
        int numTiles = 0;

        //starting position of first tile
        Point position = new Point(0, 0);
        Point startPoint = new Point(0, 0);
        int direction = 0;  //used to verify that the direction has been set

        //bool value to determine if an arrow has been already clicked
        //prevents island tiles and extra clicking
        bool arrowClicked = false;
        bool placeClicked = false;
        List<Panel1> allClicked = new List<Panel1>();
        List<Panel1> allHighlight = new List<Panel1>();
        //List<Unit> allSelectedUnits = new List<Unit>();
        Unit[] allSelectedUnits = new Unit[2];//used in the Panel_Click method
        

        private void btnPlace_Click(object sender, EventArgs e)
        {
            if (tilesCreated.Count == 0)//creates the start tile no matter where
            {   //not a good thing if tile placement is out of bounds but... I did it anyway
                CreateTile();
                return;
            }

        
            //prevents creating overlapping tiles at start
            if (tilesCreated.Count == 1 && arrowClicked == false)
            {
                return;
            }

            //checks if next tile will be out of the form, if yes then cancel creating new tile
            if (Boundary() == false)
            {
                return;
            }

            {
                CreateTile();

                arrowClicked = false;
                placeClicked = true;
                deleteList(allHighlight);
            }
        }

        //determines if the next tile will exit the form
        private bool Boundary()
        {
        Point temp = new Point(0,0);
        
            temp.X = position.X; //if hits a boundary/ can't move this restores point to head tile
            temp.Y = position.Y;

            VerifiedDirection();    //moves position of head tile

            if (position.X < 1 || position.X > (this.Width - (wTile+2) - 21)) //don't ask where I got the number from
            {//if outside the form
                position.X = temp.X;    //reset the position to current tile
                position.Y = temp.Y;    
                return false;
            }
            else if (position.Y < 100 || position.Y > (this.Height - (hTile+2) - 43))
            {
                position.X = temp.X;    //shouldnt need this but just in case -  full reset
                position.Y = temp.Y;    //reset the position to current tile
                return false;
            }
            else
            {
                return true;    //if next tile is in form return that it can move
            }
        }

        public void VerifiedDirection() //after the place button this sets the position of the head tile
        {
            if (direction == 1200)  //up
            {
                position.Y -= hTile + 1;
            }
            else if (direction == 6000) //down
            {
                position.Y += hTile + 1;
            }
            else if (direction == 3000) //right
            {
                position.X += wTile + 1;
            }
            else if (direction == 9000) //left
            {
                position.X -= wTile + 1;
            }
        }

        public void CreateTile()
        {
            Panel1 newTile = new Panel1(); //creates new tile panel

            numTiles++;

            if (imageAdded == true) //if image has been added to all tiles
            {                       //fill color does need it
                newTile.BackgroundImage = Image.FromFile(imagePath); //get tile from panel selected
                newTile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            }
            else
            {
                newTile.BackColor = backgroundTile;               //fills tile with color
                newTile.ForeColor = backgroundTile;
                imageAdded = false;
            }
             
            newTile.Size = new Size(wTile, hTile); //sets size of tile             
            newTile.Location = new Point(position.X, position.Y); //sets position of tile
            newTile.Name = "tile" + numTiles;              //changes name of tile to "tile#"
            newTile.MouseClick += Panel_Click;             //creates event for tile / addes mouseClick event

            intersectsWith(newTile); //checks if the new tile intersects with all other created tiles
            tilesCreated.Add(newTile);//adds panel to list of al tiles created

            Controls.Add(newTile); //adds panel to the form

            newTile.BringToFront(); //bring before the picturebox background   SAME AS below???
            pbBackground.SendToBack(); //prevents the BG panel from covering the new highlight panel
        }

        private void intersectsWith(Panel1 tile)
        {
            foreach (Panel1 p in tilesCreated) //checks if tile is overlapping another tile
            {
                if (tile.Bounds.IntersectsWith(p.Bounds) && (tile.Name != p.Name))//checks if intersects with all tiles
                {                                              //if newTile IS the tile
                    tile.BackColor = Color.Yellow; //tile changes color to yellow
                    return;//otherwise will keep foreaching and turn tile black again
                }
                else
                {
                    tile.BackColor = tile.ForeColor;
                }
            }
        }

        public Panel1 highlight(Panel1 clickedTile)//creates a new panel for highlight when clicking tiles
        {
            Panel1 highlight = new Panel1();
            if (allClicked.Any())
            {
                highlight.BackColor = Color.Blue; //set color of highlight tile
            }
            else
            {
                highlight.BackColor = Color.Red; //set color of highlight tile
            }
            highlight.Size = new Size(clickedTile.Width + 2, clickedTile.Height + 2);//sets size of highlight tile
            highlight.Location = new Point(clickedTile.Location.X - 1, clickedTile.Location.Y - 1);//set location of highlight tile
            Controls.Add(highlight);//add highlight tile to form

            return highlight;
        }
        public Panel1 highlight(Panel panelToHighlight, Color highlightColor)//more generic constructor of the highlight method
        {
            Panel1 highlight = new Panel1();
            highlight.BackColor = highlightColor;
            highlight.Size = new Size(panelToHighlight.Width + 2, panelToHighlight.Height + 2);//sets size of highlight tile
            highlight.Location = new Point(panelToHighlight.Location.X - 1, panelToHighlight.Location.Y - 1);//set location of highlight tile
            Controls.Add(highlight);//add highlight tile to form
            return highlight;
        }



        private void Panel_Click(object sender, EventArgs e)
        {
           
            Panel1 clickedTile = new Panel1();
            Panel1 highlightTile = new Panel1();
            clickedTile = (Panel1)sender;


            MouseEventArgs me = (MouseEventArgs)e;//used to differentiate left vs right click
            if (me.Button == MouseButtons.Right)//if right click
            {
                //MessageBox.Show("register a right click");
                if (allSelectedUnits[0] != null)//and unit was previously selected
                {
                    //move the unit
                    allSelectedUnits[0].changeLocation(clickedTile);
                    
                }else
                {
                    MessageBox.Show("Error! Selected Unit could not be added.");
                }

            }
            else//if left click
            {

                if (ModifierKeys.HasFlag(Keys.Control))//if ctrl is pressed
                {                //create and add new highlights to list
                    allClicked.Add(clickedTile);//add clicked to list of clicked tiles

                    highlightTile = highlight(clickedTile);
                    allHighlight.Add(highlightTile);//add highlight to list of highlighted tiles   
                                                    //return;
                }
                else//if only 1 tile has been clicked
                {       //reset clicked lists
                    deleteList(allHighlight);//deletes all panels in list
                    clearList(allHighlight);//resets the highlist list
                    clearList(allClicked);//resets all clicked list

                    highlightTile = highlight(clickedTile);//create a highlight tile
                                                           //allHighlight.Clear();
                    allHighlight.Insert(0, highlightTile);//replace/add highlight tile as #1 in list
                    allClicked.Insert(0, clickedTile);//replace clicked tile list #1 with new clicked 

                    position.X = clickedTile.Location.X; //allows branching from other tiles 
                    position.Y = clickedTile.Location.Y; //instead of one snake

                    if (clickedTile.unitsOnThisPanel.Any())//if newly selected tile has a unit
                    {
                        //MessageBox.Show("panel has a unit");//for use in debugging
                        
                        if (clickedTile.unitsOnThisPanel.Any())
                        {
                            //simultaneiously clears the array of the old selected unit and selects this one
                            allSelectedUnits[0] = clickedTile.unitsOnThisPanel.First();
                        }  
                    }

                }
                pbBackground.SendToBack();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        { 
            foreach(Panel1 p in allClicked)
            {
                tilesCreated.Remove(p);
            }

            deleteList(allClicked);

           /* foreach(Panel1 p in tilesCreated) //if tile is deleted that intersects with another tile this goes back and removes yellow
            {//is only important if top tile is smaller than bottom and bottom has been deleted
                intersectsWith(p);
            }*/

        }//deleted panels
    }
}
