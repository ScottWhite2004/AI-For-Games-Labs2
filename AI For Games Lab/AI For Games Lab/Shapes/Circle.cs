using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_For_Games_Lab.Shapes
{
    internal class Circle : Shape
    {
        public float radius;
        
        public Circle(Vector2 pPosition, Color pColour, float pRadius) : base(pPosition, pColour)
        {
            radius = pRadius;
        
        }

        public override bool isInside(Vector2 point)
        {
            return (point - Position).LengthSquared() < radius * radius;
        }
    }
}
