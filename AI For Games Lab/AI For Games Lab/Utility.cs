using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_For_Games_Lab
{
    internal static class Utility
    {
        public static Vector2 FlipY(this Vector2 pVector, float pScreenHeight)
        {
            pVector.Y = pScreenHeight * (1f - (pVector.Y / pScreenHeight));
            return pVector;
        }



    }
}
