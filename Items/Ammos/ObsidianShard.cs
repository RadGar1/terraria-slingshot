using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slingshot.Items.Ammos
{
    public class ObsidianShard : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Obsidian Shard");
            // Tooltip.SetDefault("as it is volcanic glass it is quite fragile");
        }
        public override void SetDefaults()
        {
            Item.width = 12;
            Item.height = 12;
            Item.rare = ItemRarityID.Gray;
            Item.maxStack = 999;
            Item.shootSpeed = 10f;
            Item.ammo = AmmoID.Snowball;
            Item.damage = 12;
            Item.DamageType = DamageClass.Ranged;
            Item.consumable = true;
            Item.shoot = Mod.Find<ModProjectile>("sharpObsidian").Type;

        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe(50);
            recipe.AddIngredient(ItemID.Obsidian, 1);
            recipe.Register();
        }
    }
}