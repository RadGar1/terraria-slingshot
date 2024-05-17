using Microsoft.Xna.Framework;
using Slingshot.Projectiles;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slingshot.Items.Weapons
{

    public class DawnAndDusk : ModItem
    {

        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Slingshot"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            // Tooltip.SetDefault("Every troublemaker has one.");
        }

        public override void SetDefaults()
        {
            Item.damage = 90;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 10;
            Item.useAnimation = 30;
            Item.reuseDelay = 32;
            Item.autoReuse = true;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 6;
            Item.value = 10000;
            Item.rare = ItemRarityID.Green;
            Item.autoReuse = true;
            Item.noMelee = true;
            Item.useAmmo = AmmoID.Snowball;
            Item.shoot = ModContent.ProjectileType<flyingRock>();
            Item.shoot = ModContent.ProjectileType<floatingRock>();
            Item.shoot = ModContent.ProjectileType<sharpObsidian>();
            Item.shoot = ModContent.ProjectileType<goldenProjectile>();

        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }


        public override bool CanConsumeAmmo(Item ammo, Player player)
        {
            if (player.altFunctionUse == 2)
            {
                return false;
            }
            return !(player.itemAnimation < Item.useAnimation - 2);
        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            if (type == ModContent.ProjectileType<flyingRock>() || type == ModContent.ProjectileType<flyingRock2>())
            {

                if (Main.dayTime)
                {
                    /*if (Main.eclipse)
					{

					}
					*/

                }
                if (!Main.dayTime)
                {
                    Vector2 perturbedSpeed = new Vector2(velocity.X, velocity.Y).RotatedByRandom(MathHelper.ToRadians(30));

                    Projectile.NewProjectile(Item.GetSource_FromThis(), position, perturbedSpeed, ModContent.ProjectileType<nightRock>(), damage, knockback);
                    /*perturbedSpeed = new Vector2(velocity.X, velocity.Y).RotatedByRandom(MathHelper.ToRadians(30));
                    Projectile.NewProjectile(Item.GetSource_FromThis(), position, perturbedSpeed, ModContent.ProjectileType<nightRock>(), damage, knockback);
                    perturbedSpeed = new Vector2(velocity.X, velocity.Y).RotatedByRandom(MathHelper.ToRadians(30));
                    Projectile.NewProjectile(Item.GetSource_FromThis(), position, perturbedSpeed, ModContent.ProjectileType<nightRock>(), damage, knockback);
					*/
                }
                return false;
            }

            /*if (player.altFunctionUse == 2)
            {

            }*/

            return true;
        }


        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 30);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.Register();
        }
    }
}