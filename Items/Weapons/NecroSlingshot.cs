using Slingshot.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slingshot.Items.Weapons
{
    public class NecroSlingshot : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Necro Slingshot"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            // Tooltip.SetDefault("would cobwebs really work like this?");
        }

        public override void SetDefaults()
        {
            Item.damage = 18;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 50;
            Item.height = 50;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 5;
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
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Bone, 50);
            recipe.AddIngredient(ItemID.Cobweb, 50);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}