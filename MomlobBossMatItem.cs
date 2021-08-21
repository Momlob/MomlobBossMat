using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;
using MomlobBossMat.Items.Vanilla.Bosses;
using MomlobBossMat.Items.Vanilla.Events;
using MomlobBossMat.Items.Thorium;

namespace MomlobBossMat
{
    public class MomlobBossMat_Item : GlobalItem
    {
        public override void OpenVanillaBag(string context, Player player, int arg)
        {
            // Configs & Mod Calls
            int multiplier = (ModContent.GetInstance<MainConfig>().Multiplier);
            Mod thorium = ModLoader.GetMod("ThoriumMod");
            bool thorium_x = (thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium);



            // Bosses
            if (ModContent.GetInstance<MainConfig>().EnableBoss)
            {
                // King Slime
                if (context == "bossBag" && arg == ItemID.KingSlimeBossBag)
                {
                    player.QuickSpawnItem(ModContent.ItemType<GelidCrownshard>(), Main.rand.Next(12, 17) * multiplier);
                    player.QuickSpawnItem(ItemID.LesserHealingPotion, Main.rand.Next(5, 16));

                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.Solidifier);
                        NPCLoader.blockLoot.Add(ItemID.SlimySaddle);
                        NPCLoader.blockLoot.Add(ItemID.SlimeHook);
                        NPCLoader.blockLoot.Add(ItemID.SlimeGun);
                        NPCLoader.blockLoot.Add(ItemID.NinjaHood);
                        NPCLoader.blockLoot.Add(ItemID.NinjaShirt);
                        NPCLoader.blockLoot.Add(ItemID.NinjaPants);
                        if (thorium_x)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("ShinobiSlicer"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("TechniqueHiddenBlade"));
                        }
                    }
                }

                // Eye of Cthulhu
                if (context == "bossBag" && arg == ItemID.EyeOfCthulhuBossBag)
                {
                    player.QuickSpawnItem(ModContent.ItemType<ShatteredLens>(), Main.rand.Next(12, 17) * multiplier);
                    player.QuickSpawnItem(ItemID.LesserHealingPotion, Main.rand.Next(5, 16));

                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.CorruptSeeds);
                        NPCLoader.blockLoot.Add(ItemID.UnholyArrow);
                        NPCLoader.blockLoot.Add(ItemID.CrimsonSeeds);
                        NPCLoader.blockLoot.Add(ItemID.Binoculars);
                    }
                }

                // Eater of Worlds
                if (context == "bossBag" && arg == ItemID.EaterOfWorldsBossBag)
                {
                    player.QuickSpawnItem(ItemID.ShadowScale, Main.rand.Next(60, 81) * multiplier);
                    NPCLoader.blockLoot.Add(ItemID.ShadowScale);
                    player.QuickSpawnItem(ItemID.LesserHealingPotion, Main.rand.Next(5, 16));

                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.EatersBone);
                        if (thorium_x)
                            NPCLoader.blockLoot.Add(thorium.ItemType("EaterOfPain"));
                    }
                }

                // Brain of Cthulhu
                if (context == "bossBag" && arg == ItemID.BrainOfCthulhuBossBag)
                {
                    player.QuickSpawnItem(ItemID.TissueSample, Main.rand.Next(60, 81) * multiplier);
                    NPCLoader.blockLoot.Add(ItemID.TissueSample);
                    player.QuickSpawnItem(ItemID.LesserHealingPotion, Main.rand.Next(5, 16));

                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.BoneRattle);
                        if (thorium_x)
                            NPCLoader.blockLoot.Add(thorium.ItemType("TheStalker"));
                    }
                }

                // Queen Bee
                if (context == "bossBag" && arg == ItemID.QueenBeeBossBag)
                {
                    player.QuickSpawnItem(ItemID.BeeWax, Main.rand.Next(12, 17) * multiplier);
                    NPCLoader.blockLoot.Add(ItemID.BeeWax);
                    player.QuickSpawnItem(ItemID.BottledHoney, Main.rand.Next(5, 16));

                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.BeeKeeper);
                        NPCLoader.blockLoot.Add(ItemID.BeesKnees);
                        NPCLoader.blockLoot.Add(ItemID.BeeGun);
                        NPCLoader.blockLoot.Add(ItemID.Beenade);
                        NPCLoader.blockLoot.Add(ItemID.HoneyComb);
                        NPCLoader.blockLoot.Add(ItemID.HoneyedGoggles);
                        NPCLoader.blockLoot.Add(ItemID.Nectar);
                        NPCLoader.blockLoot.Add(ItemID.HiveWand);
                        NPCLoader.blockLoot.Add(ItemID.BeeHat);
                        NPCLoader.blockLoot.Add(ItemID.BeeShirt);
                        NPCLoader.blockLoot.Add(ItemID.BeePants);
                        if (thorium_x)
                            NPCLoader.blockLoot.Add(thorium.ItemType("SweetHeart"));
                    }
                }

                // Skeletron
                if (context == "bossBag" && arg == ItemID.SkeletronBossBag)
                {
                    player.QuickSpawnItem(ModContent.ItemType<CursedFragment>(), Main.rand.Next(12, 17) * multiplier);
                    player.QuickSpawnItem(ItemID.HealingPotion, Main.rand.Next(5, 16));

                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.SkeletronHand);
                        NPCLoader.blockLoot.Add(ItemID.BookofSkulls);
                        if (thorium_x)
                            NPCLoader.blockLoot.Add(thorium.ItemType("GuildsStaff"));
                    }
                }

                // Wall of Flesh
                if (context == "bossBag" && arg == ItemID.WallOfFleshBossBag)
                {
                    player.QuickSpawnItem(ModContent.ItemType<ShackledFlesh>(), Main.rand.Next(12, 17) * multiplier);
                    player.QuickSpawnItem(ItemID.HealingPotion, Main.rand.Next(5, 16));

                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.BreakerBlade);
                        NPCLoader.blockLoot.Add(ItemID.ClockworkAssaultRifle);
                        NPCLoader.blockLoot.Add(ItemID.LaserRifle);
                        NPCLoader.blockLoot.Add(ItemID.WarriorEmblem);
                        NPCLoader.blockLoot.Add(ItemID.RangerEmblem);
                        NPCLoader.blockLoot.Add(ItemID.SorcererEmblem);
                        NPCLoader.blockLoot.Add(ItemID.SummonerEmblem);
                        NPCLoader.blockLoot.Add(ItemID.Pwnhammer);
                        if (thorium_x)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("NinjaEmblem"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("BardEmblem"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("ClericEmblem"));
                        }
                    }
                }

                // The Twins
                if (context == "bossBag" && arg == ItemID.TwinsBossBag)
                {
                    player.QuickSpawnItem(ItemID.GreaterHealingPotion, Main.rand.Next(5, 16));
                }

                // Destroyer
                if (context == "bossBag" && arg == ItemID.DestroyerBossBag)
                {
                    player.QuickSpawnItem(ItemID.GreaterHealingPotion, Main.rand.Next(5, 16));
                }

                // Skeletron Prime
                if (context == "bossBag" && arg == ItemID.SkeletronPrimeBossBag)
                {
                    player.QuickSpawnItem(ItemID.GreaterHealingPotion, Main.rand.Next(5, 16));
                }

                // Plantera
                if (context == "bossBag" && arg == ItemID.PlanteraBossBag)
                {
                    player.QuickSpawnItem(ModContent.ItemType<VenusPetal>(), Main.rand.Next(12, 17) * multiplier);
                    player.QuickSpawnItem(ItemID.GreaterHealingPotion, Main.rand.Next(5, 16));

                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.Seedler);
                        NPCLoader.blockLoot.Add(ItemID.FlowerPow);
                        NPCLoader.blockLoot.Add(ItemID.VenusMagnum);
                        NPCLoader.blockLoot.Add(ItemID.GrenadeLauncher);
                        NPCLoader.blockLoot.Add(ItemID.RocketI);
                        NPCLoader.blockLoot.Add(ItemID.NettleBurst);
                        NPCLoader.blockLoot.Add(ItemID.LeafBlower);
                        NPCLoader.blockLoot.Add(ItemID.WaspGun);
                        NPCLoader.blockLoot.Add(ItemID.PygmyStaff);
                        NPCLoader.blockLoot.Add(ItemID.ThornHook);
                        NPCLoader.blockLoot.Add(ItemID.Seedling);
                        NPCLoader.blockLoot.Add(ItemID.TheAxe);
                        if (thorium_x)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("BudBomb"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("VuvuzelaRed"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("VuvuzelaYellow"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("VuvuzelaGreen"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("VuvuzelaBlue"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("VerdantOrnament"));
                        }
                    }
                }

                // Golem
                if (context == "bossBag" && arg == ItemID.GolemBossBag)
                {
                    player.QuickSpawnItem(ModContent.ItemType<AncientGear>(), Main.rand.Next(12, 17) * multiplier);
                    player.QuickSpawnItem(ItemID.GreaterHealingPotion, Main.rand.Next(5, 16));

                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.GolemFist);
                        NPCLoader.blockLoot.Add(ItemID.PossessedHatchet);
                        NPCLoader.blockLoot.Add(ItemID.Stynger);
                        NPCLoader.blockLoot.Add(ItemID.StyngerBolt);
                        NPCLoader.blockLoot.Add(ItemID.StaffofEarth);
                        NPCLoader.blockLoot.Add(ItemID.HeatRay);
                        NPCLoader.blockLoot.Add(ItemID.EyeoftheGolem);
                        NPCLoader.blockLoot.Add(ItemID.SunStone);
                        NPCLoader.blockLoot.Add(ItemID.Picksaw);
                    }
                }

                // Duke Fishron
                if (context == "bossBag" && arg == ItemID.FishronBossBag)
                {
                    player.QuickSpawnItem(ModContent.ItemType<FishronScale>(), Main.rand.Next(12, 17) * multiplier);
                    player.QuickSpawnItem(ItemID.GreaterHealingPotion, Main.rand.Next(5, 16));

                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.Flairon);
                        NPCLoader.blockLoot.Add(ItemID.Tsunami);
                        NPCLoader.blockLoot.Add(ItemID.RazorbladeTyphoon);
                        NPCLoader.blockLoot.Add(ItemID.BubbleGun);
                        NPCLoader.blockLoot.Add(ItemID.TempestStaff);
                        NPCLoader.blockLoot.Add(ItemID.FishronWings);
                        if (thorium_x)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("Brinefang"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("DukesRegalCarnyx"));
                        }
                    }
                }

                // Moon Lord
                if (context == "bossBag" && arg == ItemID.MoonLordBossBag)
                {
                    player.QuickSpawnItem(ItemID.LunarOre, Main.rand.Next(12, 17)*8 * multiplier);
                    NPCLoader.blockLoot.Add(ItemID.LunarOre);
                    player.QuickSpawnItem(ItemID.BottledHoney, Main.rand.Next(5, 16));

                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.Meowmere);
                        NPCLoader.blockLoot.Add(ItemID.StarWrath);
                        NPCLoader.blockLoot.Add(ItemID.Terrarian);
                        NPCLoader.blockLoot.Add(ItemID.SDMG);
                        NPCLoader.blockLoot.Add(ItemID.FireworksLauncher);
                        NPCLoader.blockLoot.Add(ItemID.LunarFlareBook);
                        NPCLoader.blockLoot.Add(ItemID.LastPrism);
                        NPCLoader.blockLoot.Add(ItemID.RainbowCrystalStaff);
                        NPCLoader.blockLoot.Add(ItemID.MoonlordTurretStaff);
                        NPCLoader.blockLoot.Add(ItemID.PortalGun);
                        if (thorium_x)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("AngelsEnd"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("SonicAmplifier"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("LifeAndDeath"));
                        }
                    }
                }

                // Thorium Bosses
                if (thorium_x)
                {
                    // Grand Thunderbird
                    if (context == "bossBag" && arg == thorium.ItemType("ThunderBirdBag"))
                    {
                        player.QuickSpawnItem(ModContent.ItemType<GaleTalon>(), Main.rand.Next(12, 17) * multiplier);
                        player.QuickSpawnItem(ItemID.LesserHealingPotion, Main.rand.Next(5, 16));

                        if (!ModContent.GetInstance<MainConfig>().OldDrops)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("ThunderTalon"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("TalonBurst"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("HatchlingStaff"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("Didgeridoo"));
                        }
                    }

                    // Queen Jellyfish
                    if (context == "bossBag" && arg == thorium.ItemType("JellyFishBag"))
                    {
                        player.QuickSpawnItem(ModContent.ItemType<GrimyCoral>(), Main.rand.Next(12, 17) * multiplier);
                        player.QuickSpawnItem(ItemID.HealingPotion, Main.rand.Next(5, 16));

                        if (!ModContent.GetInstance<MainConfig>().OldDrops)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("SparkingJellyBall"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("GiantGlowstick"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("BlunderBuss"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("JellyPondWand"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("ConchShell"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("QueensGlowstick"));
                        }
                    }

                    // Viscount
                    if (context == "bossBag" && arg == thorium.ItemType("CountBag"))
                    {
                        player.QuickSpawnItem(ModContent.ItemType<VampiresWing>(), Main.rand.Next(12, 17) * multiplier);
                        player.QuickSpawnItem(ItemID.HealingPotion, Main.rand.Next(5, 16));

                        if (!ModContent.GetInstance<MainConfig>().OldDrops)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("BatWing"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("GuanoGunner"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("VampireScepter"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("ViscountCane"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("DraculaFang"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("SonarCannon"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("BatScythe"));
                        }
                    }

                    // Granite Energy Storm
                    if (context == "bossBag" && arg == thorium.ItemType("GraniteBag"))
                    {
                        player.QuickSpawnItem(ModContent.ItemType<PetrifiedEnergy>(), Main.rand.Next(12, 17) * multiplier);
                        player.QuickSpawnItem(ItemID.HealingPotion, Main.rand.Next(5, 16));

                        if (!ModContent.GetInstance<MainConfig>().OldDrops)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("EnergyStormPartisan"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("EnergyStormBolter"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("EnergyProjector"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("BoulderProbe"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("ShockAbsorber"));
                        }
                    }

                    // Buried Champion
                    if (context == "bossBag" && arg == thorium.ItemType("HeroBag"))
                    {
                        player.QuickSpawnItem(ModContent.ItemType<AncientTriobol>(), Main.rand.Next(12, 17) * multiplier);
                        player.QuickSpawnItem(ItemID.HealingPotion, Main.rand.Next(5, 16));

                        if (!ModContent.GetInstance<MainConfig>().OldDrops)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("ChampionBlade"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("HeroTripleBow"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("ChampionBomberStaff"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("ChampionsGodHand"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("ChampionsBarrier"));
                        }
                    }

                    // Star Scouter
                    if (context == "bossBag" && arg == thorium.ItemType("ScouterBag"))
                    {
                        player.QuickSpawnItem(ModContent.ItemType<StarforgedPlating>(), Main.rand.Next(12, 17) * multiplier);
                        player.QuickSpawnItem(ItemID.HealingPotion, Main.rand.Next(5, 16));

                        if (!ModContent.GetInstance<MainConfig>().OldDrops)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("StarTrail"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("HitScanner"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("GaussSpark"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("DistressCaller"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("GaussKnife"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("Roboboe"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("StarRod"));
                        }
                    }

                    // Borean Strider
                    if (context == "bossBag" && arg == thorium.ItemType("BoreanBag"))
                    {
                        player.QuickSpawnItem(ModContent.ItemType<FrozenWebbing>(), Main.rand.Next(12, 17) * multiplier);
                        player.QuickSpawnItem(ItemID.HealingPotion, Main.rand.Next(5, 16));

                        if (!ModContent.GetInstance<MainConfig>().OldDrops)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("GlacierFang"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("FreezeRay"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("GlacialSting"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("FrostFang"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("CryoFang"));
                        }
                    }

                    // Fallen Beholder
                    if (context == "bossBag" && arg == thorium.ItemType("BeholderBag"))
                    {
                        player.QuickSpawnItem(ModContent.ItemType<DistortedLens>(), Main.rand.Next(12, 17) * multiplier);
                        player.QuickSpawnItem(ItemID.HealingPotion, Main.rand.Next(5, 16));

                        if (!ModContent.GetInstance<MainConfig>().OldDrops)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("ThermogenicImpaler"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("Obliterator"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("DemonFireBlastWand"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("BeholderStaff"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("VoidPlanter"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("DevilPauldron"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("CarKey"));
                        }
                    }

                    // The Lich
                    if (context == "bossBag" && arg == thorium.ItemType("LichBag"))
                    {
                        player.QuickSpawnItem(thorium.ItemType("CursedCloth"), Main.rand.Next(12, 17)*2 * multiplier);
                        NPCLoader.blockLoot.Add(thorium.ItemType("CursedCloth"));
                        player.QuickSpawnItem(ItemID.GreaterHealingPotion, Main.rand.Next(5, 16));

                        if (!ModContent.GetInstance<MainConfig>().OldDrops)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("SoulRender"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("WitherStaff"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("CryptWand"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("SoulCleaver"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("SoulBomb"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("CadaverCornet"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("SpiritBand"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("TheLostCross"));
                            NPCLoader.blockLoot.Add(ItemID.PumpkinMoonMedallion);
                        }
                    }

                    // Abyssion
                    if (context == "bossBag" && arg == thorium.ItemType("AbyssionBag"))
                    {
                        player.QuickSpawnItem(ModContent.ItemType<TrenchShell>(), Main.rand.Next(12, 17) * multiplier);
                        player.QuickSpawnItem(ItemID.GreaterHealingPotion, Main.rand.Next(5, 16));

                        if (!ModContent.GetInstance<MainConfig>().OldDrops)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("WhisperingHood"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("WhisperingTabard"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("WhisperingLeggings"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("MantisPunch"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("TrenchSpitter"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("OldGodGrasp"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("TheIncubator"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("SirensAllure"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("RlyehLostRod"));
                        }
                    }

                    // Dying Reality
                    if (context == "bossBag" && arg == thorium.ItemType("RagBag"))
                    {
                        player.QuickSpawnItem(ItemID.SuperHealingPotion, Main.rand.Next(5, 16));
                    }
                }
            }

            // Events
            if (ModContent.GetInstance<MainConfig>().EnableEvent)
            {
                // Betsy
                if (context == "bossBag" && arg == ItemID.BossBagBetsy)
                {
                    player.QuickSpawnItem(ModContent.ItemType<EtherianScale>(), Main.rand.Next(12, 17) * multiplier);
                    player.QuickSpawnItem(ItemID.GreaterHealingPotion, Main.rand.Next(5, 16));

                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.DD2SquireBetsySword);
                        NPCLoader.blockLoot.Add(ItemID.MonkStaffT3);
                        NPCLoader.blockLoot.Add(ItemID.DD2BetsyBow);
                        NPCLoader.blockLoot.Add(ItemID.ApprenticeStaffT3);
                        NPCLoader.blockLoot.Add(ItemID.BetsyWings);
                        if (thorium_x)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("DragonFang"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("BetsysBellow"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("ValhallasDescent"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("DragonHeartWand"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("MediumRareSteak"));
                        }
                    }
                }
            }
        }
    }
}