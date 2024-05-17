/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Slingshot.Items.Ammos
{
    internal class GraveRock : ModItem
    {
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("tomb piece");
			// Tooltip.SetDefault("rises up from the ground");
		}
		public override void SetDefaults()
		{
			Item.ammo = AmmoID.Snowball;
			Item.damage = 8;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 4;
			Item.height = 4;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.knockBack = 1f;
			Item.value = 10;
			Item.rare = ItemRarityID.Green;
			Item.shoot = Mod.Find<ModProjectile>("groundRock").Type;
			Item.shootSpeed = 1f;


		}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe(5);
			recipe.AddIngredient(ItemID.Tombstone, 1);
			recipe.Register();
		}
	}
}
*/