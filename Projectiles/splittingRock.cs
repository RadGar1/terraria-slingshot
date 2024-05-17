using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace Slingshot.Projectiles
{
    public class splittingRock : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.Name = "splittingRock";
            Projectile.width = 8;
            Projectile.height = 8;
            Projectile.timeLeft = 999;
            Projectile.penetrate = 1;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.tileCollide = true;
            Projectile.ignoreWater = false;
            Projectile.DamageType = DamageClass.Ranged;
            Projectile.aiStyle = 2;
            Projectile.light = 0f;

        }
        public override void OnSpawn(IEntitySource source)
        {
            if (Projectile.ai[1] == 0)
            {
                float numberProjectiles = 2; // 2 shots

                for (int i = 0; i < numberProjectiles; i++)
                {

                    Vector2 vel = Projectile.velocity.RotatedBy(MathHelper.ToRadians(-15 + 30 * i));
                    Projectile.NewProjectile(Projectile.GetSource_NaturalSpawn(), Projectile.Center, vel, Projectile.type, Projectile.damage, Projectile.knockBack, Projectile.owner, 0, 1); //Creates a new projectile with our new vector for spread.
                }
            }
        }
    }
}