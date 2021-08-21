using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Thorium
{
	public class DistortedLens : ModItem
	{
		public override bool Autoload(ref string name)
		{
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;
			return ModContent.GetInstance<MainConfig>().EnableBoss && thorium_x;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Distorted Lens");
			Tooltip.SetDefault("[c/909090:Boss Material:] [c/5745A6:Coznix]");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 10065;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 24;

			item.rare = ItemRarityID.Pink;
			item.maxStack = 999;
			item.value = 5500;
		}



		public override void AddRecipes()
		{
			// Configs & Mod Calls
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;

			if (thorium_x)
			{
				// Thermogenic Impaler
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:BeholderBars", 5);
				recipe.AddIngredient(thorium.ItemType("MagmaCore"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("ThermogenicImpaler"));
				recipe.AddRecipe();
				// Obliterator
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:BeholderBars", 5);
				recipe.AddIngredient(ItemID.HellstoneBar, 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("Obliterator"));
				recipe.AddRecipe();
				// Demon Fire Blast Wand
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:BeholderBars", 5);
				recipe.AddIngredient(thorium.ItemType("MoltenResidue"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("DemonFireBlastWand"));
				recipe.AddRecipe();
				// Beholder Staff
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:BeholderBars", 5);
				recipe.AddIngredient(thorium.ItemType("MoltenResidue"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("BeholderStaff"));
				recipe.AddRecipe();
				// Void Planter
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:BeholderBars", 5);
				recipe.AddIngredient(thorium.ItemType("HallowedCharm"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("VoidPlanter"));
				recipe.AddRecipe();

				// Devils Carapace
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:BeholderBars", 5);
				recipe.AddIngredient(thorium.ItemType("MoltenResidue"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("DevilPauldron"));
				recipe.AddRecipe();
				// Void Gazers Chariot
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 25);
				recipe.AddRecipeGroup("MomlobBossMat:BeholderBars", 10);
				recipe.AddIngredient(ItemID.Book);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("CarKey"));
				recipe.AddRecipe();
			}
		}
	}
}