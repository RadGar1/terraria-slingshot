using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slingshot.Items
{
    public class TransmutePearlstone : GlobalItem
    {
        public override void AddRecipes()
        {
            Recipe recipe = Recipe.Create(ItemID.PearlstoneBlock);
            recipe.AddIngredient(ItemID.StoneBlock);
            recipe.Register();
            recipe.AddTile(Mod.Find<ModTile>("TransmutationStation").Type);
        }
    }
}