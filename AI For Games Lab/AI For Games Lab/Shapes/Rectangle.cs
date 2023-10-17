using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_For_Games_Lab.Shapes
{
    internal class Rectangle : Shape
    {
        public float width;
        public float height;
        public Rectangle(Vector2 pPosition, Color pColour, float pWidth, float pHeight) : base(pPosition, pColour)
        {
            width = pWidth;
            height = pHeight;
        }

        public override bool isInside(Vector2 point)
        {
            float halfHeight = height * 0.5f;
            float halfWidth = width * 0.5f;
            Vector2 pointInRectangleSpace = point - Position;
            return Math.Abs(pointInRectangleSpace.X) < halfWidth && Math.Abs(pointInRectangleSpace.Y) < halfHeight;
        }
    }
}
