﻿/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Slingshot.Items.Weapons;

namespace Slingshot.Items.Ammos
{
    public class petRock : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Pet Rock");
            // Tooltip.SetDefault("he wants to be like you when he grows up");
        }
        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 24;
            Item.rare = ItemRarityID.Gray;
            Item.maxStack = 999;
            Item.shootSpeed = 10f;
            Item.ammo = AmmoID.Snowball;
            Item.damage = 8;
            Item.DamageType = DamageClass.Ranged;
            Item.consumable = true;
            Item.shoot = Mod.Find<ModProjectile>("livingRock").Type;

        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe(5);
            recipe.AddIngredient(ItemID.StoneBlock, 1);
            recipe.Register();
        }
    }
}*/