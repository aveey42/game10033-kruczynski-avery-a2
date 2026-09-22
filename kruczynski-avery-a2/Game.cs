// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("mycat.exe");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            // Clear screen
            Window.ClearBackground("F29D3F");

            // Remove outlines
            Draw.SetLineSize(0);

            // Draw the cat
            // A1 - Body
            Draw.SetFillColor(255, 255, 255);
            Draw.Rectangle(130, 200, 140, 200);

            // B1 - Ears
            Draw.SetFillColor(255, 255, 255);
            Draw.Triangle(130, 140, 180, 200, 130, 200);
            Draw.SetFillColor(255, 255, 255);
            Draw.Triangle(270,140, 270, 200, 220, 200);

            // add back outlines
            Draw.SetLineSize(1);

            // C1 - Inner Ears
            Draw.SetFillColor(245, 157, 244);
            Draw.Triangle(140,170,140,200,170,200);
            Draw.SetFillColor(245, 157, 244);
            Draw.Triangle(260,170,260,200,230, 200);

            // D1 Outline

            // E1 - Eyes
            Draw.SetFillColor(188, 240, 187);
            Draw.Circle(160, 240, 20);
            Draw.Circle(240, 240, 20);

            // F1 - Pupils
            Draw.SetFillColor(0);
            Draw.Ellipse(160, 240, 10,30);
            Draw.Ellipse(240, 240, 10,30);

            // G1 - Nose
            Draw.SetFillColor(245, 157, 244);
            Draw.Triangle(190,260,210,260,200,280);

            // H1 - Mouth
            Draw.Line(200,280,200,290);
            // ask raph how to do curved half lines

            // I1 - Light Switch Cover
            Draw.SetFillColor(255,255,255);
            Draw.Rectangle(30,180,40,120);

            // J1 - Light Switch
            Draw.SetFillColor(207, 207, 207);
            Draw.Rectangle(35, 185, 30, 120);
            Draw.SetFillColor(175,175,175);
            Draw.Rectangle(35, 185, 30, 30);
            
        }
    }

}
