using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGame
{

    public partial class Form1: Form
    {
        int redDefeated = 0;
        int blackDefeated = 0;
        List<Unit> unit_List_red = new List<Unit>();
        List<Unit> unit_List_black = new List<Unit>();
        bool checker_rules_on = false;


        Form1.Panel1 panel = new Form1.Panel1();
        Form1.Unit unit = new Form1.Unit();
       // List<Form1.Unit> masterUnitList = new List<Form1.Unit>();
        public LinkedList<Form1.Panel1> connectedList = new LinkedList<Form1.Panel1>();//list of connected panels
        public LinkedList<Form1.Unit> unitsOnThisPanel = new LinkedList<Form1.Unit>();




        public void checkersMovement( Panel1 clickedTile)
        {
            if (allClicked.Any())
            {

                int a = allClicked.First().Location.X; //the tile we are going from


                int b = clickedTile.Location.X - (1 + wTile);// right location
                int c = clickedTile.Location.X + (1 + wTile); // left location


                int d = allClicked.First().Location.Y; //the tile we are going from ;

                int goingUp = clickedTile.Location.Y + (1 + hTile);//for use in determining if can go up

                int goingDown = clickedTile.Location.Y - (1 + hTile);//for use in determining if can go down



                int jumpRight = clickedTile.Location.X - (2 + (2 * wTile));
                int jumpLeft = clickedTile.Location.X + (2 + (2 * wTile));

                int jumpDown = clickedTile.Location.Y - (2 + (2 * hTile));
                int jumpUp = clickedTile.Location.Y + (2 + (2 * hTile));


                if (clickedTile.BackColor.ToArgb() == -16777216)//checks if on black tiles
                {
                    if ((a == b) || (a == c))//checks if one space away
                    {
                        //each color can only go up or down
                        if (unit_List_red.Contains(allSelectedUnits[0]))//if one of the units from the top
                        {
                            if (d == goingDown)
                            {
                                allSelectedUnits[0].changeLocation(clickedTile);
                            }


                        }
                        else
                        {
                            if (d == goingUp)
                            {
                                allSelectedUnits[0].changeLocation(clickedTile);
                            }

                        }

                    }
                    else if ((a == jumpRight) && (d == jumpDown))
                    {
                        Panel1 myTile = new Panel1();//will be a reference to the tile we are jumping over
                        foreach (Panel1 tileJumpedOver in tilesCreated)
                        {
                            //if tileJumpedOver's x location is 
                            if ((tileJumpedOver.Location.X == b) && (tileJumpedOver.Location.Y == goingDown))
                            {
                                myTile = tileJumpedOver;
                                //MessageBox.Show(myTile.Name);
                            }
                        }

                        if (myTile.unitsOnThisPanel.Any())
                        {
                            //it is an acceptable jump

                            foreach (Unit myUnit in unit_List_black)
                            {
                                if (myUnit == myTile.unitsOnThisPanel.First())
                                {
                                    blackDefeated++;
                                }
                            }
                            foreach (Unit myUnit in unit_List_red)
                            {
                                if (myUnit == myTile.unitsOnThisPanel.First())
                                {
                                    redDefeated++;
                                }
                            }

                            //delete the unit from myTile

                            deleteUnitMethod(myTile.unitsOnThisPanel.First());
                            myTile.unitsOnThisPanel.RemoveFirst();

                            //move the unit
                            allSelectedUnits[0].changeLocation(clickedTile);


                        }
                        else
                        {
                            MessageBox.Show("illegal move");
                        }


                    }

                    else if ((a == jumpRight) && (d == jumpUp))
                    {
                        Panel1 myTile = new Panel1();//will be a reference to the tile we are jumping over
                        foreach (Panel1 tileJumpedOver in tilesCreated)
                        {

                            if ((tileJumpedOver.Location.X == b) && (tileJumpedOver.Location.Y == goingUp))
                            {
                                myTile = tileJumpedOver;
                                //MessageBox.Show(myTile.Name);
                            }
                        }

                        if (myTile.unitsOnThisPanel.Any())
                        {
                            foreach (Unit myUnit in unit_List_black)
                            {
                                if (myUnit == myTile.unitsOnThisPanel.First())
                                {
                                    blackDefeated++;
                                }
                            }
                            foreach (Unit myUnit in unit_List_red)
                            {
                                if (myUnit == myTile.unitsOnThisPanel.First())
                                {
                                    redDefeated++;
                                }
                            }


                            //it is an acceptable jump

                            //delete the unit from myTile
                            deleteUnitMethod(myTile.unitsOnThisPanel.First());
                            myTile.unitsOnThisPanel.RemoveFirst();

                            //move the unit
                            allSelectedUnits[0].changeLocation(clickedTile);


                        }
                        else
                        {
                            MessageBox.Show("illegal move");
                        }
                    }

                    else if ((a == jumpLeft) && (d == jumpDown))
                    {
                        Panel1 myTile = new Panel1();//will be a reference to the tile we are jumping over
                        foreach (Panel1 tileJumpedOver in tilesCreated)
                        {

                            if ((tileJumpedOver.Location.X == c) && (tileJumpedOver.Location.Y == goingDown))
                            {
                                myTile = tileJumpedOver;
                                //MessageBox.Show(myTile.Name);
                            }
                        }

                        if (myTile.unitsOnThisPanel.Any())
                        {

                            foreach (Unit myUnit in unit_List_black)
                            {
                                if (myUnit == myTile.unitsOnThisPanel.First())
                                {
                                    blackDefeated++;
                                }
                            }
                            foreach (Unit myUnit in unit_List_red)
                            {
                                if (myUnit == myTile.unitsOnThisPanel.First())
                                {
                                    redDefeated++;
                                }
                            }
                            //it is an acceptable jump

                            //delete the unit from myTile
                            deleteUnitMethod(myTile.unitsOnThisPanel.First());
                            myTile.unitsOnThisPanel.RemoveFirst();

                            //move the unit
                            allSelectedUnits[0].changeLocation(clickedTile);


                        }
                        else
                        {
                            MessageBox.Show("illegal move");
                        }
                    }

                    else if ((a == jumpLeft) && (d == jumpUp))
                    {
                        Panel1 myTile = new Panel1();//will be a reference to the tile we are jumping over
                        foreach (Panel1 tileJumpedOver in tilesCreated)
                        {

                            if ((tileJumpedOver.Location.X == c) && (tileJumpedOver.Location.Y == goingUp))
                            {
                                myTile = tileJumpedOver;
                                //MessageBox.Show(myTile.Name);
                            }
                        }

                        if (myTile.unitsOnThisPanel.Any())
                        {

                            foreach (Unit myUnit in unit_List_black)
                            {
                                if (myUnit == myTile.unitsOnThisPanel.First())
                                {
                                    blackDefeated++;
                                }
                            }
                            foreach (Unit myUnit in unit_List_red)
                            {
                                if (myUnit == myTile.unitsOnThisPanel.First())
                                {
                                    redDefeated++;
                                }
                            }
                            //it is an acceptable jump

                            //delete the unit from myTile
                            deleteUnitMethod(myTile.unitsOnThisPanel.First());
                            myTile.unitsOnThisPanel.RemoveFirst();

                            //move the unit
                            allSelectedUnits[0].changeLocation(clickedTile);


                        }
                        else
                        {
                            MessageBox.Show("illegal move");
                        }
                    }

                }

            }

        }

    }
}
