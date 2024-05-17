using Slingshot.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slingshot.Items.Ammos
{
    public class CrimstoneRock : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("crimstoneRock");
            // Tooltip.SetDefault("crimson's bullets");
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
            Item.shoot = ModContent.ProjectileType<ichorRock>();

        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe(5);
            recipe.AddIngredient(ItemID.CrimstoneBlock, 1);
            recipe.Register();
        }
    }
}
