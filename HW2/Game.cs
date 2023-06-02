﻿using System;
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
        public string Name { get; set; }

        // Constructor
        public Game(string name)
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
        public void AddBall(int formWidth, int formHeight)
        {
            Ball ball = new Ball(formWidth, formHeight);
            balls.Add(ball);
        }

        public void RemoveBall(Ball ball)
        {
            balls.Remove(ball);
        }
    }
}
