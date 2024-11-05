using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supryka_nicholas_a3_platformer
{
    public class Ground
    {
        public Vector2 position;
        public Vector2 size;


        public void DrawPlatform()
        {
            Draw.LineSize = 1;
            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.Green;
            Draw.Rectangle(position, size);
        }

    }
}
