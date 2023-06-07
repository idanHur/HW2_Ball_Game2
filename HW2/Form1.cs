using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2
{
    public partial class Form1 : Form
    {
        public Game Game { get; private set; }
        private Timer timer;
        private Dictionary<string, Bitmap> ballBitmaps = new Dictionary<string, Bitmap>();
        private GamesDBDataContext db = new GamesDBDataContext();
        public Form1()
        {
            InitializeComponent();
            // Enable double buffering
            DoubleBuffered = true;
            this.Paint += GameForm_Paint;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Disable resize
            Game = null;
            // Create and configure the Timer control
            timer = new Timer();
            timer.Interval = 50; // Refresh rate of 20 frames per second
            timer.Enabled = true;

            // Subscribe to the KeyDown event
            this.KeyDown += Form1_KeyDown;

            // Subscribe to the Timer's Tick event
            timer.Tick += Timer_Tick;
        }
        public ToolStrip ToolStrip1
        {
            get { return toolStrip1; }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Game != null)
                    AddBall(); // Add ball when enter is pressed
            }
        }
        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (Game == null)
            {
                return;
            }
            List<Ball> balls = Game.Balls; // Get the list of balls from your game class

            foreach (Ball ball in balls)
            {
                float x = ball.X - ball.Radius;
                float y = ball.Y - ball.Radius;
                int diameter = ball.Radius * 2;

                if (!ballBitmaps.TryGetValue(ball.Color, out Bitmap existingBallBitmap))
                {
                    // Create a new bitmap for the ball's color if it doesn't exist in the dictionary
                    existingBallBitmap = new Bitmap(diameter, diameter);
                    using (Graphics bitmapGraphics = Graphics.FromImage(existingBallBitmap))
                    {
                        using (Brush brush = new SolidBrush(ColorTranslator.FromHtml(ball.Color)))
                        {
                            bitmapGraphics.FillEllipse(brush, 0, 0, diameter, diameter);
                        }
                    }
                    ballBitmaps[ball.Color] = existingBallBitmap;
                }

                Bitmap ballBitmap = existingBallBitmap;
                g.DrawImage(ballBitmap, x, y);
            }
        }



        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Game != null)
            {
                List<Ball> balls = Game.Balls; // Get the list of balls from your game class
                foreach (Ball ball in balls)
                {
                    ball.Move();
                }
            }
            // Trigger a repaint of the form
            Invalidate();
        }
        private void AddBall()
        {
            if (Game == null)
            {
                NameForm playerNameForm = new NameForm();
                if (playerNameForm.ShowDialog() == DialogResult.OK) // A name was entered and we can start a new game
                {
                    string playerName = playerNameForm.PlayerName;
                    Game = new Game(playerName);
                    ballBitmaps = new Dictionary<string, Bitmap>();
                }
                else
                {
                    return; // There is no game in progress and no name was entered
                }
            }
            else
            {
                Game.AddBall(this); // Add a ball to the game in progress 
            }
        }
        private void AddBallButton_Click(object sender, EventArgs e)
        {
            AddBall();
        }

        private void StopLastButton_Click(object sender, EventArgs e)
        {
            if (Game == null)
                return;
            Game.ChangeHoldLastBall();
        }

        private void RemoveBallButton_Click(object sender, EventArgs e)
        {
            if (Game == null)
                return;
            Game.RemoveLastBall();
            // Removing the last item
            if (ballBitmaps.Count > 0)
            {
                var lastItem = ballBitmaps.LastOrDefault();
                if (lastItem.Value != null)
                {
                    ballBitmaps.Remove(lastItem.Key);
                }
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {

        }

        private void EndGameButton_Click(object sender, EventArgs e)
        {
            if (Game == null)
                return;
            else
            {
                AddToDB();
                Game = null;
            }
        }
        private void AddToDB()
        {
            var recordEntity = new Record
            {
                Name = Game.Name,
                Length = Game.CalculateGameLength()
            };

            db.Records.InsertOnSubmit(recordEntity);
            db.SubmitChanges();
        }

        private void DBButton_Click(object sender, EventArgs e)
        {

        }

        private void EndProgramButton_Click(object sender, EventArgs e)
        {
            if (Game != null)
            {
                AddToDB();
                Game = null;
            }
            ExitForm exForm = new ExitForm();
            exForm.Show(); // or exForm.ShowDialog();
        }

    }
}
