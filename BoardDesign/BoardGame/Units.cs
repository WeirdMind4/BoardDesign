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
        int unitNum = 0;
        //colin's code
        public class Panel1 : Panel //this class allows each panel to have a list of the connected panels
        {
            public LinkedList<Panel1> connectedList = new LinkedList<Panel1>();//list of connected panels
            public LinkedList<Unit> unitsOnThisPanel = new LinkedList<Unit>();//list of units on this panel

        }

        private void addUnit_Click(object sender, EventArgs e) //control for adding the unit
        {
            if (allClicked.Any() == false)
            {
                MessageBox.Show("you must highlight the tile you wish to add the unit on");
            }
            else
            {
                foreach (Panel1 selectedPanel in allClicked)
                {
                    Unit newUnit = new Unit();
                    newUnit.Location = new Point(0, 0);//sets it outside at first
                    newUnit.setName("unit " + unitNum);
                    //newUnit.setParameters(allClicked.First());
                    newUnit.setParameters(selectedPanel);
                    unitNum++;
                    //Controls.Add(newUnit.getUnit());
                    Controls.Add(newUnit);
                    //newUnit.getUnit().BringToFront();
                    newUnit.BringToFront();
                }
                
            }
        }

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

            public String getName()
            {
                return name;
            }
            public void setName(String a)
            {
                name = a;
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



        /* 
               public class Unit
               {
                   private Panel1 currentLocation;//square's current location
                   private unitPanel thisUnitPanel;
                   private String name = "default";

                   /*public Unit()//empty constructer
                   {

                   }*/
                   /*
                   public Unit(Panel1 startingLocation)//instantiate a Unit
                   {
                       //on creation, the starting location will be the one that is currently highlighted






                       //graphic representaion
                       thisUnitPanel = new unitPanel();

                       thisUnitPanel.BringToFront();
                       thisUnitPanel.BackColor = Color.LimeGreen;
                       thisUnitPanel.Size = new Size(startingLocation.Width - 20, startingLocation.Height - 20); //sets size of tile             
                                                     //tile.Location = new Point(x, y);            //sets location of tile
                       thisUnitPanel.Location = new Point(startingLocation.Location.X, startingLocation.Location.Y);
                       this.adjustLocation();

                       //thisUnitPanel.associatedUnit = this;//sets the unitPanel to be associated with this Unit

                       //variable to hold locationID
                       this.currentLocation = startingLocation;



                   }
                   public Panel1 getLocation()
                   {
                       return this.currentLocation;
                   }
                   public unitPanel getUnit()
                   {
                       return this.thisUnitPanel;
                   }
                   public String getName()
                   {
                       return name;
                   }
                   public void setName(String a)
                   {
                       name = a;
                   }


                   public void changeLocation(Panel1 newLocation)
                   {
                       this.currentLocation = newLocation; this.changeLocation(newLocation);//
                       this.thisUnitPanel.Location = newLocation.Location;
                       this.adjustLocation();
                   }

                   public void adjustLocation()
                   {
                       this.thisUnitPanel.Location = new Point(thisUnitPanel.Location.X + 10, thisUnitPanel.Location.Y + 10);
                   }


               }


           */



    }
}

