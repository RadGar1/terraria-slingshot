using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slingshot.Items
{
    public class TransmutationItem : ModItem
    {
        public override void SetDefaults()
        {
            Item.height = 8;
            Item.width = 8;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 10;
            Item.useAnimation = 10;
            Item.createTile = Mod.Find<ModTile>("TransmutationStation").Type;
            Item.autoReuse = true;
        }
    }
}