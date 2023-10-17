using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_For_Games_Lab.Shapes
{
    internal class Polygon : Shape
    {
        public List<Triangle> Triangles {  get; protected set; }
        
        
        public Polygon(Vector2 pPosition, Color pColour, List<Vector2> points) : base(pPosition, pColour)
        {
        for(int i = 2; i < points.Count; i++)
            {
                Triangles.Add(new Triangle(points[i - 2], pColour, points[i - 1], points[i]));
            }
        
        
        }

        public override bool isInside(Vector2 point)
        {
            for(int i = 0; i < Triangles.Count; i++)
            {
                if (Triangles[i].isInside(point)) return true;
            }

            return false;
        }
    }
}
