using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGame
{
    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            List <Square> masterList = new List<Square>{ };//this must be created when you are making each board
            Square testSquare = new Square(1,masterList);//instantiate first square
            Square testSquare2 = new Square(2,masterList); //instantiate second square
            Units testUnit = new Units(testSquare);// instantiate testUnit at location testSquare
            int testsquare2LocationID = testSquare2.getSquareID(); //get the locationID of testSquare2
            testSquare.getSquareListOfConnectedLocationIDs(testSquare).Add(testsquare2LocationID);//adds a link to allow the unit to go from testSquare to testSquare2
            testSquare.getSquareListOfConnectedLocationIDs(testSquare).Add(testsquare2LocationID);//adds the locationID of testSquare2 to the list of connected locations in testSquare1
           
            testUnit.changeLoationSpecifically(testUnit, masterList, 2);//uses the method implementation to change of the unit's location
        }
    }
    public class Units
    {
        private Square currentLocation;//square's current location
        public Units(Square startingLocation)//instantiate a Unit
        {

            //graphic representaion
            //variable to hold locationID
            this.currentLocation = startingLocation;
        }
        public Square getLocation(Units thisUnit)
        {
            return thisUnit.currentLocation;
        }

        public void changeLocation(Square newLocation)
        {
            this.currentLocation = newLocation;
        }

        public void changeLoationSpecifically(Units thisUnit, List<Square> unitList, int newLocationID)
        {
            foreach (Square location in unitList)
            {
                
                if (location.getSquareID() == newLocationID)
                {
                    //this if statement verifies that the unit can move to this location
                    if (thisUnit.getLocation(thisUnit).getSquareListOfConnectedLocationIDs(thisUnit.getLocation(thisUnit)).Contains(2))
                    {
                        thisUnit.currentLocation = location;
                    }
                    
                }
            }
        }
        

    }
    public class Square
    {
        //public List<Square> locationList;
        private int locationID;
        private List<int> listOfConnectedLocationIDs = new List<int> { };
        public Square(int ID)
        {
            //locationID
            
            locationID = ID;
            //locationList.Add(this);

            //color
            //list of other squares it can go to
            listOfConnectedLocationIDs.Add(this.locationID);
        }
        //Consstructor where it adds the square to the master list
        public Square(int ID, List<Square> masterList)
        {
            //locationID
            locationID = ID;
            //locationList.Add(this);

            //color
            //list of other squares it can go to
            listOfConnectedLocationIDs.Add(this.locationID);
            //add this Square to the Master List
            masterList.Add(this);
        }

        public int getSquareID()
        {
            return this.locationID;
        }
        public List<int> getSquareListOfConnectedLocationIDs(Square thisSquare)
        {
            return thisSquare.listOfConnectedLocationIDs;
        }

    }


}
