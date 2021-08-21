using System;
using System.Linq;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;
using MomlobBossMat.Items.Vanilla.Events;

namespace MomlobBossMat.Items.Vanilla.Bosses
{
	public class MBM_ConduitPlating_Item : GlobalItem
	{

        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.MartianConduitPlating && ModContent.GetInstance<MainConfig>().EnableEvent)
			{
				item.rare = ItemRarityID.Yellow;
				item.maxStack = 999;
                item.value = 800;
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (item.type == ItemID.MartianConduitPlating && ModContent.GetInstance<MainConfig>().EnableEvent)
            {
				tooltips.Insert(1, new TooltipLine(mod, "MomlobBossMat", "[c/909090:Event Material:] [c/90B14B:Martian Saucer]"));
                tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
                ItemID.Sets.SortingPriorityMaterials[item.type] = 10091;
				return;
			}
		}



		public override void AddRecipes()
		{
			// Configs & Mod Calls
			Mod bossPlus = ModLoader.GetMod("MomlobBossPlus");
			bool bossPlus_x = bossPlus != null;
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;

            if (ModContent.GetInstance<MainConfig>().EnableEvent)
            {
                // Influx Waver
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.MartianConduitPlating, 100);
                recipe.AddIngredient(ItemID.Nanites, 25);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(ItemID.InfluxWaver);
                recipe.AddRecipe();
                if (thorium_x)
                {
                    // Livewire Crasher
                    recipe = new ModRecipe(mod);
                    recipe.AddIngredient(ItemID.MartianConduitPlating, 100);
                    recipe.AddIngredient(ItemID.ShroomiteBar, 10);
                    recipe.AddTile(TileID.MythrilAnvil);
                    recipe.SetResult(thorium.ItemType("LivewireCrasher"));
                    recipe.AddRecipe();
                }
                // Xenopopper
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.MartianConduitPlating, 100);
                recipe.AddIngredient(ItemID.ShroomiteBar, 10);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(ItemID.Xenopopper);
                recipe.AddRecipe();
                // Electrosphere Launcher
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.MartianConduitPlating, 100);
                recipe.AddIngredient(ItemID.Wire, 25);
                recipe.AddIngredient(ItemID.ShroomiteBar, 10);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(ItemID.ElectrosphereLauncher);
                recipe.AddRecipe();
                // Laser Machinegun
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.MartianConduitPlating, 100);
                recipe.AddIngredient(ItemID.SpectreBar, 10);
                recipe.AddIngredient(ItemID.LaserRifle);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(ItemID.LaserMachinegun);
                recipe.AddRecipe();
                // Charged Blaster
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.MartianConduitPlating, 100);
                recipe.AddIngredient(ItemID.SpectreBar, 10);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(ItemID.ChargedBlasterCannon);
                recipe.AddRecipe();
                if (thorium_x)
                {
                    // Super Plasma Cannon
                    recipe = new ModRecipe(mod);
                    recipe.AddIngredient(ItemID.MartianConduitPlating, 100);
                    recipe.AddIngredient(ItemID.Wire, 25);
                    recipe.AddIngredient(thorium.ItemType("TitanBar"), 5);
                    recipe.AddTile(TileID.MythrilAnvil);
                    recipe.SetResult(thorium.ItemType("SuperPlasmaCannon"));
                    recipe.AddRecipe();
                }
                // Xeno Staff
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.MartianConduitPlating, 100);
                recipe.AddIngredient(ItemID.Wire, 25);
                recipe.AddIngredient(ItemID.Nanites, 25);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(ItemID.XenoStaff);
                recipe.AddRecipe();
                if (thorium_x)
                {
                    // Volt Module
                    recipe = new ModRecipe(mod);
                    recipe.AddIngredient(ItemID.MartianConduitPlating, 100);
                    recipe.AddIngredient(ItemID.Wire, 25);
                    recipe.AddIngredient(thorium.ItemType("GraniteEnergyCore"), 5);
                    recipe.AddTile(TileID.MythrilAnvil);
                    recipe.SetResult(thorium.ItemType("VoltModule"));
                    recipe.AddRecipe();
                    // Cosmic Dagger
                    recipe = new ModRecipe(mod);
                    recipe.AddIngredient(ItemID.MartianConduitPlating, 100);
                    recipe.AddIngredient(ItemID.Nanites, 25);
                    recipe.AddTile(TileID.MythrilAnvil);
                    recipe.SetResult(thorium.ItemType("CosmicDagger"));
                    recipe.AddRecipe();
                    // Electro Rebounder
                    recipe = new ModRecipe(mod);
                    recipe.AddIngredient(ItemID.MartianConduitPlating, 50);
                    recipe.AddIngredient(ItemID.Nanites, 5);
                    recipe.AddTile(TileID.MythrilAnvil);
                    recipe.SetResult(thorium.ItemType("ElectroRebounder"), 200);
                    recipe.AddRecipe();
                    // Triangle
                    recipe = new ModRecipe(mod);
                    recipe.AddIngredient(ItemID.MartianConduitPlating, 100);
                    recipe.AddIngredient(thorium.ItemType("StrangePlating"), 5);
                    recipe.AddIngredient(thorium.ItemType("TitanBar"), 5);
                    recipe.AddTile(TileID.MythrilAnvil);
                    recipe.SetResult(thorium.ItemType("Triangle"));
                    recipe.AddRecipe();
                    // Turntable
                    recipe = new ModRecipe(mod);
                    recipe.AddIngredient(ItemID.MartianConduitPlating, 100);
                    recipe.AddIngredient(thorium.ItemType("StrangePlating"), 5);
                    recipe.AddIngredient(thorium.ItemType("ThoriumBar"), 5);
                    recipe.AddTile(TileID.MythrilAnvil);
                    recipe.SetResult(thorium.ItemType("Turntable"));
                    recipe.AddRecipe();
                    // Kinetoscythe
                    recipe = new ModRecipe(mod);
                    recipe.AddIngredient(ItemID.MartianConduitPlating, 100);
                    recipe.AddIngredient(ItemID.SpectreBar, 10);
                    recipe.AddTile(TileID.MythrilAnvil);
                    recipe.SetResult(thorium.ItemType("Kinetoscythe"));
                    recipe.AddRecipe();
                    // Molecule Stabilizer
                    recipe = new ModRecipe(mod);
                    recipe.AddIngredient(ItemID.MartianConduitPlating, 100);
                    recipe.AddIngredient(ItemID.Nanites, 25);
                    recipe.AddIngredient(thorium.ItemType("LifeCell"), 5);
                    recipe.AddTile(TileID.MythrilAnvil);
                    recipe.SetResult(thorium.ItemType("MoleculeStabilizer"));
                    recipe.AddRecipe();
                    // Shield Drone Beacon
                    recipe = new ModRecipe(mod);
                    recipe.AddIngredient(ItemID.MartianConduitPlating, 100);
                    recipe.AddIngredient(ItemID.Wire, 25);
                    recipe.AddIngredient(thorium.ItemType("LifeCell"), 5);
                    recipe.AddTile(TileID.MythrilAnvil);
                    recipe.SetResult(thorium.ItemType("ShieldDroneBeacon"));
                    recipe.AddRecipe();
                }

                // Anti Gravity Hook
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.MartianConduitPlating, 50);
                recipe.AddIngredient(ItemID.Nanites, 25);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(ItemID.AntiGravityHook);
                recipe.AddRecipe();
                // Cosmic Car Key
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.MartianConduitPlating, 250);
                recipe.AddIngredient(ItemID.Wire, 25);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(ItemID.CosmicCarKey);
                recipe.AddRecipe();
                // Brain Scrambler
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.MartianConduitPlating, 250);
                recipe.AddIngredient(ItemID.Wire, 25);
                recipe.AddIngredient(ItemID.Nanites, 25);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(ItemID.BrainScrambler);
                recipe.AddRecipe();

                // Laser Drill
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.MartianConduitPlating, 50);
                recipe.AddIngredient(ItemID.Wire, 25);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(ItemID.LaserDrill);
                recipe.AddRecipe();

                // Martian Costume Vanity
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.MartianConduitPlating, 10);
                recipe.AddIngredient(ItemID.Silk, 2);
                recipe.AddTile(TileID.Loom);
                recipe.SetResult(ItemID.MartianCostumeMask);
                recipe.AddRecipe();
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.MartianConduitPlating, 10);
                recipe.AddIngredient(ItemID.Silk, 2);
                recipe.AddTile(TileID.Loom);
                recipe.SetResult(ItemID.MartianCostumeShirt);
                recipe.AddRecipe();
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.MartianConduitPlating, 10);
                recipe.AddIngredient(ItemID.Silk, 2);
                recipe.AddTile(TileID.Loom);
                recipe.SetResult(ItemID.MartianCostumePants);
                recipe.AddRecipe();
                // Martian Uniform Vanity
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.MartianConduitPlating, 10);
                recipe.AddIngredient(ItemID.Wire, 5);
                recipe.AddTile(TileID.Loom);
                recipe.SetResult(ItemID.MartianUniformHelmet);
                recipe.AddRecipe();
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.MartianConduitPlating, 10);
                recipe.AddIngredient(ItemID.Wire, 5);
                recipe.AddTile(TileID.Loom);
                recipe.SetResult(ItemID.MartianUniformTorso);
                recipe.AddRecipe();
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.MartianConduitPlating, 10);
                recipe.AddIngredient(ItemID.Wire, 5);
                recipe.AddTile(TileID.Loom);
                recipe.SetResult(ItemID.MartianUniformPants);
                recipe.AddRecipe();
            }
        }
	}
}