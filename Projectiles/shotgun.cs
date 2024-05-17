using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slingshot.Projectiles //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
    public class shotgun : ModProjectile
    {
        public override void SetDefaults()
        {

            Projectile.width = 12; //Set the hitbox width
            Projectile.height = 8; //Set the hitbox height
            Projectile.timeLeft = 60; //The amount of time the projectile is alive for
            Projectile.penetrate = 1; //Tells the game how many enemies it can hit before being destroyed
            Projectile.friendly = true; //Tells the game whether it is friendly to players/friendly npcs or not
            Projectile.hostile = false; //Tells the game whether it is hostile to players or not
            Projectile.tileCollide = true; //Tells the game whether or not it can collide with a tile
            Projectile.ignoreWater = false; //Tells the game whether or not projectile will be affected by water
            Projectile.DamageType = DamageClass.Ranged; //Tells the game whether it is a ranged projectile or not
            Projectile.aiStyle = 2; //How the projectile works, this is no AI, it just goes a straight path
            Projectile.light = 0f;

        }

        public bool OnTileCollide() //Something is wrong here
        {
            return true;
        }
        public override void Kill(int timeLeft)
        {

            float maxDetectRadius = 400f; // The maximum radius at which a projectile can detect a target
            float projSpeed = 20f; // The speed at which the projectile moves towards the target

            // Trying to find NPC closest to the projectile
            NPC closestNPC = FindClosestNPC(maxDetectRadius);

            Vector2 launchVelocity;
            for (int i = 0; i < 5; i++)
            {

                if (closestNPC == null)
                {
                    launchVelocity = -Projectile.velocity.RotatedByRandom(MathHelper.ToRadians(-30f + 20f * i));
                    Projectile.NewProjectile(Projectile.GetSource_FromThis(), Projectile.Center, launchVelocity, ProjectileID.Bullet, Projectile.damage, Projectile.knockBack, Projectile.owner);
                }
                else
                {
                    Vector2 bulletVelocity = (closestNPC.Center - Projectile.Center).SafeNormalize(Vector2.Zero) * projSpeed;
                    launchVelocity = bulletVelocity.RotatedByRandom(MathHelper.ToRadians(-30f + 20f * i));
                    Projectile.NewProjectile(Projectile.GetSource_FromThis(), Projectile.Center, launchVelocity, ModContent.ProjectileType<modBullet>(), Projectile.damage, Projectile.knockBack, Projectile.owner);
                }
            }
        }
        public NPC FindClosestNPC(float maxDetectDistance)
        {
            NPC closestNPC = null;
            float sqrMaxDetectDistance = maxDetectDistance * maxDetectDistance;
            for (int k = 0; k < Main.maxNPCs; k++)
            {
                NPC target = Main.npc[k];

                if (target.CanBeChasedBy())
                {
                    float sqrDistanceToTarget = Vector2.DistanceSquared(target.Center, Projectile.Center);

                    if (sqrDistanceToTarget < sqrMaxDetectDistance && sqrDistanceToTarget > Vector2.DistanceSquared(target.Center, target.BottomRight))
                    {
                        sqrMaxDetectDistance = sqrDistanceToTarget;
                        closestNPC = target;
                    }
                }
            }

            return closestNPC;
        }
    }
}