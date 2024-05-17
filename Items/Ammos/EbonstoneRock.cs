using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slingshot.Items.Ammos
{
    public class EbonstoneRock : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Ebonstone Rock");
            // Tooltip.SetDefault("corruption's bullets");
        }
        public override void SetDefaults()
        {
            Item.width = 12;
            Item.height = 12;
            Item.rare = ItemRarityID.Gray;
            Item.maxStack = 999;
            Item.shootSpeed = 5f;
            Item.ammo = AmmoID.Snowball;
            Item.damage = 8;
            Item.DamageType = DamageClass.Ranged;
            Item.consumable = true;
            Item.shoot = Mod.Find<ModProjectile>("cursedflameRock").Type;

        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe(5);
            recipe.AddIngredient(ItemID.EbonstoneBlock, 1);
            recipe.Register();
        }
    }
}
