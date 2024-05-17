using Terraria;
using Terraria.ModLoader;

namespace Slingshot.Projectiles
{
    internal class modBullet : ModProjectile
    {
        public override void SetDefaults()
        {
            Projectile.width = 12; //Set the hitbox width
            Projectile.height = 2; //Set the hitbox height
            Projectile.timeLeft = 360; //The amount of time the projectile is alive for
            Projectile.penetrate = 1; //Tells the game how many enemies it can hit before being destroyed
            Projectile.friendly = true; //Tells the game whether it is friendly to players/friendly npcs or not
            Projectile.hostile = false; //Tells the game whether it is hostile to players or not
            Projectile.tileCollide = true; //Tells the game whether or not it can collide with a tile
            Projectile.ignoreWater = false; //Tells the game whether or not projectile will be affected by water
            Projectile.DamageType = DamageClass.Ranged; //Tells the game whether it is a ranged projectile or not
            Projectile.aiStyle = 0; //How the projectile works, this is no AI, it just goes a straight path
            Projectile.light = 0.5f;
        }

        public override void AI()
        {
            Projectile.rotation = Projectile.velocity.ToRotation();
        }
        public override void Kill(int timeLeft)
        {
            if (timeLeft < 20)
            {
                Projectile.tileCollide = false;
            }
        }
    }
}
