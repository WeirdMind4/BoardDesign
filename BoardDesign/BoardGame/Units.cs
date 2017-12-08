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
        //use the integer for naming purposes
        int unitNum = 0;

        //use this as a master list of all of the units
        List<Unit> masterUnitList = new List<Unit>();

        //colin's code
        public class Panel1 : Panel //this class allows each panel to have a list of the connected panels
        {
            public LinkedList<Panel1> connectedList = new LinkedList<Panel1>();//list of connected panels
            public LinkedList<Unit> unitsOnThisPanel = new LinkedList<Unit>();//list of units on this panel

        }
        #region creatingUnits
        private void addUnit_Click(object sender, EventArgs e) //control for adding the unit
        {
            if (allClicked.Any() == false)
            {
                MessageBox.Show("you must highlight the tile you wish to add the unit on");
            }
            else
            {
                foreach (Panel1 panel in allClicked)
                {
                    createUnit(panel);
                }


                //createUnit(allClicked);
            }
        }

        //method puts a unit on the specified panel
        public Unit createUnit(Panel1 startingLocation)
        {

            Unit newUnit = new Unit();
            newUnit.Location = new Point(0, 0);//sets it outside at first
            newUnit.setName("unit " + unitNum);
            //newUnit.setParameters(allClicked.First());
            newUnit.setParameters(startingLocation);
            unitNum++;
            //Controls.Add(newUnit.getUnit());
            Controls.Add(newUnit);
            //newUnit.getUnit().BringToFront();
            newUnit.BringToFront();
            masterUnitList.Add(newUnit);
            return newUnit;
        }

        #endregion creatingUnits


        #region deletingUnits

        private void btnDeleteUnit_Click(object sender, EventArgs e)
        {

            foreach (Panel1 p in allClicked)
            {
                //if there are any units on the panel
                if (p.unitsOnThisPanel.Any())
                {
                    //delete the first unit
                    string a = p.unitsOnThisPanel.First().Name;
                    deleteUnitMethod(p.unitsOnThisPanel.First());
                    //masterUnitList.Remove(p.unitsOnThisPanel.First());//remove the reference from the master list
                    p.unitsOnThisPanel.RemoveFirst();
                    MessageBox.Show("Deleted " + a + " from " + p.Name);
                }

            }

        }

        private void deleteUnitMethod(Unit u)
        {

            masterUnitList.Remove(u);//remove the reference from the master list
            Controls.Remove(u);//remove the unit from the screen
            u.Dispose();//release the data

            if(checker_rules_on == true)
            {               
                if (blackDefeated == 12)
                {
                    MessageBox.Show("player 1 victory");
                    checker_rules_on = false;
                    blackDefeated = 0;
                    redDefeated = 0;
                }
                else if (redDefeated == 12)
                {
                    MessageBox.Show("player 2 victory");
                    checker_rules_on = false;
                    blackDefeated = 0;
                    redDefeated = 0;
                }
            }


        }

        #endregion deletingUnits

        //info: when you try to put a panel in the same place as another panel the IDE will add that panel to the other panel . 
        public class Unit : Panel //I skipped the abstraction of the Unit and just made it a direct child of the Panel class
        {

            private Panel1 currentLocation;//square's current location
                                           // private unitPanel thisUnitPanel;
            private String name = "default";

            public void setParameters(Panel1 startingLocation)//instantiate a Unit
            {

                this.BringToFront();

                this.BackColor = Color.LimeGreen;

                this.Size = new Size(startingLocation.Width - 20, startingLocation.Height - 20);

                this.Location = new Point(startingLocation.Location.X, startingLocation.Location.Y);

                this.adjustLocation();

                this.currentLocation = startingLocation;

                if (currentLocation.unitsOnThisPanel.Any())
                {
                    currentLocation.unitsOnThisPanel.AddLast(this);
                }
                else
                {
                    currentLocation.unitsOnThisPanel.AddFirst(this);
                }
                MessageBox.Show("added " + currentLocation.unitsOnThisPanel.First().name + " to " + currentLocation.Name);


            }
            public Panel1 getLocation()
            {
                return this.currentLocation;
            }

            public string getName()
            {
                return name;
            }
            public void setName(string a)
            {
                name = a;
            }
            public Color getColor()
            {
                return this.BackColor;
            }


            public void setColor(Color newColor)
            {
                this.BackColor = newColor;
            }
            //happens after you have left clicked the panel that contained the unit before and then right
            //clicked the new location
            public void changeLocation(Panel1 newLocation)
            {
                currentLocation.unitsOnThisPanel.Remove(this);//removes the unit from the reference of the old panel
                this.currentLocation = newLocation; //sets the current location to the new location
                //adds a reference for this unit to the new location
                if (newLocation.unitsOnThisPanel.Any())
                {
                    newLocation.unitsOnThisPanel.AddLast(this);
                }
                else
                {
                    newLocation.unitsOnThisPanel.AddFirst(this);
                }
                this.Location = newLocation.Location;//sets the visable Unit to the new location
                this.adjustLocation();
            }

            public void adjustLocation()
            {
                //this.thisUnitPanel.Location = new Point(thisUnitPanel.Location.X + 10, thisUnitPanel.Location.Y + 10);
                this.Location = new Point(this.Location.X + 10, this.Location.Y + 10);
            }


        }

    }
}

