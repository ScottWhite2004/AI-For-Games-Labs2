using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_For_Games_Lab.Shapes
{
    internal class Triangle : Shape
    {
        public Vector2 Point2 { get; protected set; }
        public Vector2 Point3 { get; protected set; }
        
        
        public Triangle(Vector2 pPosition, Color pColour, Vector2 pPoint2, Vector2 pPoint3) : base(pPosition, pColour)
        {
            Point2 = pPoint2;
            Point3 = pPoint3;
        
        }

        public override bool isInside(Vector2 point)
        {
            float Px = point.X - Position.X,
                Py = point.Y - Position.Y,
                V1x = Point2.X - Position.X,
                V1y = Point2.Y - Position.Y,
                V2x = Point3.X - Position.X,
                V2y = Point3.Y - Position.Y;

            float n = (Py * V1x - Px * V1y) / (V2y * V1x - V2x * V1y);
            float m = (Px - n * V2x) / V1x;

            return m > 0 && m < 1 && n > 0 && n < 1 && m + n < 1;
        }
    }
}
