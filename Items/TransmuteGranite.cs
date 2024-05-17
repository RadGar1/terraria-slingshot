using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slingshot.Items
{
    public class TransmuteGranite : GlobalItem
    {
        public override void AddRecipes()
        {
            Recipe recipe = Recipe.Create(ItemID.Granite);
            recipe.AddIngredient(ItemID.StoneBlock);
            recipe.Register();
            recipe.AddTile(Mod.Find<ModTile>("TransmutationStation").Type);
        }
    }
}
