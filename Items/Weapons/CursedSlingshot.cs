using Microsoft.Xna.Framework;
using Slingshot.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slingshot.Items.Weapons
{
    public class CursedSlingshot : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Cursed Slingshot"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            // Tooltip.SetDefault("It feels...alive");
        }

        public override void SetDefaults()
        {
            Item.damage = 38;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 8;
            Item.value = 10000;
            Item.rare = ItemRarityID.Green;
            Item.autoReuse = false;
            Item.noMelee = true;
            Item.useAmmo = AmmoID.Snowball;
            Item.shoot = ModContent.ProjectileType<flyingRock>();
            Item.shoot = ModContent.ProjectileType<floatingRock>();
            Item.shoot = ModContent.ProjectileType<sharpObsidian>();
            Item.shoot = ModContent.ProjectileType<goldenProjectile>();
        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            if (type == ModContent.ProjectileType<flyingRock>() || type == ModContent.ProjectileType<flyingRock2>())
            {
                type = ModContent.ProjectileType<cursedflameRock>();
            }
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.WormTooth, 2);
            recipe.AddIngredient(ItemID.CursedFlame, 15);
            recipe.AddIngredient(ItemID.SoulofNight, 15);
            recipe.AddIngredient(ItemID.RottenChunk, 20);
            recipe.AddTile(TileID.MythrilAnvil);
        }
    }
}