using Timer = System.Windows.Forms.Timer;

namespace HW2
{
    public partial class Form1 : Form
    {
        public Game? Game { get; private set; }
        private Timer timer;
        public Form1()
        {
            InitializeComponent();
            this.Paint += GameForm_Paint;
            Game = null;
            // Enable double buffering
            DoubleBuffered = true;
            // Create and configure the Timer control
            timer = new Timer();
            timer.Interval = 50; // Refresh rate of 20 frames per second
            timer.Enabled = true;

            // Subscribe to the Timer's Tick event
            timer.Tick += Timer_Tick;
        }
        private void GameForm_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (Game == null)
            {
                return;
            }
            Console.WriteLine("in GameForm_Paint");
            List<Ball> balls = Game.Balls; // Get the list of balls from your game class

            foreach (Ball ball in balls)
            {
                Color color = ColorTranslator.FromHtml(ball.Color); // Convert the color string to a Color object

                Brush brush = new SolidBrush(color);
                float x = ball.X - ball.Radius;
                float y = ball.Y - ball.Radius;
                float diameter = ball.Radius * 2;

                g.FillEllipse(brush, x, y, diameter, diameter);
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Game != null) {
                // Update the positions of the balls...
                label1.Text = Game.Balls.Count.ToString();
            }
            

            // Trigger a repaint of the form
            Invalidate();
        }
        private void AddBallButton_Click(object sender, EventArgs e)
        {
            if (Game == null)
            {
                NameForm playerNameForm = new NameForm();
                if (playerNameForm.ShowDialog() == DialogResult.OK) // A name was entered and we can start a new game
                {
                    string playerName = playerNameForm.PlayerName;
                    Game = new Game(playerName);
                }
                else
                {
                    return; // There is no game in prgress and no name was entered
                }
            }
            else
            {
                Game.AddBall(this.Width, this.Height); // Add a ball to the game in progress 
            }

        }

        private void StopLastButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveBallButton_Click(object sender, EventArgs e)
        {

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {

        }

        private void EndGameButton_Click(object sender, EventArgs e)
        {

        }

        private void DBButton_Click(object sender, EventArgs e)
        {

        }

        private void EndProgramButton_Click(object sender, EventArgs e)
        {

        }
    }
}