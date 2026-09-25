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
        // Variables go here
        int stanley_phase = 0;
        bool lights_out = false;
        float pupil_left_x = 160;
        float pupil_left_y = 240;
        float pupil_right_x = 240;
        float pupil_right_y = 240;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("mycat.exe");
            Window.SetSize(400, 400);
            Window.TargetFPS = 60;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

            //check if light switch has been clicked and increase stanley's position
            if (Input.GetMouseX() >= 35 && Input.GetMouseX () <=75 && Input.GetMouseY() >=210 && Input.GetMouseY () >= 246 && Input.IsMouseButtonDown(MouseButton.Left) == true && lights_out == false)
            {
                lights_out = true;
                stanley_phase =+ 1;
            }
            else if (Input.GetMouseX() >= 35 && Input.GetMouseX() <= 75 && Input.GetMouseY() >= 185 && Input.GetMouseY() <= 246 && Input.IsMouseButtonDown(MouseButton.Left) == true && lights_out == true)
            {
                lights_out = false;
            }


            // Clear screen/set room background colour
            if (lights_out == false)
            {
                Window.ClearBackground("F29D3F");

                // Remove outlines and set line colour
                Draw.SetLineColor(0);
                Draw.SetLineSize(0);

                // Draw the cat
                // A1 - Body
                Draw.SetFillColor(255, 255, 255);
                Draw.Rectangle(130, 200, 140, 200);

                // B1 - Ears
                Draw.SetFillColor(255, 255, 255);
                Draw.Triangle(130, 140, 180, 200, 130, 200);
                Draw.SetFillColor(255, 255, 255);
                Draw.Triangle(270, 140, 270, 200, 220, 200);

                // add back outlines
                Draw.SetLineSize(1);

                // C1 - Inner Ears
                Draw.SetFillColor(245, 157, 244);
                Draw.Triangle(140, 170, 140, 200, 170, 200);
                Draw.SetFillColor(245, 157, 244);
                Draw.Triangle(260, 170, 260, 200, 230, 200);

                // D1 Outline of Cat
                Draw.Line(130, 400, 130, 140);
                Draw.Line(130, 140, 180, 200);
                Draw.Line(180, 200, 220, 200);
                Draw.Line(220, 200, 270, 140);
                Draw.Line(270, 140, 270, 400);

                // E1 - Eyes
                Draw.SetFillColor(188, 240, 187);
                Draw.Circle(160, 240, 20);
                Draw.Circle(240, 240, 20);

                // F1 - Pupils
                // Pupil Left
                Draw.SetFillColor(0);
                Draw.Ellipse(pupil_left_x, pupil_left_y, 10, 30);
                if (pupil_left_x >= 140 && pupil_left_x <= 180)
                {
                    pupil_left_x += 100 * Time.DeltaTime;
                }
                if (Input.IsKeyboardKeyDown(KeyboardKey.Left) == true)
                {
                    pupil_left_x -= 100 * Time.DeltaTime;
                }

                if (Input.IsKeyboardKeyDown(KeyboardKey.Down) == true)
                {
                    pupil_left_y += 100 * Time.DeltaTime;
                }
                if (Input.IsKeyboardKeyDown(KeyboardKey.Up) == true)
                {
                    pupil_left_y -= 100 * Time.DeltaTime;
                }

                // Right Pupil
                Draw.Ellipse(pupil_right_x, pupil_right_y, 10, 30);
                if (Input.IsKeyboardKeyDown(KeyboardKey.Right) == true)
                {
                    pupil_right_x += 100 * Time.DeltaTime;
                }
                if (Input.IsKeyboardKeyDown(KeyboardKey.Left) == true)
                {
                    pupil_right_x -= 100 * Time.DeltaTime;
                }

                if (Input.IsKeyboardKeyDown(KeyboardKey.Down) == true)
                {
                    pupil_right_y += 100 * Time.DeltaTime;
                }
                if (Input.IsKeyboardKeyDown(KeyboardKey.Up) == true)
                {
                    pupil_right_y -= 100 * Time.DeltaTime;
                }

                //Draw.Ellipse(160, 240, 10, 30);
                //Draw.Ellipse(240, 240, 10, 30);

                // G1 - Nose
                Draw.SetFillColor(245, 157, 244);
                Draw.Triangle(190, 260, 210, 260, 200, 280);

                // H1 - Mouth
                Draw.Line(200, 280, 200, 290);
                // ask raph how to do curved half lines

                // I1 - Light Switch Cover
                Draw.SetFillColor(255, 255, 255);
                Draw.Rectangle(30, 180, 40, 120);

                // J1 - Light Switch
                Draw.SetFillColor(207, 207, 207);
                Draw.Rectangle(35, 185, 30, 110);
                Draw.SetFillColor(175, 175, 175);
                Draw.Rectangle(35, 185, 30, 55);
            }
            if (lights_out == true)
            {
                Window.ClearBackground(0);

                // Remove outlines and set outline colour to white
                Draw.SetLineSize(1);
                Draw.SetLineColor(255, 255, 255);

                // A2 - Inner Ears
                Draw.SetFillColor(0);
                Draw.Triangle(140, 170, 140, 200, 170, 200);
                Draw.Triangle(260, 170, 260, 200, 230, 200);

                // B21 Outline
                Draw.Line(130, 400, 130, 140);
                Draw.Line(130, 140, 180, 200);
                Draw.Line(180, 200, 220, 200);
                Draw.Line(220, 200, 270, 140);
                Draw.Line(270, 140, 270, 400);

                // C2 - Eyes
                Draw.SetFillColor(0);
                Draw.Circle(160, 240, 20);
                Draw.Circle(240, 240, 20);

                // D2 - Pupils
                // Pupil Left
                Draw.SetFillColor(255, 255, 255);
                Draw.Circle(160, 240, 10);
                Draw.Circle(240, 240, 10);

                // E2 - Nose
                Draw.SetFillColor(0);
                Draw.Triangle(190, 260, 210, 260, 200, 280);

                // F2 - Mouth
                Draw.Line(200, 280, 200, 290);
                // ask raph how to do curved half lines

                // G2 - Light Switch Cover
                Draw.Rectangle(30, 180, 40, 120);

                // H2 - Light Switch
                Draw.SetFillColor(85, 85, 85);
                Draw.Rectangle(35, 185, 30, 110);
                Draw.SetFillColor(0);
                Draw.Rectangle(35, 185, 30, 55);

                // I2 - Stanley
                Draw.SetLineSize(0);
                Draw.SetFillColor(50, 50, 50);
                Draw.Circle(50, 80, 10);
                Draw.Circle(90, 80, 10);
                // smile goes here
            }
            //else if (stanley_phase == 1)
            //{

            //}
            }
            
        }

    }
