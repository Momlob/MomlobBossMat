using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Thorium
{
	public class GrimyCoral : ModItem
	{
		public override bool Autoload(ref string name)
		{
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;
			return ModContent.GetInstance<MainConfig>().EnableBoss && thorium_x;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Grimy Coral");
			Tooltip.SetDefault("[c/909090:Boss Material:] [c/E375D6:Queen Jellyfish]");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 10034;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 28;

			item.rare = ItemRarityID.Green;
			item.maxStack = 999;
			item.value = 2200;
		}



		public override void AddRecipes()
		{
			// Configs & Mod Calls
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;

			if (thorium_x)
			{
				// Sparking Jelly Ball
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(thorium.ItemType("AquaticBar"), 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("SparkingJellyBall"));
				recipe.AddRecipe();
				// Giant Glowstick
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:SilverBars", 5);
				recipe.AddIngredient(ItemID.Glowstick, 10);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("GiantGlowstick"));
				recipe.AddRecipe();
				// Buccaneers Blunderbuss
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:IronBars", 5);
				recipe.AddIngredient(thorium.ItemType("DepthScale"), 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("BlunderBuss"));
				recipe.AddRecipe();
				// Jelly Pond Wand
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ItemID.Coral, 5);
				recipe.AddIngredient(ItemID.PinkGel, 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("JellyPondWand"));
				recipe.AddRecipe();
				// Conch Shell
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(thorium.ItemType("AquaticBar"), 5);
				recipe.AddIngredient(ItemID.Seashell, 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("ConchShell"));
				recipe.AddRecipe();

				// Queens Glowstick
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ItemID.PinkGel, 25);
				recipe.AddIngredient(ItemID.Glowstick, 10);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("QueensGlowstick"));
				recipe.AddRecipe();
			}
		}
	}
}