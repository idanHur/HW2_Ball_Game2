namespace HW2
{
    public partial class Form1 : Form
    {
        public Game? Game { get; private set; }
        public Form1()
        {
            InitializeComponent();
            this.Paint += GameForm_Paint;
            Game = null;
        }
        private void GameForm_Paint(object? sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (Game == null)
            {
                return;
            }
            List<Ball> balls = Game.Balls; // Get the list of balls from your game class

            foreach (Ball ball in balls)
            {
                Brush brush = new SolidBrush(Color.FromName(ball.Color));

                float x = ball.X - ball.Radius;
                float y = ball.Y - ball.Radius;
                float diameter = ball.Radius * 2;

                g.FillEllipse(brush, x, y, diameter, diameter);
            }
        }
        private void AddBallButton_Click(object sender, EventArgs e)
        {

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