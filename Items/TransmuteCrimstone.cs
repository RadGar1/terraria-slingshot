using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slingshot.Items
{
    public class TransmuteCrimstone : GlobalItem
    {
        public override void AddRecipes()
        {
            Recipe recipe = Recipe.Create(ItemID.CrimstoneBlock);
            recipe.AddIngredient(ItemID.StoneBlock);
            recipe.Register();
            recipe.AddTile(Mod.Find<ModTile>("TransmutationStation").Type);
        }
    }
}
