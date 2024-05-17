﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slingshot.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class ShroomiteGoggles : ModItem
    //shroomite visor??
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Shroomite Goggles");
            // Tooltip.SetDefault("15% increased slingshot damage \n5% increased ranged critical strike chance");
        }

        public override void SetDefaults()
        {
            Item.height = 18;
            Item.width = 18;
            Item.defense = 11;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemID.ShroomiteBreastplate && legs.type == ItemID.ShroomiteLeggings;
        }

        public override void UpdateArmorSet(Player player)
        {
            /*
            Not moving puts you in stealth,
            increasing ranged ability and reducing chance for enemies to target you
            */
        }

        public override void UpdateEquip(Player player)
        {
            player.GetDamage(DamageClass.Ranged) += 0.15f;
            player.GetCritChance(DamageClass.Ranged) += 0.5f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.ShroomiteBar, 12);
            recipe.Register();
        }
    }
}
