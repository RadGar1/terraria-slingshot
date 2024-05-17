using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slingshot.Items.Ammos
{
    public class AngryBird : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Hal");
            // Tooltip.SetDefault("");
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
            Item.shoot = Mod.Find<ModProjectile>("BoomerangBird").Type;

        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe(5);
            recipe.AddIngredient(ItemID.Feather, 1);
            recipe.AddIngredient(ItemID.StoneBlock, 1);
            recipe.Register();
        }
    }
}