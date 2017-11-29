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
        private void Save_Click(object sender, EventArgs e)
        {
            //need to alter this string so that it contains 
            //all of the data that is needed to reload the program

            string[] lines = { "First line", "Second line", "Third line" };
            
            
            
            
            
            
            //sets the place to put the save file to Desktop
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            System.IO.File.WriteAllLines(mydocpath + @"\BoardGame.txt", lines);

        }
    }
}
