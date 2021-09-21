using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;
using System.Threading;

namespace SimonSays
{
    public partial class GameScreen : UserControl
    {
        //TODO: create guess variable to track what part of the pattern the user is at
        int guessIndex;
        int pause = 450;
        Random rand = new Random();
        Matrix transformMatrix = new Matrix();

        //pyro, cryo, electro, hydro colours
        List<Color> darkColours = new List<Color>(new Color[] { Color.DarkRed, Color.DarkCyan, Color.Indigo, Color.Navy });
        List<Color> lightColours = new List<Color>(new Color[] { Color.OrangeRed, Color.LightSeaGreen, Color.DarkOrchid, Color.DodgerBlue });

        List<SoundPlayer> gameSounds = new List<SoundPlayer>(new SoundPlayer[] {
            new SoundPlayer(Properties.Resources.red), new SoundPlayer(Properties.Resources.green), 
            new SoundPlayer(Properties.Resources.yellow), new SoundPlayer(Properties.Resources.blue), 
            new SoundPlayer(Properties.Resources.mistake), }); 

        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            ShapeButtons();

            //clear pattern list, refresh, pause, run ComputerTurn()
            Form1.pattern.Clear();
            Refresh();
            Thread.Sleep(1000);

            ComputerTurn();
        }

        public void ShapeButtons()
        {
            GraphicsPath circlePath = new GraphicsPath(); //create curved edge and centre hole
            circlePath.AddEllipse(5, 5, 220, 220);
            circlePath.AddEllipse(70, 70, 80, 80);

            Region buttonRegion = new Region(circlePath);

            buttonRegion.Exclude(new Rectangle(0, 105, 110, 5)); //remove outside edges
            buttonRegion.Exclude(new Rectangle(0, 0, 5, 110));
            buttonRegion.Exclude(new Rectangle(0, 0, 110, 5));
            buttonRegion.Exclude(new Rectangle(105, 0, 5, 110));

            cryoButton.Region = buttonRegion;

            transformMatrix.RotateAt(90, new PointF(55, 55)); //rotate
            buttonRegion.Transform(transformMatrix);
            pyroButton.Region = buttonRegion;

            transformMatrix.RotateAt(90, new PointF(55, 55)); //rotate
            buttonRegion.Transform(transformMatrix);
            electroButton.Region = buttonRegion;

            transformMatrix.RotateAt(90, new PointF(55, 55)); //rotate
            buttonRegion.Transform(transformMatrix);
            hydroButton.Region = buttonRegion;
        }

        private void ComputerTurn()
        {
            //get rand num between 0 and 4 (0, 1, 2, 3), add to pattern list
            Form1.pattern.Add(rand.Next(0, 4));

            //shows each value in the pattern by lighting up approriate button
            for (int i = 0; i < Form1.pattern.Count; i++)
            {
                switch (Form1.pattern[i])
                {
                    case 0:
                        pyroButton.BackColor = lightColours[0];
                        pyroButton.Refresh();
                        Thread.Sleep(pause);
                        pyroButton.BackColor = darkColours[0];
                        pyroButton.Refresh();
                        Thread.Sleep(pause);
                        break;
                    case 1:
                        cryoButton.BackColor = lightColours[1];
                        cryoButton.Refresh();
                        Thread.Sleep(pause);
                        cryoButton.BackColor = darkColours[1];
                        cryoButton.Refresh();
                        Thread.Sleep(pause);
                        break;
                    case 2:
                        electroButton.BackColor = lightColours[2];
                        electroButton.Refresh();
                        Thread.Sleep(pause);
                        electroButton.BackColor = darkColours[2];
                        electroButton.Refresh();
                        Thread.Sleep(pause);
                        break;
                    case 3:
                        hydroButton.BackColor = lightColours[3];
                        hydroButton.Refresh();
                        Thread.Sleep(pause);
                        hydroButton.BackColor = darkColours[3];
                        hydroButton.Refresh();
                        Thread.Sleep(pause);
                        break;
                }    
            }

            //speed up pattern show at 5, 10, 15 colours
            if (Form1.pattern.Count == 5 || Form1.pattern.Count == 10 || Form1.pattern.Count == 15)
            {
                pause -= 50;
            }

            //set guess index value back to 0
            guessIndex = 0;
        }

        public void GameOver()
        {
            //Play a game over sound
            gameSounds[4].Play();

            //close this screen, open GameOverScreen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameOverScreen gs = new GameOverScreen();
            f.Controls.Add(gs);

            //centre screen on the form
            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guessIndex] == 0)
            {
                pyroButton.BackColor = lightColours[0];
                gameSounds[0].Play();
                pyroButton.Refresh();
                Thread.Sleep(pause);
                pyroButton.BackColor = darkColours[0];
                pyroButton.Refresh();
                Thread.Sleep(pause);

                guessIndex++;

                if (guessIndex == Form1.pattern.Count)
                {
                    ComputerTurn();
                }
            }
            else
            {
                GameOver();
            }
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            //TODO: is the value at current guess index equal to a green. If so:
                // light up button, play sound, and pause
                // set button colour back to original
                // add one to the guess index
                // check to see if we are at the end of the pattern. If so:
                    // call ComputerTurn() method
                // else call GameOver method
            if(Form1.pattern[guessIndex] == 1)
            {
                cryoButton.BackColor = lightColours[1];
                gameSounds[1].Play();
                cryoButton.Refresh();
                Thread.Sleep(pause);
                cryoButton.BackColor = darkColours[1];
                cryoButton.Refresh();
                Thread.Sleep(pause);

                guessIndex++;

                if(guessIndex == Form1.pattern.Count)
                {
                    ComputerTurn();
                }
            }
            else
            {
                GameOver();
            }
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guessIndex] == 2)
            {
                electroButton.BackColor = lightColours[2];
                gameSounds[2].Play();
                electroButton.Refresh();
                Thread.Sleep(pause);
                electroButton.BackColor = darkColours[2];
                electroButton.Refresh();
                Thread.Sleep(pause);

                guessIndex++;

                if (guessIndex == Form1.pattern.Count)
                {
                    ComputerTurn();
                }
            }
            else
            {
                GameOver();
            }
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            if (Form1.pattern[guessIndex] == 3)
            {
                hydroButton.BackColor = lightColours[3];
                gameSounds[3].Play();
                hydroButton.Refresh();
                Thread.Sleep(pause);
                hydroButton.BackColor = darkColours[3];
                hydroButton.Refresh();
                Thread.Sleep(pause);

                guessIndex++;

                if (guessIndex == Form1.pattern.Count)
                {
                    ComputerTurn();
                }
            }
            else
            {
                GameOver();
            }
        }
    }
}
