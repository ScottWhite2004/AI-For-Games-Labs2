using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_For_Games_Lab.Shapes
{
    internal abstract class Shape
    {
        public Vector2 Position { get; protected set; }
        public Color Colour;

        public Shape(Vector2 pPosition, Color pColour)
        {
            Position = pPosition;
            Colour = pColour;
        }

        public abstract bool isInside(Vector2 point);




    }
}
