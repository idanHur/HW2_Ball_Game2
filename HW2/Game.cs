using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    public class Game
    {
        // Properties
        private List<Ball> balls;
        private DateTime startTime;
        private bool HoldLastBall { get; set; }
        public string Name { get; set; }

        // Constructor
        public Game(string name)
        {
            Name = name;
            balls = new List<Ball>();
            startTime = DateTime.Now; // Initialize the start time
            HoldLastBall = false;
        }
        public void ChangeHoldLastBall()
        {
            HoldLastBall = !HoldLastBall;
            if (balls.Count > 0)
            {
                balls[balls.Count - 1].HoldBall = HoldLastBall;
            }   
        }
        public DateTime StartTime
        {
            get { return startTime; }
        }
        public List<Ball> Balls
        {
            get { return balls; }
        }
        public void AddBall(Form1 form)
        {
            if (HoldLastBall)
            {
                if (balls.Count > 0)
                {
                    balls[balls.Count - 1].HoldBall = false;
                }

                Ball ball = new Ball(form);
                balls.Add(ball);
                balls[balls.Count - 1].HoldBall = true;
            }
            else
            {
                Ball ball = new Ball(form);
                balls.Add(ball);
            }
        }
        public int CalculateGameLength()
        {
            DateTime currentTime = DateTime.Now;

            TimeSpan difference = currentTime - StartTime;

            double seconds = difference.TotalSeconds;
            int secondsAsInt = (int)seconds;

            return secondsAsInt;
        }
        public void RemoveLastBall()
        {
            if (balls.Count > 0) {
                balls.Remove(balls[balls.Count - 1]);
            }
        }
        public void RemoveBall(Ball ball)
        {
            balls.Remove(ball);
        }
    }
}
