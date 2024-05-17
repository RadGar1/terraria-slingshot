using Slingshot.Items.Weapons;
using Slingshot.Projectiles;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Utilities;

namespace Slingshot.NPCs
{
    public class PirateSniper : ModNPC
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Pirate Sniper");
            Main.npcFrameCount[NPC.type] = Main.npcFrameCount[NPCID.Zombie];
        }

        public override void SetDefaults()
        {
            NPC.width = 20;
            NPC.height = 40;
            NPC.lifeMax = 400;
            NPC.damage = 18;
            NPC.defense = 20;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.value = 100f;
            NPC.knockBackResist = 0.75f;
            NPC.aiStyle = 3;
            AIType = NPCID.PirateCorsair;
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.Pirates.Chance * 0.2f;
        }

        public int AI_Timer = 0;
        public int downTime = 240;
        public override void AI()
        {
            AI_Timer++;
            Player player = Main.player[NPC.target];

            if (Math.Abs(NPC.Center.X - player.Center.X) < 16f * 30f && Math.Abs(NPC.Center.Y - player.Center.Y) < 16f * 20f)
            {
                // if (NPC.AnyInteractions()){ maake him run away like a bitch }
                //NPC.FindClosestPlayer(player);

                //make npc stop
                if (AI_Timer > downTime)
                {


                    Projectile.NewProjectile(NPC.GetSource_FromAI(), NPC.Center.X + (8f * NPC.direction), NPC.Center.Y - 6f, (player.position.X - NPC.position.X) / 10, (player.position.Y - NPC.position.Y) / 10, ModContent.ProjectileType<flyingRock>(), 60, 10f, Main.myPlayer);
                    AI_Timer = 0;
                }
            }

        }

        public override void OnKill()
        {
            if (Main.rand.NextBool(3))
            {
                Item.NewItem(Item.GetSource_NaturalSpawn(), NPC.position, ModContent.ItemType<KabutoSlingshot>());

            }
        }
    }
}