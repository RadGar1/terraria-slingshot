using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slingshot.Items.Ammos
{
    public class SandRock : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("SandRock");
            // Tooltip.SetDefault("nature's bullets");
        }
        public override void SetDefaults()
        {
            Item.width = 12;
            Item.height = 12;
            Item.rare = ItemRarityID.Gray;
            Item.maxStack = 999;
            Item.ammo = AmmoID.Snowball;
            Item.damage = 8;
            Item.shootSpeed = 10f;
            Item.DamageType = DamageClass.Ranged;
            Item.consumable = true;
            Item.shoot = Mod.Find<ModProjectile>("splittingRock").Type;

        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe(5);
            recipe.AddIngredient(ItemID.StoneBlock, 1);
            recipe.Register();
        }
    }
}