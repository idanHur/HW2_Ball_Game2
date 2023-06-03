﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2
{
    public class Ball
    {
        // Properties
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Radius { get; private set; }
        public string Color { get; private set; }
        private int Jump { get; set; }
        private int DirectionX { get; set; }
        private int DirectionY { get; set; }
        private int maxX { get; set; }
        private int maxY { get; set; }
        // Constructor
        public Ball(int formWidth, int formHeight)
        {
            Random random = new Random();
            Color = GenerateRandomColor();
            Radius = random.Next(10, 41); // Generates a random number between 10 and 40 (inclusive)
            // Calculate the maximum X and Y coordinates that keep the ball within the form bounds, considering form border, title bar, and ToolStrip height
            // TODO: Fix positining 
            maxX = formWidth - Radius * 2 - SystemInformation.BorderSize.Width * 2;
            maxY = formHeight - Radius * 2 - SystemInformation.BorderSize.Height * 2 - SystemInformation.CaptionHeight ;

            X = random.Next(Radius, maxX); // Generate random X coordinate within the form width
            Y = random.Next(Radius, maxY); // Generate random Y coordinate within the form height
            DecideDirectionX(true);
            DecideDirectionY(true);
        }
        // Methods
        private void DecideDirectionX(bool initial = false)
        {
            if (initial)
            {
                // If it is the first time set jump size and make random direction if not hitting the wall
                ChangeJumpSize();

                if (X - Jump > 0 && X + Jump < maxX)
                {
                    Random random = new Random();
                    DirectionX = random.Next(0, 2);
                }
                else if (X - Jump > 0)
                {
                    DirectionX = 1;
                }
                else
                {
                    DirectionX = 0;
                }

                return;
            }
            else
            {
                int tempX = DirectionX == 0 ? X + Jump : X - Jump;
                // If after a jump the ball will hit a wall then change direction
                if (tempX < 0 || tempX > maxX)
                {
                    DirectionX = DirectionX == 0 ? 1 : 0;
                    ChangeJumpSize();
                }
            }
        }

        private void DecideDirectionY(bool initial = false)
        {
            if (initial)
            {
                // If it is the first time set jump size and make random direction if not hitting the wall
                ChangeJumpSize();

                if (Y - Jump > 0 && Y + Jump < maxY)
                {
                    Random random = new Random();
                    DirectionY = random.Next(0, 2);
                }
                else if (Y - Jump > 0)
                {
                    DirectionY = 1;
                }
                else
                {
                    DirectionY = 0;
                }

                return;
            }
            else
            {
                int tempY = DirectionY == 0 ? Y + Jump : Y - Jump;
                // If after a jump the ball will hit a wall then change direction
                if (tempY < 0 || tempY > maxY)
                {
                    DirectionY = DirectionY == 0 ? 1 : 0;
                    ChangeJumpSize();
                }
            }
        }


        public void Move()
        {
            X = DirectionX == 0 ? X + Jump : X - Jump;
            Y = DirectionY == 0 ? Y + Jump : Y - Jump;

            AdjustPositionAndDirection();
        }

        private void AdjustPositionAndDirection() 
        {
            // In case one of the edges was reached change direction and position
            if (X < Radius || X > maxX)
            {
                DecideDirectionX();
                X = X < Radius ? Radius : maxX; 
            }

            if (Y < Radius || Y > maxY)
            {
                DecideDirectionY();
                Y = Y < Radius ? Radius : maxY;
            }
        }

        // Generate a random color
        private string GenerateRandomColor()
        {
            Random random = new Random();
            byte[] colorBytes = new byte[3];
            random.NextBytes(colorBytes);

            return $"#{colorBytes[0]:X2}{colorBytes[1]:X2}{colorBytes[2]:X2}";
        }
        private void ChangeJumpSize()
        {
            Random random = new Random();
            Jump = random.Next(1, 6); // Generates a random number between 1 and 5 (inclusive)
        }
    }
}
