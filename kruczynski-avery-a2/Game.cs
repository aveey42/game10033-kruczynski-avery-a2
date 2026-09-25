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

            //check if light switch has been clicked
            if (Input.GetMouseX() >= 35 && Input.GetMouseX () <=75 && Input.GetMouseY() >=210 && Input.GetMouseY () >= 246 && Input.IsMouseButtonDown(MouseButton.Left) == true && lights_out == false)
            {
                lights_out = true;
                
            }
            else if (Input.GetMouseX() >= 35 && Input.GetMouseX() <= 75 && Input.GetMouseY() >= 185 && Input.GetMouseY() <= 246 && Input.IsMouseButtonDown(MouseButton.Left) == true && lights_out == true)
            {
                lights_out = false;
                // Change Stanley Phase 
                stanley_phase = +1;
            }


            // Clear screen/set room background colour
            if (lights_out == false)
            {
                Window.ClearBackground("F29D3F");

                // Remove outlines and set line colour
                Draw.SetLineColor(0);
                Draw.SetLineSize(0);

                // Cat
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
                Draw.Ellipse(pupil_right_x, pupil_right_y, 10, 30);


                // G1 - Nose
                Draw.SetFillColor(245, 157, 244);
                Draw.Triangle(190, 260, 210, 260, 200, 280);

                // H1 - Mouth
                Draw.Line(200, 280, 200, 290);
                // ask raph how to do curved half lines

                //Light Switch
                // I1 - Light Switch Cover
                Draw.SetFillColor(255, 255, 255);
                Draw.Rectangle(30, 180, 40, 120);

                // J1 - Light Switch
                Draw.SetFillColor(207, 207, 207);
                Draw.Rectangle(35, 185, 30, 110);
                Draw.SetFillColor(175, 175, 175);
                Draw.Rectangle(35, 185, 30, 55);

            }
            if (lights_out == true && stanley_phase == 0)
            {
                Window.ClearBackground(0);

                // Remove outlines and set outline colour to white
                Draw.SetLineSize(1);
                Draw.SetLineColor(255, 255, 255);

                // Cat
                // A2 - Inner Ears
                Draw.SetFillColor(0);
                Draw.Triangle(140, 170, 140, 200, 170, 200);
                Draw.Triangle(260, 170, 260, 200, 230, 200);

                // B2 Outline
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
                
                // Light Switch
                // G2 - Light Switch Cover
                Draw.Rectangle(30, 180, 40, 120);

                // H2 - Light Switch
                Draw.SetFillColor(85, 85, 85);
                Draw.Rectangle(35, 185, 30, 110);
                Draw.SetFillColor(0);
                Draw.Rectangle(35, 185, 30, 55);

                // Stanley
                Draw.SetLineSize(0);
                Draw.SetFillColor(202, 0, 0, 50);

                // Stanley Eyes
                Draw.Circle(50, 80, 10);
                Draw.Circle(90, 80, 10);

                // Stanley Smile

               
            }
            else if ( lights_out == true && stanley_phase == 1)
            {
                Window.ClearBackground(0);

                // Remove outlines and set outline colour to white
                Draw.SetLineSize(1);
                Draw.SetLineColor(255, 255, 255);


                // Cat
                // A3 - Inner Ears
                Draw.SetFillColor(0);
                Draw.Triangle(140, 170, 140, 200, 170, 200);
                Draw.Triangle(260, 170, 260, 200, 230, 200);

                // B3 Outline
                Draw.Line(130, 400, 130, 140);
                Draw.Line(130, 140, 180, 200);
                Draw.Line(180, 200, 220, 200);
                Draw.Line(220, 200, 270, 140);
                Draw.Line(270, 140, 270, 400);

                // C3 - Eyes
                Draw.SetFillColor(0);
                Draw.Circle(160, 240, 20);
                Draw.Circle(240, 240, 20);

                // D3 - Pupils
                // Pupil Left
                Draw.SetFillColor(255, 255, 255);
                Draw.Circle(170, 240, 10);
                Draw.Circle(250, 240, 10);

                // E3 - Nose
                Draw.SetFillColor(0);
                Draw.Triangle(190, 260, 210, 260, 200, 280);

                // F3 - Mouth
                Draw.Line(200, 280, 200, 290);
                // ask raph how to do curved half lines

                
                // Light Switch
                // G3 - Light Switch Cover
                Draw.Rectangle(30, 180, 40, 120);

                // H3 - Light Switch
                Draw.SetFillColor(85, 85, 85);
                Draw.Rectangle(35, 185, 30, 110);
                Draw.SetFillColor(0);
                Draw.Rectangle(35, 185, 30, 55);

                // Stanley
                Draw.SetLineSize(0);
                Draw.SetFillColor(202, 0, 0, 80);

                
                Draw.Circle(310,260,15);
                Draw.Circle(360, 260, 15);

                // - Stanley Smile

                
            }
            else if (lights_out == true && stanley_phase <= 2)
            {
                Window.ClearBackground(0);

                // Remove outlines and set outline colour to white
                Draw.SetLineSize(1);
                Draw.SetLineColor(255, 255, 255);

                //  - Inner Ears
                Draw.SetFillColor(0);
                Draw.Triangle(140, 170, 140, 200, 170, 200);
                Draw.Triangle(260, 170, 260, 200, 230, 200);

                //  Outline
                Draw.Line(130, 400, 130, 140);
                Draw.Line(130, 140, 180, 200);
                Draw.Line(180, 200, 220, 200);
                Draw.Line(220, 200, 270, 140);
                Draw.Line(270, 140, 270, 400);

                //  - Eyes
                Draw.SetFillColor(0);
                Draw.Circle(170, 240, 20);
                Draw.Circle(250, 240, 20);

                //  - Pupils
                // Pupil Left
                Draw.SetFillColor(255, 255, 255);
                Draw.Circle(160, 240, 16);
                Draw.Circle(240, 240, 16);

                //  - Nose
                Draw.SetFillColor(0);
                Draw.Triangle(190, 260, 210, 260, 200, 280);

                //  - Mouth
                Draw.Line(200, 280, 200, 290);
                Draw.Line(200, 290, 180, 310);
                Draw.Line(200, 290, 220, 310);

                //  - Light Switch Cover
                Draw.Rectangle(30, 180, 40, 120);

                //  - Light Switch
                Draw.SetFillColor(85, 85, 85);
                Draw.Rectangle(35, 185, 30, 110);
                Draw.SetFillColor(0);
                Draw.Rectangle(35, 185, 30, 55);

                //  Stanley
                Draw.SetLineSize(1);
                Draw.SetFillColor(202, 0, 0);
                
                // - Eyes
                Draw.Circle(120,60,40);
                Draw.Circle(280,60,40);

                // - Pupils
                Draw.SetFillColor(255, 255, 255);
                Draw.Circle(120, 80, 20);
                Draw.Circle(280, 80, 20);

                // - Smile


            }
        }
            
        }

    }
