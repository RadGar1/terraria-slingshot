using Microsoft.Xna.Framework;
using Slingshot.Projectiles;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Slingshot.Items.Weapons
{
    public class Slinginator3000 : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Slinginator 3000"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            //Tooltip.SetDefault("Terror of the Tristate Area");
        }


        public override void SetDefaults()
        {
            Item.damage = 45;
            Item.DamageType = DamageClass.Ranged;
            Item.width = 30;
            Item.height = 40;
            Item.useTime = 20;
            Item.useAnimation = 15;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.knockBack = 3;
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
                return (player.ownedProjectileCounts[ModContent.ProjectileType<Unknown2>()] + player.ownedProjectileCounts[ModContent.ProjectileType<SlinginatorLaser>()]) < 1;
            }
            else
            {
                return true;
            }

        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            if (player.altFunctionUse == 2)
            {
                int proj = Projectile.NewProjectile(source, position, velocity, ModContent.ProjectileType<SlinginatorLaser>(), 50, 3f, player.whoAmI);
                Main.projectile[proj].friendly = true;
                Main.projectile[proj].hostile = false;
                return false;
            }
            return true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<Slinginator>());
            recipe.AddIngredient(ItemID.MartianConduitPlating, 50);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}