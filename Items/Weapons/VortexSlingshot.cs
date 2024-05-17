using Microsoft.Xna.Framework;
using Slingshot.Projectiles;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;


namespace Slingshot.Items.Weapons
{
    public class VortexSlingshot : ModItem
    {

        public override void SetStaticDefaults()
        {
            //DisplayName.SetDefault("Vortex Slingshot"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            //Tooltip.SetDefault("filled with spiral energy");

        }

        public override void SetDefaults()
        {
            Item.damage = 70;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 50;
            Item.height = 50;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 5;
            Item.value = 10000;
            Item.rare = ItemRarityID.Green;
            Item.autoReuse = true;
            Item.noMelee = true;
            Item.useAmmo = AmmoID.Snowball;
            Item.shoot = ModContent.ProjectileType<flyingRock>();
            Item.shoot = ModContent.ProjectileType<floatingRock>();
            Item.shoot = ModContent.ProjectileType<sharpObsidian>();
            Item.shoot = ModContent.ProjectileType<goldenProjectile>();
        }


        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                return player.ownedProjectileCounts[ModContent.ProjectileType<vortePorte>()] < 1;
            }
            else
            {
                return true;
            }

        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback) // something is wrong here?
        {
            if (player.altFunctionUse == 2)
            {

                Projectile.NewProjectile(source, player.position, velocity / 4, ModContent.ProjectileType<vortePorte>(), damage, knockback);
                return false;

            }
            else
            {
                return true;
            }
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.FragmentVortex, 18);
            recipe.AddTile(TileID.LunarCraftingStation); // change to ancient manipulator eventually
            recipe.Register();
        }
    }
}