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
	public class MBM_SpookyWood_Item : GlobalItem
	{

        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.SpookyWood && ModContent.GetInstance<MainConfig>().EnableEvent)
			{
				item.rare = ItemRarityID.Yellow;
				item.maxStack = 999;
                item.value = 750;
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (item.type == ItemID.SpookyWood && ModContent.GetInstance<MainConfig>().EnableEvent)
            {
				tooltips.Insert(1, new TooltipLine(mod, "MomlobBossMat", "[c/909090:Event Material:] [c/3D395F:Mourning Wood]"));
				tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
				ItemID.Sets.SortingPriorityMaterials[item.type] = 10082;
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
				// Stake Launcher
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.SpookyWood, 100);
				recipe.AddRecipeGroup("MomlobBossMat:EvilBars", 10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.StakeLauncher);
				recipe.AddRecipe();
				if (thorium_x)
				{
					// Charons Beacon
					recipe = new ModRecipe(mod);
					recipe.AddIngredient(ItemID.SpookyWood, 100);
					recipe.AddIngredient(thorium.ItemType("MoltenResidue"), 5);
					recipe.AddTile(TileID.MythrilAnvil);
					recipe.SetResult(thorium.ItemType("CharonsBeacon"));
					recipe.AddRecipe();
					// Pagan Grasp
					recipe = new ModRecipe(mod);
					recipe.AddIngredient(ItemID.SpookyWood, 100);
					recipe.AddIngredient(ModContent.ItemType<HexFlame>(), 5);
					recipe.AddTile(TileID.MythrilAnvil);
					recipe.SetResult(thorium.ItemType("PaganGrasp"));
					recipe.AddRecipe();
				}

				// Necro Scroll
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.SpookyWood, 100);
				recipe.AddIngredient(ItemID.Ectoplasm, 10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.NecromanticScroll);
				recipe.AddRecipe();
				if (thorium_x)
				{
					// Dark Effigy
					recipe = new ModRecipe(mod);
					recipe.AddIngredient(ItemID.SpookyWood, 100);
					recipe.AddIngredient(thorium.ItemType("CursedCloth"), 5);
					recipe.AddTile(TileID.MythrilAnvil);
					recipe.SetResult(thorium.ItemType("Effigy"));
					recipe.AddRecipe();
				}
				// Spooky Hook
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.SpookyWood, 50);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SpookyHook);
				recipe.AddRecipe();
				// Spooky Twig
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.SpookyWood, 50);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SpookyTwig);
				recipe.AddRecipe();
				// Cursed Sapling
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.SpookyWood, 250);
				recipe.AddIngredient(ItemID.LivingFireBlock, 20);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CursedSapling);
				recipe.AddRecipe();

				// Scarecrow Vanity
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.SpookyWood, 10);
				recipe.AddIngredient(ItemID.Silk, 2);
				recipe.AddTile(TileID.Loom);
				recipe.SetResult(ItemID.ScarecrowHat);
				recipe.AddRecipe();
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.SpookyWood, 10);
				recipe.AddIngredient(ItemID.Silk, 2);
				recipe.AddTile(TileID.Loom);
				recipe.SetResult(ItemID.ScarecrowShirt);
				recipe.AddRecipe();
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.SpookyWood, 10);
				recipe.AddIngredient(ItemID.Silk, 2);
				recipe.AddTile(TileID.Loom);
				recipe.SetResult(ItemID.ScarecrowPants);
				recipe.AddRecipe();
			}
        }
	}
}