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
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

        }
    }
}