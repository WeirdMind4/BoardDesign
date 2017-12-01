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

namespace BoardGame
{
    public partial class Form1 : Form
    {
        //seperators
        char attributeSeperator = ',';
        char tileSeperator = ';';
        char tileAndUnitSeperator = ':';

        //sets the place to put the save file to Desktop//need a dialogue box to change this
        string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        private void Save_Click(object sender, EventArgs e)
        {

            string outputString = "";

            string stringOfAllTiles = "";
            string stringOfAllUnits = "";

            //gather and format the data
            #region gatherAndFormatData
            foreach (Panel1 eachpanel in tilesCreated)
            {
                //must get each attribute, add it to the string
                string tileName = eachpanel.Name;
                string tileXLocation = eachpanel.Location.X.ToString();
                string tileYLocation = eachpanel.Location.Y.ToString();
                string tileBackgroundImage = eachpanel.BackColor.ToArgb().ToString();//make sure I know what this actually is
                string tileWidth = eachpanel.Width.ToString();
                string tileHeight = eachpanel.Height.ToString();

                //add each string to a single string seperated by something

                string tileString = tileName + attributeSeperator + tileXLocation
                    + attributeSeperator + tileYLocation + attributeSeperator + tileBackgroundImage
                    + attributeSeperator + tileWidth + attributeSeperator + tileHeight;

                //add the tileString to the total string of all the tiles

                stringOfAllTiles += (tileString + tileSeperator);
            }

            if (stringOfAllTiles.Length > 1)
            {
                stringOfAllTiles = stringOfAllTiles.Remove(stringOfAllTiles.Length - 1);
            }


            //MessageBox.Show(stringOfAllTiles);//used in debugging
            outputString = (stringOfAllTiles + tileAndUnitSeperator);

            foreach (Unit eachUnit in masterUnitList)
            {
                //string unitLocation = eachUnit.getLocation();
                string unitName = eachUnit.getName();
                string tileUnitIsOn = eachUnit.getLocation().Name;//gives the name of the tile the unit is on
                string unitColor = eachUnit.getColor().Name;
                //going with the defaults of the unit


                string unitString = unitName + attributeSeperator + tileUnitIsOn + attributeSeperator + unitColor;

                stringOfAllUnits += unitString + tileSeperator;
            }

            if (stringOfAllUnits.Length > 1)
            {
                stringOfAllUnits = stringOfAllUnits.Remove(stringOfAllUnits.Length - 1);
            }


            //MessageBox.Show(stringOfAllUnits);//for use in debugging

            outputString += stringOfAllUnits;//adds the units to the string for output//Maybe just have this separated into the differing part of the array?
                                             //MessageBox.Show(outputString);//for use in debugging
            #endregion gatherAndFormatData

            //need to alter this string so that it contains 
            //all of the data that is needed to reload the program

            //string[] lines = { outputString };//this is what will be sent to the file

            //code to save the file

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    StreamWriter stringStream = new StreamWriter(myStream);
                    stringStream.Write(outputString);
                    stringStream.Flush();
                    stringStream.Close();

                    myStream.Close();
                }
            }

            //saves the data to the text file
            // System.IO.File.WriteAllLines(mydocpath + @"\BoardGame.txt", lines);//need to have a user input to specify the name of the file

        }

        private void LoadProgram_Click(object sender, EventArgs e)
        {

            /*
             
            the Load_Click method must take the information from the saved text file,
            then break it into inputs to be called by the Create_Tile method and addUnit method
             
            */

            //read the original text file and put into the string array
            #region loadText

            string totalString = "";
            string allTileString = "";
            string allUnitString = "";

            /*
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(mydocpath + @"\BoardGame.txt");



                //Read the first line of text
                //allTileString = sr.ReadLine();
                //allUnitString = sr.ReadLine();
                totalString = sr.ReadLine();

                //close the file
                sr.Close();

                MessageBox.Show(totalString);
                char tileVSUnitDelimiter = tileAndUnitSeperator;//splits the string along this seperator which is removed
                string[] arrayOfUnitsAndTiles = totalString.Split(tileVSUnitDelimiter);//cut the loaded string into the tile and unit portions
                allTileString = arrayOfUnitsAndTiles[0];
                allUnitString = arrayOfUnitsAndTiles[1];
            }
            catch (Exception a)
            {
                MessageBox.Show("Exception: " + a.Message);
                return;//ends the load method
            }

            */

            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                            StreamReader myStreamReader = new StreamReader(myStream);
                            totalString = myStreamReader.ReadLine();
                            myStreamReader.Close();


                            //MessageBox.Show(totalString);
                            char tileVSUnitDelimiter = tileAndUnitSeperator;//splits the string along this seperator which is removed
                            string[] arrayOfUnitsAndTiles = totalString.Split(tileVSUnitDelimiter);//cut the loaded string into the tile and unit portions
                            allTileString = arrayOfUnitsAndTiles[0];
                            allUnitString = arrayOfUnitsAndTiles[1];
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Canceled Load");
                return;
            }



            #endregion loadText

            //could be turned into a method for restarting
            #region clearPreexistingStuff  
            //need to clear the preexisting stuff on the board before loading
            //clear units
            if (masterUnitList.Any())
            {
                //List<Unit> tempUnitList = masterUnitList;

                foreach (Unit preexistingUnits in masterUnitList)
                {
                    //call method for removing units
                    deleteUnitMethod(preexistingUnits);
                }
                masterUnitList.Clear();

            }

            unitNum = 0;//reset count of units

            //clear tiles
            List<Panel1> allPanels = tilesCreated;//temp list of all of the tiles

            deleteList(allPanels); //deletes all the tiles
            tilesCreated.Clear();//clears all references from the master list of tiles
            numTiles = 0;//reset count of tiles

            #endregion clearPreexistingStuff

            #region loadTiles

            //String value = "This is a short string.";
            //MessageBox.Show(allTileString);//used to verify what is going into the loadTiles area

            if (allTileString != "")
            {

                char delimiter1 = tileSeperator;//splits the string along this seperator which is removed
                string[] arrayOfTiles = allTileString.Split(delimiter1);

                foreach (string tileString in arrayOfTiles)
                {
                    //split the string into the attributes
                    char delimiter3 = attributeSeperator;
                    string[] arrayOfTileAttributes = tileString.Split(delimiter3);

                    /*

                    //attributes
                   0= string tileName = eachpanel.Name;
                   1= string tileXLocation = eachpanel.Location.X.ToString();
                   2= string tileYLocation = eachpanel.Location.Y.ToString();
                   3= string tileBackgroundImage = eachpanel.BackColor.Name;//make sure I know what this actually is
                   4= string tileWidth = eachpanel.Width.ToString();
                   5= string tileHeight = eachpanel.Height.ToString();

                     */

                    //make the tile based on the attributes
                    Panel1 newTile = new Panel1();

                    //setting the name
                    newTile.Name = arrayOfTileAttributes[0];
                    numTiles++;

                    //method for setting the Location
                    int X = 0;
                    int Y = 0;
                    int.TryParse(arrayOfTileAttributes[1], out X);
                    int.TryParse(arrayOfTileAttributes[2], out Y);
                    newTile.Location = new Point(X, Y);



                    //method for setting the dimensions
                    int height = 0;
                    int width = 0;
                    int.TryParse(arrayOfTileAttributes[5], out height);
                    int.TryParse(arrayOfTileAttributes[4], out width);
                    newTile.Size = new Size(width, height);

                    //standard commands to add to the form
                    newTile.MouseClick += Panel_Click;             //creates event for tile / addes mouseClick event
                    intersectsWith(newTile); //checks if the new tile intersects with all other created tiles
                    tilesCreated.Add(newTile);//adds panel to list of al tiles created

                    Controls.Add(newTile); //adds panel to the form

                    //method for setting the color
                    int argbValue = 0;
                    Color tileColor = new Color();
                    //tileColor = Color.FromName(arrayOfTileAttributes[3]);
                    int.TryParse(arrayOfTileAttributes[3], out argbValue);
                    tileColor = Color.FromArgb(argbValue);
                    // MessageBox.Show(tileColor.ToString());
                    newTile.BackColor = tileColor;


                    newTile.BringToFront(); //bring before the picturebox background   SAME AS below???
                    pbBackground.SendToBack(); //prevents the BG panel from covering the new highlight panel

                }

            }
            else
            {
                MessageBox.Show("incorrect format for loading tiles");
            }
            #endregion loadTiles

            #region loadUnits

            if (allUnitString != "")
            {
                char delimeter2 = tileSeperator;
                string[] arrayOfUnits = allUnitString.Split(delimeter2);

                /*
               0 = string unitName= eachUnit.getName();
               1 = string tileUnitIsOn = eachUnit.getLocation().Name;//gives the name of the tile the unit is on
               2 = string unitColor = eachUnit.getColor().Name;
                 */


                foreach (string unitString in arrayOfUnits)
                {
                    //split the string into the attributes
                    char delimiter3 = attributeSeperator;
                    string[] arrayOfUnitAttributes = unitString.Split(delimiter3);
                    //make the unit based on the attributes
                    foreach (Panel1 panel in tilesCreated)
                    {
                        if (panel.Name == arrayOfUnitAttributes[1])
                        {
                            Unit thisUnit = createUnit(panel);
                            thisUnit.setName(arrayOfUnitAttributes[0]);

                            Color unitColor = Color.FromName(arrayOfUnitAttributes[2]);
                            thisUnit.setColor(unitColor);
                        }

                    }

                }
            }
            else
            {
                MessageBox.Show("no units loaded");
            }



            #endregion loadUnits

        }


    }
}
