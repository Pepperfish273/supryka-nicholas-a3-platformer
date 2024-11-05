using Game10003;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace supryka_nicholas_a3_platformer
{
    public class Player
    {
        public Vector2 position;
        public Vector2 size;
        public Color playerOne = new Color(230,0,0);
        public float speed;

        public Player()
        {

        }

        public void DrawPlayer()
        {
            Draw.LineSize = 1;
            Draw.LineColor = Color.Black;
            Draw.FillColor = playerOne;
            Draw.Rectangle(position, size);
        }
        

        public void MovePlayer()
        {
            // Movement Checks
            if (Input.IsKeyboardKeyDown(KeyboardInput.Left))
            {
                position.X -= speed + Time.DeltaTime;
            }
            if (Input.IsKeyboardKeyDown(KeyboardInput.Right))
            {
                position.X += speed + Time.DeltaTime;
            }

            // Keeps player inside border
            if (position.X < 0)
            {
                position.X = 0;
            }
            if (position.X + size.X > Window.Width)
            {
                position.X = Window.Width - size.X;
            }
            
            
        }
        
    }
}
