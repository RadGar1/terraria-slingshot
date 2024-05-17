using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Slingshot.Projectiles //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
    public class Unknown : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 10; //Set the hitbox width
            Projectile.height = 10; //Set the hitbox height
            Projectile.timeLeft = 300; //The amount of time the projectile is alive for
            Projectile.penetrate = -1; //Tells the game how many enemies it can hit before being destroyed
            Projectile.friendly = true; //Tells the game whether it is friendly to players/friendly npcs or not
            Projectile.hostile = false; //Tells the game whether it is hostile to players or not
            Projectile.tileCollide = true; //Tells the game whether or not it can collide with a tile
            Projectile.ignoreWater = true; //Tells the game whether or not projectile will be affected by water
            Projectile.DamageType = DamageClass.Ranged; //Tells the game whether it is a ranged projectile or not
            Projectile.aiStyle = 0; //How the projectile works, this is no AI, it just goes a straight path
            Projectile.light = 2f;


        }
        public override void AI()
        {
            Vector2 velo = new Vector2(0f, 0f);
            Vector2 provelo = new Vector2(4f, 0f);
            // Trying to find NPC closest to the projectile
            Vector2 bulletVelocity = provelo.RotateRandom(MathHelper.ToRadians(360f));
            Projectile.velocity = velo;


            // If found, change the velocity of the projectile and turn it in the direction of the target
            // Use the SafeNormalize extension method to avoid NaNs returned by Vector2.Normalize when the vector is zero
            //Vector2 bulletVelocity = (closestNPC.Center - Projectile.Center).SafeNormalize(Vector2.Zero) * projSpeed;
            //Projectile.rotation = Projectile.velocity.ToRotation();
            // Spawn a new projectile with the newly rotated velocity, belonging to the original projectile owner. The new projectile will inherit the spawning source of this projectile.
            //make it so it spawns a projectile that goes towards the nearest npc
            if (Projectile.timeLeft % 10 == 0)
            {


                Projectile.NewProjectile(Projectile.GetSource_FromThis(), Projectile.Center, bulletVelocity, ModContent.ProjectileType<flyingRock>(), Projectile.damage, Projectile.knockBack, Projectile.owner);

            }
        }

    }
}