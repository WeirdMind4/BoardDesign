using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{

    class checkerRules
    {
        List<Square> masterList = new List<Square> { }; 

        //string blackCheckers;
        //string redCheckers;




        public void bCheckerPotential()
        {
           /* Click on square, get connected spaces
            * Then click on square that is connected and move
            * Work in the jump routiene
            * check to see if space is occupied

             * if(selected square is clicked)
             * {
             *   check else if potential square to move to are occupied
             *       {
             *          display ("no potential moves for piece")
             *       }
             *          else if (one potential move is open) 
             *              {
             *                  highlight potential move
             *              }
             *                  else(show potential squares)
             *                  {
             *                      highlight potential moves
             *                  }
             *                  
             *    return usermove;
             * 
             * }
             */
        }

        public void bCheckerMove()
        {
              /* recieve returned clicked square
               * now we have to move icon to selected square
               * 
               * get selected square icon location.
               * then we need to set the icon location to the usermove
               * square icon location = usermove(returned from first method)
               * then we need to change to the red checkers turn 
               * 
               */
        }
    }
}
