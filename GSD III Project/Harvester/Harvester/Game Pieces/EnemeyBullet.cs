﻿//Extends bullet
//@author: Peter O'Neal
// Version:
//       $1.0.1$
//       used for generating enemy bullets
//
//+
//
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Harvester
{
    public class EnemyBullet : Bullet
    {
        public EnemyBullet(Rectangle rect, Texture2D eBulletTexture, double speed, int dmg)
            : base(rect, eBulletTexture, speed, dmg)
        {

        }
    }
}
