using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class Game
    {
        // Properties
        private List<Ball> balls;
        private DateTime startTime;
        public string Name { get; set; }

        // Constructor
        public Game(string name, float y)
        {
            Name = name;
            balls = new List<Ball>();
            startTime = DateTime.Now; // Initialize the start time


        }
        public DateTime StartTime
        {
            get { return startTime; }
        }
        public List<Ball> Balls
        {
            get { return balls; }
        }
        public void AddBall(Ball ball)
        {
            balls.Add(ball);
        }

        public void RemoveBall(Ball ball)
        {
            balls.Remove(ball);
        }
    }
}
