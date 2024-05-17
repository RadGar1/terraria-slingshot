using Microsoft.Xna.Framework;
using Slingshot.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slingshot.Items.Weapons
{
    public class SpectralSlingshot : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Spectral Slingshot"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            // Tooltip.SetDefault("turns rocks into homing projectiles");
        }

        public override void SetDefaults()
        {
            Item.damage = 45;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 30;
            Item.height = 40;
            Item.useTime = 20;
            Item.useAnimation = 15;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 3;
            Item.value = 10000;
            Item.rare = ItemRarityID.Green;
            Item.autoReuse = true;
            Item.noMelee = true;
            Item.useAmmo = AmmoID.Snowball;
            Item.shoot = ModContent.ProjectileType<floatingRock>();
            Item.shoot = ModContent.ProjectileType<sharpObsidian>();
            Item.shoot = ModContent.ProjectileType<goldenProjectile>();

        }

        public override void ModifyShootStats(Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            if (type == ModContent.ProjectileType<flyingRock>() || type == ModContent.ProjectileType<flyingRock2>())
            {
                type = ModContent.ProjectileType<rockSpirit>();
            }
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Bone, 12);
            recipe.AddIngredient(ItemID.Ectoplasm, 20);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}