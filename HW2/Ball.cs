using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    public class Ball
    {
        // Properties
        public float X { get; set; }
        public float Y { get; set; }
        public float Radius { get; set; }
        public float Jump { get; set; }
        public string Color { get; set; }

        // Constructor
        public Ball(int x, int y)
        {
            Random random = new Random();
            X = random.Next(0, x); // Generate random X coordinate within the form width
            Y = random.Next(0, y); // Generate random Y coordinate within the form height
            Color = GenerateRandomColor();
            Radius = random.Next(10, 41); // Generates a random number between 10 and 40 (inclusive)
            ChangeJumpSize();
        }

        // Methods
        public void Move(float deltaX, float deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }

        public void Draw()
        {
            // Implementation for drawing the ball on the screen
            // This can be console output or using a graphical library like Windows Forms or WPF
            // Example: Console.WriteLine($"Ball: X={X}, Y={Y}, Radius={Radius}, Color={Color}");
        }
        // Generate a random color
        private string GenerateRandomColor()
        {
            Random random = new Random();
            byte[] colorBytes = new byte[3];
            random.NextBytes(colorBytes);

            return $"#{colorBytes[0]:X2}{colorBytes[1]:X2}{colorBytes[2]:X2}";
        }
        public void ChangeJumpSize()
        {
            Random random = new Random();
            Jump = random.Next(1, 6); // Generates a random number between 1 and 5 (inclusive)
        }
    }
}
