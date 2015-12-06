using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace PongGame
{
    public class CollisionDetector
    { 
        /// <summary> 
        /// Calculates if rectangles describing two sprites 
        /// are overlapping on screen. 
        /// </summary> 
        /// <param name="s1">First sprite</param> 
        /// <param name="s2">Second sprite</param> 
        /// <returns>Returns true if overlapping</returns>
        public static bool Overlaps(Sprite s1, Sprite s2) 
        {
            Rectangle s1Position = new Rectangle((int)s1.Position.X, (int)s1.Position.Y, (int)s1.Size.Width, (int)s1.Size.Height);
            Rectangle s2Position = new Rectangle((int)s2.Position.X, (int)s2.Position.Y, (int)s2.Size.Width, (int)s2.Size.Height);

            if (s2Position.Intersects(s1Position))
            
                return true;
            else return false;

            
            
                
                /*(
                ( ((s1.Position.X + s1.Size.Width/2) > s2.Position.X) && ((s1.Position.X + s1.Size.Width/2) < (s2.Position.X + s2.Size.Width)) )
                &&
                ( ((s1.Position.Y + s1.Size.Height) > s2.Position.Y) || (s1.Position.Y < (s2.Position.Y + s2.Size.Height)) )
                )*/
                /*
            if (s1.Position.Y.Equals(s2.Position.Y)) return true;
            else return false;*/
        }
    }
}
