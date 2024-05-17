using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slingshot.Items
{
    public class TransmuteEbonstone : GlobalItem
    {
        public override void AddRecipes()
        {
            Recipe recipe = Recipe.Create(ItemID.EbonstoneBlock);
            recipe.AddIngredient(ItemID.StoneBlock);
            recipe.Register();
            recipe.AddTile(Mod.Find<ModTile>("TransmutationStation").Type);
        }
    }
}
