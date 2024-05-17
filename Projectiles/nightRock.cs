﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slingshot.Projectiles //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
    public class nightRock : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 8; //Set the hitbox width
            Projectile.height = 8; //Set the hitbox height
            Projectile.timeLeft = 999; //The amount of time the projectile is alive for
            Projectile.penetrate = 3; //Tells the game how many enemies it can hit before being destroyed
            Projectile.friendly = true; //Tells the game whether it is friendly to players/friendly npcs or not
            Projectile.hostile = false; //Tells the game whether it is hostile to players or not
            Projectile.tileCollide = true; //Tells the game whether or not it can collide with a tile
            Projectile.ignoreWater = false; //Tells the game whether or not projectile will be affected by water
            Projectile.DamageType = DamageClass.Ranged; //Tells the game whether it is a ranged projectile or not
            Projectile.aiStyle = 2; //How the projectile works, this is no AI, it just goes a straight path
            //Projectile.light = 0f; //make purple

        }

        public override void AI()
        {
            Dust.NewDust(Projectile.Center, 1, 1, DustID.DemonTorch, 0f, 0f, 0, default(Color), 1f);
        }
    }
}