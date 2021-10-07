/*
 * Maeve Wheaton
 * Mr. T
 * Simon Says: A randomly generated pattern of four colours is shown to the screen one by one, 
 * the player must repeat the pattern by pressing the appropriate buttons in order.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Drawing.Drawing2D;

namespace SimonSays
{
    public partial class Form1 : Form
    {
        public static List<int> pattern = new List<int>();
        public static List<int> highScores = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MenuScreen gs = new MenuScreen();
            this.Controls.Add(gs);

            //centre screen on the form
            gs.Location = new Point((this.Width - gs.Width) / 2, (this.Height - gs.Height) / 2);
        }
    }
}
