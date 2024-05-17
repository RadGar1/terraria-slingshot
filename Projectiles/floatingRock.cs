﻿using Microsoft.Xna.Framework;
using Slingshot.Items.Ammos;
using Terraria;
using Terraria.ModLoader;

namespace Slingshot.Projectiles //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
    public class floatingRock : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.Name = "floating rock"; //Name of the projectile, only shows this if you get killed by it
            Projectile.width = 8; //Set the hitbox width
            Projectile.height = 8; //Set the hitbox height
            Projectile.timeLeft = 999; //The amount of time the projectile is alive for
            Projectile.penetrate = 3; //Tells the game how many enemies it can hit before being destroyed
            Projectile.friendly = true; //Tells the game whether it is friendly to players/friendly npcs or not
            Projectile.hostile = false; //Tells the game whether it is hostile to players or not
            Projectile.tileCollide = true; //Tells the game whether or not it can collide with a tile
            Projectile.ignoreWater = true; //Tells the game whether or not projectile will be affected by water
            Projectile.DamageType = DamageClass.Ranged; //Tells the game whether it is a ranged projectile or not
            Projectile.aiStyle = 0; //How the projectile works, this is no AI, it just goes a straight path
            Projectile.light = 1f;

            DrawOffsetX = -5;
            DrawOriginOffsetY = -5;
        }
        public override void AI()
        {

            float velRotation = Projectile.velocity.X;
            Projectile.rotation += velRotation * MathHelper.ToRadians(3f);
            Projectile.velocity *= 0.99f;
        }
        public override void Kill(int timeleft)
        {
            if (Projectile.owner == Main.myPlayer)
            {
                // Drop a javelin item, 1 in 18 chance (~5.5% chance)
                int item =
                Main.rand.NextBool(4)
                    ? Item.NewItem(Item.GetSource_NaturalSpawn(), Projectile.position, ModContent.ItemType<GraniteRock>())
                    : 0;
            }
        }
    }
}