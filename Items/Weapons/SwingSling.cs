using Slingshot.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slingshot.Items.Weapons
{
    public class SwingSling : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Swing Sling"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            // Tooltip.SetDefault("good up close");
        }

        public override void SetDefaults()
        {
            Item.damage = 10;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.noMelee = false;
            Item.knockBack = 6;
            Item.value = 10000;
            Item.rare = ItemRarityID.Green;
            Item.autoReuse = false;
            Item.useAmmo = AmmoID.Snowball;
            Item.shoot = ModContent.ProjectileType<flyingRock>();
            Item.shoot = ModContent.ProjectileType<floatingRock>();
            Item.shoot = ModContent.ProjectileType<sharpObsidian>();
            Item.shoot = ModContent.ProjectileType<goldenProjectile>();
        }




        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 30);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}