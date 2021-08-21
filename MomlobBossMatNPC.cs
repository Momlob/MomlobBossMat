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
    public class ModGlobalNPC : GlobalNPC
    {
        public override bool PreNPCLoot(NPC npc)
        {
            // Configs & Mod Calls
            int multiplier = (ModContent.GetInstance<MainConfig>().Multiplier);
            Mod thorium = ModLoader.GetMod("ThoriumMod");
            bool thorium_x = (thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium);



            // Bosses
            if (ModContent.GetInstance<MainConfig>().EnableBoss)
            {
                // King Slime
                if (npc.type == NPCID.KingSlime)
                {
                    if (!Main.expertMode)
                        Item.NewItem(npc.position, npc.Size, ModContent.ItemType<GelidCrownshard>(), Main.rand.Next(10, 13) * multiplier);
                    else
                        NPCLoader.blockLoot.Add(ItemID.LesserHealingPotion);

                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.Solidifier);
                        NPCLoader.blockLoot.Add(ItemID.NinjaHood);
                        NPCLoader.blockLoot.Add(ItemID.NinjaShirt);
                        NPCLoader.blockLoot.Add(ItemID.NinjaPants);
                        NPCLoader.blockLoot.Add(ItemID.SlimeHook);
                        NPCLoader.blockLoot.Add(ItemID.SlimySaddle);
                        NPCLoader.blockLoot.Add(ItemID.SlimeGun);
                        if (thorium_x)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("ShinobiSlicer"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("TechniqueHiddenBlade"));
                        }
                    }
                }

                // Eye of Cthulhu
                if (npc.type == NPCID.EyeofCthulhu)
                {
                    if (!Main.expertMode)
                        Item.NewItem(npc.position, npc.Size, ModContent.ItemType<ShatteredLens>(), Main.rand.Next(10, 13) * multiplier);
                    else
                        NPCLoader.blockLoot.Add(ItemID.LesserHealingPotion);

                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.CorruptSeeds);
                        NPCLoader.blockLoot.Add(ItemID.UnholyArrow);
                        NPCLoader.blockLoot.Add(ItemID.CrimsonSeeds);
                        NPCLoader.blockLoot.Add(ItemID.Binoculars);
                    }
                }

                // Eater of Worlds
                if (npc.type == NPCID.EaterofWorldsHead || npc.type == NPCID.EaterofWorldsBody || npc.type == NPCID.EaterofWorldsTail)
                {
                    if (Main.expertMode)
                    {
                        NPCLoader.blockLoot.Add(ItemID.LesserHealingPotion);
                        NPCLoader.blockLoot.Add(ItemID.ShadowScale);
                    }

                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.EatersBone);
                        if (thorium_x)
                            NPCLoader.blockLoot.Add(thorium.ItemType("EaterOfPain"));
                    }
                }

                // Brain of Cthulhu
                if (npc.type == NPCID.BrainofCthulhu || npc.type == NPCID.Creeper)
                {
                    if (Main.expertMode)
                    {
                        NPCLoader.blockLoot.Add(ItemID.LesserHealingPotion);
                        NPCLoader.blockLoot.Add(ItemID.TissueSample);
                    }

                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.BoneRattle);
                        if (thorium_x)
                            NPCLoader.blockLoot.Add(thorium.ItemType("TheStalker"));
                    }
                }

                // Queen Bee
                if (npc.type == NPCID.QueenBee)
                {
                    if (!Main.expertMode)
                    {
                        Item.NewItem(npc.position, npc.Size, ItemID.BeeWax, Main.rand.Next(10, 13) * multiplier);
                        NPCLoader.blockLoot.Add(ItemID.BeeWax);
                    }
                    else
                        NPCLoader.blockLoot.Add(ItemID.BottledHoney);

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
                if (npc.type == NPCID.SkeletronHead)
                {
                    if (!Main.expertMode)
                        Item.NewItem(npc.position, npc.Size, ModContent.ItemType<CursedFragment>(), Main.rand.Next(10, 13) * multiplier);
                    else
                        NPCLoader.blockLoot.Add(ItemID.LesserHealingPotion);

                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.SkeletronHand);
                        NPCLoader.blockLoot.Add(ItemID.BookofSkulls);
                        if (thorium_x)
                            NPCLoader.blockLoot.Add(thorium.ItemType("GuildsStaff"));
                    }
                }

                // Wall of Flesh
                if (npc.type == NPCID.WallofFlesh)
                {
                    if (!Main.expertMode)
                        Item.NewItem(npc.position, npc.Size, ModContent.ItemType<ShackledFlesh>(), Main.rand.Next(10, 13) * multiplier);
                    else
                        NPCLoader.blockLoot.Add(ItemID.HealingPotion);

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
                if (npc.type == NPCID.Retinazer || npc.type == NPCID.Spazmatism)
                {
                    if (Main.expertMode)
                        NPCLoader.blockLoot.Add(ItemID.GreaterHealingPotion);
                }

                // Destroyer
                if (npc.type == NPCID.TheDestroyer)
                {
                    if (Main.expertMode)
                        NPCLoader.blockLoot.Add(ItemID.GreaterHealingPotion);
                }

                // Skeletron Prime
                if (npc.type == NPCID.SkeletronPrime)
                {
                    if (Main.expertMode)
                        NPCLoader.blockLoot.Add(ItemID.GreaterHealingPotion);
                }

                // Plantera
                if (npc.type == NPCID.Plantera)
                {
                    if (!Main.expertMode)
                        Item.NewItem(npc.position, npc.Size, ModContent.ItemType<VenusPetal>(), Main.rand.Next(10, 13) * multiplier);
                    else
                        NPCLoader.blockLoot.Add(ItemID.GreaterHealingPotion);

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
                if (npc.type == NPCID.Golem)
                {
                    if (!Main.expertMode)
                        Item.NewItem(npc.position, npc.Size, ModContent.ItemType<AncientGear>(), Main.rand.Next(10, 13) * multiplier);
                    else
                        NPCLoader.blockLoot.Add(ItemID.GreaterHealingPotion);

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
                if (npc.type == NPCID.DukeFishron)
                {
                    if (!Main.expertMode)
                        Item.NewItem(npc.position, npc.Size, ModContent.ItemType<FishronScale>(), Main.rand.Next(10, 13) * multiplier);
                    else
                        NPCLoader.blockLoot.Add(ItemID.GreaterHealingPotion);

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
                if (npc.type == NPCID.MoonLordCore)
                {
                    if (!Main.expertMode)
                    {
                        Item.NewItem(npc.position, npc.Size, ItemID.LunarOre, Main.rand.Next(10, 13) * 8 * multiplier);
                        NPCLoader.blockLoot.Add(ItemID.LunarOre);
                    }
                    else
                        NPCLoader.blockLoot.Add(ItemID.GreaterHealingPotion);

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
                    if (npc.type == thorium.NPCType("TheGrandThunderBirdv2"))
                    {
                        if (!Main.expertMode)
                            Item.NewItem(npc.position, npc.Size, ModContent.ItemType<GaleTalon>(), Main.rand.Next(10, 13) * multiplier);
                        else
                            NPCLoader.blockLoot.Add(ItemID.LesserHealingPotion);

                        if (!ModContent.GetInstance<MainConfig>().OldDrops)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("ThunderTalon"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("TalonBurst"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("HatchlingStaff"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("Didgeridoo"));
                        }
                    }

                    // Queen Jellyfish
                    if (npc.type == thorium.NPCType("QueenJelly"))
                    {
                        if (!Main.expertMode)
                            Item.NewItem(npc.position, npc.Size, ModContent.ItemType<GrimyCoral>(), Main.rand.Next(10, 13) * multiplier);
                        else
                            NPCLoader.blockLoot.Add(ItemID.LesserHealingPotion);

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
                    if (npc.type == thorium.NPCType("Viscount"))
                    {
                        if (!Main.expertMode)
                            Item.NewItem(npc.position, npc.Size, ModContent.ItemType<VampiresWing>(), Main.rand.Next(10, 13) * multiplier);
                        else
                            NPCLoader.blockLoot.Add(ItemID.LesserHealingPotion);

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
                    if (npc.type == thorium.NPCType("GraniteEnergyStorm"))
                    {
                        if (!Main.expertMode)
                            Item.NewItem(npc.position, npc.Size, ModContent.ItemType<PetrifiedEnergy>(), Main.rand.Next(10, 13) * multiplier);
                        else
                            NPCLoader.blockLoot.Add(ItemID.LesserHealingPotion);

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
                    if (npc.type == thorium.NPCType("TheBuriedWarrior"))
                    {
                        if (!Main.expertMode)
                            Item.NewItem(npc.position, npc.Size, ModContent.ItemType<AncientTriobol>(), Main.rand.Next(10, 13) * multiplier);
                        else
                            NPCLoader.blockLoot.Add(ItemID.LesserHealingPotion);

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
                    if (npc.type == thorium.NPCType("ThePrimeScouter"))
                    {
                        if (!Main.expertMode)
                            Item.NewItem(npc.position, npc.Size, ModContent.ItemType<StarforgedPlating>(), Main.rand.Next(10, 13) * multiplier);
                        else
                            NPCLoader.blockLoot.Add(ItemID.HealingPotion);

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
                    if (npc.type == thorium.NPCType("BoreanStrider") || npc.type == thorium.NPCType("BoreanStriderPopped"))
                    {
                        if (!Main.expertMode)
                            Item.NewItem(npc.position, npc.Size, ModContent.ItemType<FrozenWebbing>(), Main.rand.Next(10, 13) * multiplier);
                        else
                            NPCLoader.blockLoot.Add(ItemID.LesserHealingPotion);

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
                    if (npc.type == thorium.NPCType("FallenDeathBeholder") || npc.type == thorium.NPCType("FallenDeathBeholder2"))
                    {
                        if (!Main.expertMode)
                            Item.NewItem(npc.position, npc.Size, ModContent.ItemType<DistortedLens>(), Main.rand.Next(10, 13) * multiplier);
                        else
                            NPCLoader.blockLoot.Add(ItemID.HealingPotion);

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
                    if (npc.type == thorium.NPCType("Lich") || npc.type == thorium.NPCType("LichHeadless"))
                    {
                        if (!Main.expertMode)
                        {
                            Item.NewItem(npc.position, npc.Size, thorium.ItemType("CursedCloth"), Main.rand.Next(10, 12)*2 * multiplier);
                            NPCLoader.blockLoot.Add(thorium.ItemType("CursedCloth"));
                        }
                        else
                            NPCLoader.blockLoot.Add(ItemID.GreaterHealingPotion);

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
                    if (npc.type == thorium.NPCType("Abyssion") || npc.type == thorium.NPCType("AbyssionCracked") || npc.type == thorium.NPCType("AbyssionReleased"))
                    {
                        if (!Main.expertMode)
                            Item.NewItem(npc.position, npc.Size, ModContent.ItemType<TrenchShell>(), Main.rand.Next(10, 13) * multiplier);
                        else
                            NPCLoader.blockLoot.Add(ItemID.GreaterHealingPotion);

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
                    if (npc.type == thorium.NPCType("SlagFury") || npc.type == thorium.NPCType("Aquaius")
                        || npc.type == thorium.NPCType("Omnicide") || npc.type == thorium.NPCType("RealityBreaker"))
                    {
                        if (Main.expertMode)
                            NPCLoader.blockLoot.Add(ItemID.SuperHealingPotion);
                    }
                }
            }

            // Events
            if (ModContent.GetInstance<MainConfig>().EnableEvent)
            {
                // Goblin Army
                if ((npc.type >= NPCID.GoblinPeon && npc.type <= NPCID.GoblinSorcerer) || npc.type == NPCID.GoblinArcher)
                {
                    if (Main.rand.Next(20) == 0)
                        Item.NewItem(npc.position, npc.Size, ItemID.TatteredCloth);

                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.Harpoon);
                        if (thorium_x)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("YewWoodBlowpipe"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("DarkGate"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("ShadowPurgeCaltrop"));
                        }
                    }
                }
                if (npc.type == NPCID.GoblinSummoner)
                {
                    if (!Main.expertMode)
                        Item.NewItem(npc.position, npc.Size, ModContent.ItemType<HexFlame>(), Main.rand.Next(5, 7) * multiplier);
                    else
                        Item.NewItem(npc.position, npc.Size, ModContent.ItemType<HexFlame>(), Main.rand.Next(6, 9) * multiplier);

                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.ShadowFlameKnife);
                        NPCLoader.blockLoot.Add(ItemID.ShadowFlameBow);
                        NPCLoader.blockLoot.Add(ItemID.ShadowFlameHexDoll);
                        if (thorium_x)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("ShadowTippedJavelin"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("SummonerWarhorn"));
                        }
                    }
                }
                if (thorium_x)
                {
                    if (npc.type == thorium.NPCType("GoblinTrapper"))
                        NPCLoader.blockLoot.Add(thorium.ItemType("SpikeBomb"));
                    if (npc.type == thorium.NPCType("GoblinSpiritGuide"))
                        Item.NewItem(npc.position, npc.Size, ModContent.ItemType<HexFlame>());
                }

                // Pirate Invasion
                if ((npc.type >= NPCID.PirateDeckhand && npc.type <= NPCID.PirateCaptain) || npc.type == NPCID.PirateShip)
                {
                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.Cutlass);
                        NPCLoader.blockLoot.Add(ItemID.CoinGun);
                        NPCLoader.blockLoot.Add(ItemID.PirateStaff);
                        NPCLoader.blockLoot.Add(ItemID.LuckyCoin);
                        NPCLoader.blockLoot.Add(ItemID.GoldRing);
                        NPCLoader.blockLoot.Add(ItemID.DiscountCard);
                        NPCLoader.blockLoot.Add(ItemID.SailorHat);
                        NPCLoader.blockLoot.Add(ItemID.SailorShirt);
                        NPCLoader.blockLoot.Add(ItemID.SailorPants);
                        NPCLoader.blockLoot.Add(ItemID.BuccaneerBandana);
                        NPCLoader.blockLoot.Add(ItemID.BuccaneerShirt);
                        NPCLoader.blockLoot.Add(ItemID.BuccaneerPants);
                        NPCLoader.blockLoot.Add(ItemID.EyePatch);

                        NPCLoader.blockLoot.Add(ItemID.GoldenPlatform);
                        NPCLoader.blockLoot.Add(ItemID.GoldenWorkbench);
                        NPCLoader.blockLoot.Add(ItemID.GoldenTable);
                        NPCLoader.blockLoot.Add(ItemID.GoldenDresser);
                        NPCLoader.blockLoot.Add(ItemID.GoldenPiano);
                        NPCLoader.blockLoot.Add(ItemID.GoldenBookcase);
                        NPCLoader.blockLoot.Add(ItemID.GoldenChair);
                        NPCLoader.blockLoot.Add(ItemID.GoldenSofa);
                        NPCLoader.blockLoot.Add(ItemID.GoldenBed);
                        NPCLoader.blockLoot.Add(ItemID.GoldenDoor);
                        NPCLoader.blockLoot.Add(ItemID.GoldenClock);
                        NPCLoader.blockLoot.Add(ItemID.GoldenToilet);
                        NPCLoader.blockLoot.Add(ItemID.GoldenSink);
                        NPCLoader.blockLoot.Add(ItemID.GoldenBathtub);
                        NPCLoader.blockLoot.Add(ItemID.GoldenCandle);
                        NPCLoader.blockLoot.Add(ItemID.GoldenLamp);
                        NPCLoader.blockLoot.Add(ItemID.GoldenCandelabra);
                        NPCLoader.blockLoot.Add(ItemID.GoldenLantern);
                        NPCLoader.blockLoot.Add(ItemID.GoldenChandelier);
                        NPCLoader.blockLoot.Add(ItemID.GoldenChest);
                        if (thorium_x)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("CaptainsPoniard"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("DeadEyePatch"));
                        }
                    }
                }
                if (npc.type == NPCID.PirateCaptain)
                {
                    Item.NewItem(npc.position, npc.Size, ModContent.ItemType<Dubloon>());
                }
                if (npc.type == NPCID.PirateShip)
                    {
                        if (!Main.expertMode)
                            Item.NewItem(npc.position, npc.Size, ModContent.ItemType<Dubloon>(), Main.rand.Next(5, 7) * multiplier);
                        else
                            Item.NewItem(npc.position, npc.Size, ModContent.ItemType<Dubloon>(), Main.rand.Next(6, 9) * multiplier);
                }
                if (thorium_x)
                {
                    if (npc.type == NPCID.PirateShip)
                    {
                        NPCLoader.blockLoot.Add(thorium.ItemType("TheJuggernaut"));
                        NPCLoader.blockLoot.Add(thorium.ItemType("ShipsHelm"));
                        NPCLoader.blockLoot.Add(thorium.ItemType("HandCannon"));
                        NPCLoader.blockLoot.Add(thorium.ItemType("CannonBall"));
                        NPCLoader.blockLoot.Add(thorium.ItemType("Tuba"));
                        NPCLoader.blockLoot.Add(thorium.ItemType("GreedyMagnet"));
                    }
                    if (npc.type == thorium.NPCType("SeaShantySinger"))
                    {
                        NPCLoader.blockLoot.Add(ItemID.Cutlass);
                        NPCLoader.blockLoot.Add(ItemID.CoinGun);
                        NPCLoader.blockLoot.Add(ItemID.PirateStaff);
                        NPCLoader.blockLoot.Add(ItemID.LuckyCoin);
                        NPCLoader.blockLoot.Add(ItemID.GoldRing);
                        NPCLoader.blockLoot.Add(ItemID.DiscountCard);
                        NPCLoader.blockLoot.Add(ItemID.SailorHat);
                        NPCLoader.blockLoot.Add(ItemID.SailorShirt);
                        NPCLoader.blockLoot.Add(ItemID.SailorPants);
                        NPCLoader.blockLoot.Add(ItemID.BuccaneerBandana);
                        NPCLoader.blockLoot.Add(ItemID.BuccaneerShirt);
                        NPCLoader.blockLoot.Add(ItemID.BuccaneerPants);
                        NPCLoader.blockLoot.Add(ItemID.EyePatch);

                        NPCLoader.blockLoot.Add(ItemID.GoldenPlatform);
                        NPCLoader.blockLoot.Add(ItemID.GoldenWorkbench);
                        NPCLoader.blockLoot.Add(ItemID.GoldenTable);
                        NPCLoader.blockLoot.Add(ItemID.GoldenDresser);
                        NPCLoader.blockLoot.Add(ItemID.GoldenPiano);
                        NPCLoader.blockLoot.Add(ItemID.GoldenBookcase);
                        NPCLoader.blockLoot.Add(ItemID.GoldenChair);
                        NPCLoader.blockLoot.Add(ItemID.GoldenSofa);
                        NPCLoader.blockLoot.Add(ItemID.GoldenBed);
                        NPCLoader.blockLoot.Add(ItemID.GoldenDoor);
                        NPCLoader.blockLoot.Add(ItemID.GoldenClock);
                        NPCLoader.blockLoot.Add(ItemID.GoldenToilet);
                        NPCLoader.blockLoot.Add(ItemID.GoldenSink);
                        NPCLoader.blockLoot.Add(ItemID.GoldenBathtub);
                        NPCLoader.blockLoot.Add(ItemID.GoldenCandle);
                        NPCLoader.blockLoot.Add(ItemID.GoldenLamp);
                        NPCLoader.blockLoot.Add(ItemID.GoldenCandelabra);
                        NPCLoader.blockLoot.Add(ItemID.GoldenLantern);
                        NPCLoader.blockLoot.Add(ItemID.GoldenChandelier);
                        NPCLoader.blockLoot.Add(ItemID.GoldenChest);
                        NPCLoader.blockLoot.Add(thorium.ItemType("Concertina"));
                    }
                }

                // Pumpkin Moon
                if ((npc.type >= NPCID.Scarecrow1 && npc.type <= NPCID.Scarecrow10) || npc.type == NPCID.Splinterling || npc.type == NPCID.HeadlessHorseman)
                {
                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.ScarecrowHat);
                        NPCLoader.blockLoot.Add(ItemID.ScarecrowShirt);
                        NPCLoader.blockLoot.Add(ItemID.ScarecrowPants);
                        NPCLoader.blockLoot.Add(ItemID.SpookyWood);
                        NPCLoader.blockLoot.Add(ItemID.JackOLanternMask);
                    }
                }
                if (npc.type == NPCID.MourningWood)
                {
                    if (!Main.expertMode)
                        Item.NewItem(npc.position, npc.Size, ItemID.SpookyWood, Main.rand.Next(50, 61) * multiplier);
                    else
                        Item.NewItem(npc.position, npc.Size, ItemID.SpookyWood, Main.rand.Next(60, 81) * multiplier);
                    NPCLoader.blockLoot.Add(ItemID.SpookyWood);


                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.SpookyHook);
                        NPCLoader.blockLoot.Add(ItemID.NecromanticScroll);
                        NPCLoader.blockLoot.Add(ItemID.SpookyTwig);
                        NPCLoader.blockLoot.Add(ItemID.CursedSapling);
                        NPCLoader.blockLoot.Add(ItemID.StakeLauncher);
                        NPCLoader.blockLoot.Add(ItemID.Stake);
                        if(thorium_x)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("CharonsBeacon"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("PaganGrasp"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("Effigy"));
                        }
                    }
                }
                if (npc.type == NPCID.Pumpking)
                {
                    if (!Main.expertMode)
                        Item.NewItem(npc.position, npc.Size, ModContent.ItemType<EerieCandy>(), Main.rand.Next(5, 7) * multiplier);
                    else
                        Item.NewItem(npc.position, npc.Size, ModContent.ItemType<EerieCandy>(), Main.rand.Next(6, 9) * multiplier);

                    if (Main.rand.Next(7) == 0)
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.JackOLanternMask);

                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.SpiderEgg);
                        NPCLoader.blockLoot.Add(ItemID.BlackFairyDust);
                        NPCLoader.blockLoot.Add(ItemID.TheHorsemansBlade);
                        NPCLoader.blockLoot.Add(ItemID.CandyCornRifle);
                        NPCLoader.blockLoot.Add(ItemID.CandyCorn);
                        NPCLoader.blockLoot.Add(ItemID.JackOLanternLauncher);
                        NPCLoader.blockLoot.Add(ItemID.ExplosiveJackOLantern);
                        NPCLoader.blockLoot.Add(ItemID.BatScepter);
                        NPCLoader.blockLoot.Add(ItemID.RavenStaff);
                        if (thorium_x)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("Witchblade"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("HauntingBassDrum"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("SnackLantern"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("FlyingBroom"));
                        }
                    }
                }

                // Frost Moo
                if (npc.type >= NPCID.ZombieElf && npc.type <= NPCID.ZombieElfGirl)
                {
                    NPCLoader.blockLoot.Add(ItemID.ElfHat);
                    NPCLoader.blockLoot.Add(ItemID.ElfShirt);
                    NPCLoader.blockLoot.Add(ItemID.ElfPants);
                }
                if (npc.type == NPCID.Everscream)
                {
                    Item.NewItem(npc.position, npc.Size, ModContent.ItemType<FestiveOrnament>(), Main.rand.Next(1, 2) * multiplier);
                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.ChristmasHook);
                        NPCLoader.blockLoot.Add(ItemID.FestiveWings);
                        NPCLoader.blockLoot.Add(ItemID.ChristmasTreeSword);
                        NPCLoader.blockLoot.Add(ItemID.Razorpine);
                        if (thorium_x)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("ChristmasCheer"));
                        }
                    }
                }
                if (npc.type == NPCID.SantaNK1)
                {
                    if (!Main.expertMode)
                        Item.NewItem(npc.position, npc.Size, ModContent.ItemType<FestiveOrnament>(), Main.rand.Next(3, 6) * multiplier);
                    else
                        Item.NewItem(npc.position, npc.Size, ModContent.ItemType<FestiveOrnament>(), Main.rand.Next(5, 7) * multiplier);
                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.ChainGun);
                        NPCLoader.blockLoot.Add(ItemID.EldMelter);
                        if (thorium_x)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("JingleBells"));
                        }
                    }
                }
                if (npc.type == NPCID.IceQueen)
                {
                    if (!Main.expertMode)
                        Item.NewItem(npc.position, npc.Size, ModContent.ItemType<FrozenStar>(), Main.rand.Next(5, 7) * multiplier);
                    else
                        Item.NewItem(npc.position, npc.Size, ModContent.ItemType<FrozenStar>(), Main.rand.Next(6, 9) * multiplier);

                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.ReindeerBells);
                        NPCLoader.blockLoot.Add(ItemID.BabyGrinchMischiefWhistle);
                        NPCLoader.blockLoot.Add(ItemID.NorthPole);
                        NPCLoader.blockLoot.Add(ItemID.SnowmanCannon);
                        NPCLoader.blockLoot.Add(ItemID.BlizzardStaff);
                        if (thorium_x)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("SoftServeSunderer"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("Cryotherapy"));
                        }
                    }
                }

                // Dungeon Defenders Event
                if (npc.type == NPCID.DD2DarkMageT1 || npc.type == NPCID.DD2DarkMageT3)
                {
                    if (!Main.expertMode)
                        Item.NewItem(npc.position, npc.Size, ModContent.ItemType<EtherianParchment>(), Main.rand.Next(5, 7) * multiplier);
                    else
                        Item.NewItem(npc.position, npc.Size, ModContent.ItemType<EtherianParchment>(), Main.rand.Next(6, 9) * multiplier);

                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.WarTable);
                        NPCLoader.blockLoot.Add(ItemID.WarTableBanner);
                        NPCLoader.blockLoot.Add(ItemID.DD2PetDragon);
                        NPCLoader.blockLoot.Add(ItemID.DD2PetGato);
                        if (thorium_x)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("DarkMageBag"));
                        }
                    }
                }
                if (npc.type == NPCID.DD2OgreT2 || npc.type == NPCID.DD2OgreT3)
                {
                    if (!Main.expertMode)
                        Item.NewItem(npc.position, npc.Size, ModContent.ItemType<EtherianTusk>(), Main.rand.Next(5, 7) * multiplier);
                    else
                        Item.NewItem(npc.position, npc.Size, ModContent.ItemType<EtherianTusk>(), Main.rand.Next(6, 9) * multiplier);

                    if (npc.type == NPCID.DD2OgreT2)
                        Item.NewItem(npc.position, npc.Size, ModContent.ItemType<EtherianParchment>(), Main.rand.Next(1, 2) * multiplier);
                    
                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.DD2SquireDemonSword);
                        NPCLoader.blockLoot.Add(ItemID.MonkStaffT1);
                        NPCLoader.blockLoot.Add(ItemID.MonkStaffT2);
                        NPCLoader.blockLoot.Add(ItemID.DD2PhoenixBow);
                        NPCLoader.blockLoot.Add(ItemID.BookStaff);
                        NPCLoader.blockLoot.Add(ItemID.SquireShield);
                        NPCLoader.blockLoot.Add(ItemID.HuntressBuckler);
                        NPCLoader.blockLoot.Add(ItemID.ApprenticeScarf);
                        NPCLoader.blockLoot.Add(ItemID.MonkBelt);
                        NPCLoader.blockLoot.Add(ItemID.DD2PetGhost);
                        if (thorium_x)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("OgreBag"));
                        }
                    }
                }
                if (npc.type == NPCID.DD2Betsy)
                {
                    if (!Main.expertMode)
                    {
                        Item.NewItem(npc.position, npc.Size, ModContent.ItemType<EtherianScale>(), Main.rand.Next(10, 13) * multiplier);
                        Item.NewItem(npc.position, npc.Size, ItemID.GreaterHealingPotion, Main.rand.Next(5, 16) * multiplier);
                    }

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

                // Martian Madness
                if ((npc.type >= NPCID.BrainScrambler && npc.type <= NPCID.Scutlix) || npc.type == NPCID.MartianWalker)
                {
                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.MartianConduitPlating);
                        NPCLoader.blockLoot.Add(ItemID.ChargedBlasterCannon);
                        NPCLoader.blockLoot.Add(ItemID.AntiGravityHook);
                        NPCLoader.blockLoot.Add(ItemID.BrainScrambler);
                        NPCLoader.blockLoot.Add(ItemID.LaserDrill);
                        NPCLoader.blockLoot.Add(ItemID.MartianCostumeMask);
                        NPCLoader.blockLoot.Add(ItemID.MartianCostumeShirt);
                        NPCLoader.blockLoot.Add(ItemID.MartianCostumePants);
                        NPCLoader.blockLoot.Add(ItemID.MartianUniformHelmet);
                        NPCLoader.blockLoot.Add(ItemID.MartianUniformTorso);
                        NPCLoader.blockLoot.Add(ItemID.MartianUniformPants);
                        if (thorium_x)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("VoltModule"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("ElectroRebounder"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("ShieldDroneBeacon"));
                        }
                    }
                }
                if (npc.type == NPCID.MartianSaucerCannon || npc.type == NPCID.MartianSaucerTurret)
                {
                    Item.NewItem(npc.position, npc.Size, ItemID.MartianConduitPlating, 5 * multiplier);
                }
                if (npc.type == NPCID.MartianSaucerCore)
                {
                    if (!Main.expertMode)
                        Item.NewItem(npc.position, npc.Size, ItemID.MartianConduitPlating, Main.rand.Next(80, 101) * multiplier);
                    else
                        Item.NewItem(npc.position, npc.Size, ItemID.MartianConduitPlating, Main.rand.Next(100, 141) * multiplier);

                    if (!ModContent.GetInstance<MainConfig>().OldDrops)
                    {
                        NPCLoader.blockLoot.Add(ItemID.InfluxWaver);
                        NPCLoader.blockLoot.Add(ItemID.Xenopopper);
                        NPCLoader.blockLoot.Add(ItemID.ElectrosphereLauncher);
                        NPCLoader.blockLoot.Add(ItemID.LaserMachinegun);
                        NPCLoader.blockLoot.Add(ItemID.ChargedBlasterCannon);
                        NPCLoader.blockLoot.Add(ItemID.XenoStaff);
                        NPCLoader.blockLoot.Add(ItemID.AntiGravityHook);
                        NPCLoader.blockLoot.Add(ItemID.CosmicCarKey);
                        NPCLoader.blockLoot.Add(ItemID.LaserDrill);
                        if (thorium_x)
                        {
                            NPCLoader.blockLoot.Add(thorium.ItemType("LivewireCrasher"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("SuperPlasmaCannon"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("CosmicDagger"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("Triangle"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("Turntable"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("Kinetoscythe"));
                            NPCLoader.blockLoot.Add(thorium.ItemType("MoleculeStabilizer"));
                        }
                    }
                }
            }

            return true;
        }
    }
}