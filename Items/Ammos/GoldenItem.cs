using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slingshot.Items.Ammos
{
    public class GoldenItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Golden Ball");
            // Tooltip.SetDefault("get your head out of the gutter");
        }
        public override void SetDefaults()
        {
            Item.width = 12;
            Item.height = 12;
            Item.rare = ItemRarityID.Gray;
            Item.maxStack = 999;
            Item.shootSpeed = 7f;
            Item.ammo = AmmoID.Snowball;
            Item.damage = 12;
            Item.DamageType = DamageClass.Ranged;
            Item.consumable = true;
            Item.shoot = Mod.Find<ModProjectile>("goldenProjectile").Type;

        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe(5);
            recipe.AddIngredient(ItemID.Obsidian, 1);
            recipe.Register();
        }
    }
}