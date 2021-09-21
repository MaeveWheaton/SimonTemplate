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
        int pause = 500;
        Random rand = new Random();
        Matrix transformMatrix = new Matrix();

        //pyro, cryo, hydro, anemo
        List<Color> darkColours = new List<Color>(new Color[] { Color.DarkRed, Color.ForestGreen, Color.Goldenrod, Color.DarkBlue });
        List<Color> lightColours = new List<Color>(new Color[] { Color.Red, Color.LimeGreen, Color.Gold, Color.Blue });

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
            GraphicsPath redPath = new GraphicsPath();
            GraphicsPath greenPath = new GraphicsPath();
            GraphicsPath yellowPath = new GraphicsPath();
            GraphicsPath bluePath = new GraphicsPath();

            redPath.AddEllipse(5, 5, 220, 220);
            greenPath.AddEllipse(5, 5, 220, 220);
            yellowPath.AddEllipse(5, 5, 220, 220);
            bluePath.AddEllipse(5, 5, 220, 220);

            Region redRegion = new Region(redPath);
            Region greenRegion = new Region(greenPath);
            Region yellowRegion = new Region(yellowPath);
            Region blueRegion = new Region(bluePath);

            //set each button region then rotate
            greenRegion.Exclude(new Rectangle(0, 105, 110, 5)); //remove bottom line
            greenRegion.Exclude(new Rectangle(105, 0, 5, 110)); //remove right line
            greenButton.Region = greenRegion;

            transformMatrix.RotateAt(90, new PointF(55, 55)); //rotate
            redRegion.Transform(transformMatrix);
            redRegion.Exclude(new Rectangle(0, 105, 110, 5)); //remove bottom line
            redRegion.Exclude(new Rectangle(0, 0, 5, 110));  //remove left line
            redButton.Region = redRegion;

            transformMatrix.RotateAt(90, new PointF(55, 55)); //rotate
            blueRegion.Transform(transformMatrix);
            blueRegion.Exclude(new Rectangle(0, 0, 110, 5));  //remove top line
            blueRegion.Exclude(new Rectangle(0, 0, 5, 110));  //remove left line
            blueButton.Region = blueRegion;

            transformMatrix.RotateAt(90, new PointF(55, 55)); //rotate
            yellowRegion.Transform(transformMatrix);
            yellowRegion.Exclude(new Rectangle(0, 0, 110, 5));  //remove top line
            yellowRegion.Exclude(new Rectangle(105, 0, 5, 110)); //remove right line
            yellowButton.Region = yellowRegion;
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
                        redButton.BackColor = lightColours[0];
                        redButton.Refresh();
                        Thread.Sleep(pause);
                        redButton.BackColor = darkColours[0];
                        redButton.Refresh();
                        Thread.Sleep(pause);
                        break;
                    case 1:
                        greenButton.BackColor = lightColours[1];
                        greenButton.Refresh();
                        Thread.Sleep(pause);
                        greenButton.BackColor = darkColours[1];
                        greenButton.Refresh();
                        Thread.Sleep(pause);
                        break;
                    case 2:
                        yellowButton.BackColor = lightColours[2];
                        yellowButton.Refresh();
                        Thread.Sleep(pause);
                        yellowButton.BackColor = darkColours[2];
                        yellowButton.Refresh();
                        Thread.Sleep(pause);
                        break;
                    case 3:
                        blueButton.BackColor = lightColours[3];
                        blueButton.Refresh();
                        Thread.Sleep(pause);
                        blueButton.BackColor = darkColours[3];
                        blueButton.Refresh();
                        Thread.Sleep(pause);
                        break;
                }    
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
                redButton.BackColor = lightColours[0];
                gameSounds[0].Play();
                redButton.Refresh();
                Thread.Sleep(pause);
                redButton.BackColor = darkColours[0];
                redButton.Refresh();
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

        //TODO: create one of these event methods for each button
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
                greenButton.BackColor = lightColours[1];
                gameSounds[1].Play();
                greenButton.Refresh();
                Thread.Sleep(pause);
                greenButton.BackColor = darkColours[1];
                greenButton.Refresh();
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
                yellowButton.BackColor = lightColours[2];
                gameSounds[2].Play();
                yellowButton.Refresh();
                Thread.Sleep(pause);
                yellowButton.BackColor = darkColours[2];
                yellowButton.Refresh();
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
                blueButton.BackColor = lightColours[3];
                gameSounds[3].Play();
                blueButton.Refresh();
                Thread.Sleep(pause);
                blueButton.BackColor = darkColours[3];
                blueButton.Refresh();
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
