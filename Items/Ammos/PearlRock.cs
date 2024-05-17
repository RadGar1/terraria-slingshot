using Slingshot.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slingshot.Items.Ammos
{
    public class PearlRock : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("PearlRock");
            // Tooltip.SetDefault("nature's light bullets");
        }
        public override void SetDefaults()
        {
            Item.width = 12;
            Item.height = 12;
            Item.rare = ItemRarityID.Gray;
            Item.maxStack = 999;
            Item.shootSpeed = 10f;
            Item.ammo = AmmoID.Snowball;
            Item.damage = 8;
            Item.DamageType = DamageClass.Ranged;
            Item.consumable = true;
            Item.shoot = ModContent.ProjectileType<shinyRock>();

        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe(5);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 1);
            recipe.Register();
        }
    }
}