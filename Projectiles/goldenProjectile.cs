using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Slingshot.Items.Ammos;
using Terraria;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slingshot.Projectiles
{
    public class goldenProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            ProjectileID.Sets.TrailCacheLength[Projectile.type] = 20; // The length of old position to be recorded
            ProjectileID.Sets.TrailingMode[Projectile.type] = 0;
        }
        public override void SetDefaults()
        {
            Projectile.Name = "Golden Ball"; //Name of the projectile, only shows this if you get killed by it
            Projectile.width = 4; //Set the hitbox width
            Projectile.height = 4; //Set the hitbox height
            Projectile.timeLeft = 400; //The amount of time the projectile is alive for
            Projectile.penetrate = 5; //Tells the game how many enemies it can hit before being destroyed
            Projectile.friendly = true; //Tells the game whether it is friendly to players/friendly npcs or not
            Projectile.hostile = false; //Tells the game whether it is hostile to players or not
            Projectile.tileCollide = true; //Tells the game whether or not it can collide with a tile
            Projectile.ignoreWater = false; //Tells the game whether or not projectile will be affected by water
            Projectile.DamageType = DamageClass.Ranged; //Tells the game whether it is a ranged projectile or not
            Projectile.aiStyle = 0; //How the projectile works, this is no AI, it just goes a straight path
            Projectile.light = 0.50f;
            Projectile.extraUpdates = 1;
        }
        int bounce = 0;
        int maxBounce = 10;
        public override bool OnTileCollide(Vector2 oldVelocity) //make it so this only provides light after bouncing
        {
            bounce++;
            for (int i = 0; i < 3; i++)
            {
                Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.Gold, 0f, 0f, 0, default(Color), 1f);
            }
            if (Projectile.velocity.X != oldVelocity.X) Projectile.velocity.X = -oldVelocity.X;
            if (Projectile.velocity.Y != oldVelocity.Y) Projectile.velocity.Y = -oldVelocity.Y;
            Projectile.aiStyle = 0;

            if (bounce >= maxBounce) return true;
            else return false;
        }
        public override bool PreDraw(ref Color lightColor)
        {
            Main.instance.LoadProjectile(Projectile.type);
            Texture2D texture = TextureAssets.Projectile[Projectile.type].Value;
            //Texture2D texture = Texture

            // Redraw the projectile with the color not influenced by light
            Vector2 drawOrigin = new Vector2(texture.Width * 0.5f, Projectile.height * 0.5f);
            for (int k = 0; k < Projectile.oldPos.Length; k++)
            {
                Vector2 drawPos = (Projectile.oldPos[k] - Main.screenPosition) + drawOrigin + new Vector2(0f, Projectile.gfxOffY);
                Color color = Projectile.GetAlpha(lightColor) * ((Projectile.oldPos.Length - k) / (float)Projectile.oldPos.Length);
                Main.EntitySpriteDraw(texture, drawPos, null, color, Projectile.rotation, drawOrigin, Projectile.scale, SpriteEffects.None, 0);
            }

            return true;
        }
        public override void AI()
        {
            Lighting.Brightness(1, 1);
        }
        public override void Kill(int timeleft)
        {
            if (Projectile.owner == Main.myPlayer)
            {
                // Drop a javelin item, 1 in 18 chance (~5.5% chance)
                int item =
                Main.rand.NextBool(4)
                    ? Item.NewItem(Item.GetSource_NaturalSpawn(), Projectile.position, ModContent.ItemType<GoldenItem>())
                    : 0;
            }
        }
    }
}