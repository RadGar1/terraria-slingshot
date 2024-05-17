using Slingshot.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slingshot.Items.Ammos
{
    public class RockBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Endless Rock Bag");
            // Tooltip.SetDefault("dumber than a bag of rocks");
        }
        public override void SetDefaults() //make it shoot different projectiles that don't drop items
        {
            Item.width = 12;
            Item.height = 12;
            Item.rare = ItemRarityID.Gray;
            Item.maxStack = 1;
            Item.shootSpeed = 10f;
            Item.ammo = AmmoID.Snowball;
            Item.damage = 8;
            Item.DamageType = DamageClass.Ranged;
            Item.consumable = false;
            Item.shoot = ModContent.ProjectileType<flyingRock2>();

        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<Rock>(), 3996);
            recipe.AddTile(TileID.CrystalBall);
            recipe.Register();
        }
    }
}