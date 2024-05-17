using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slingshot.Items.Ammos
{
    public class MarbleRock : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Marble Rock");
            // Tooltip.SetDefault("");
        }
        public override void SetDefaults()
        {
            Item.width = 12;
            Item.height = 12;
            Item.rare = ItemRarityID.Gray;
            Item.maxStack = 999;
            Item.shootSpeed = 3f;
            Item.ammo = AmmoID.Snowball;
            Item.damage = 10;
            Item.DamageType = DamageClass.Ranged;
            Item.consumable = true;
            Item.shoot = Mod.Find<ModProjectile>("rollingRock").Type;

        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe(5);
            recipe.AddIngredient(ItemID.Marble, 1);
            recipe.Register();
        }
    }
}
