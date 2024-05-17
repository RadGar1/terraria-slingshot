using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slingshot.Items
{
    internal class ShadeChest : ModSystem
    {
        public override void PostWorldGen()
        {
            //shadow chest = 4
            for (int chestIndex = 0; chestIndex < 1000; chestIndex++)
            {
                Chest chest = Main.chest[chestIndex];
                int[] itemToPlaceInChest = { Mod.Find<ModItem>("shadowflameSling").Type };
                int shadowflameAmount = 1;

                if (chest != null && Main.tile[chest.x, chest.y].TileType == TileID.Containers && Main.tile[chest.x, chest.y].TileFrameX == 4 * 36)
                {
                    for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++)
                    {
                        if (chest.item[inventoryIndex].type == 0 && chestIndex % 3 == 0)
                        {
                            chest.item[inventoryIndex].SetDefaults(itemToPlaceInChest[0]);
                            chest.item[inventoryIndex].stack = shadowflameAmount;
                            break;
                        }
                    }
                }
            }
        }
    }
}
