using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slingshot.Items.Ammos
{
    public class GraniteRock : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("granite piece");
            // Tooltip.SetDefault("slow moving, not affected by gravity");
        }
        public override void SetDefaults()
        {
            Item.ammo = AmmoID.Snowball;
            Item.damage = 8;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 4;
            Item.height = 4;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.knockBack = 1f;
            Item.value = 10;
            Item.rare = ItemRarityID.Green;
            Item.shoot = Mod.Find<ModProjectile>("floatingRock").Type;
            Item.shootSpeed = 3f;


        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe(5);
            recipe.AddIngredient(ItemID.Granite, 1);
            recipe.Register();

        }
    }
}