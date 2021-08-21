using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Thorium
{
	public class StarforgedPlating : ModItem
	{
		public override bool Autoload(ref string name)
		{
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;
			return ModContent.GetInstance<MainConfig>().EnableBoss && thorium_x;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Starforged Plating");
			Tooltip.SetDefault("[c/909090:Boss Material:] [c/8B49BC:Star Scouter]");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 10053;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
		}

		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 26;

			item.rare = ItemRarityID.Orange;
			item.maxStack = 999;
			item.value = 2800;
		}



		public override void AddRecipes()
		{
			// Configs & Mod Calls
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;

			if (thorium_x)
			{
				// Star Trail
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ItemID.MeteoriteBar, 5);
				recipe.AddIngredient(ItemID.FallenStar, 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("StarTrail"));
				recipe.AddRecipe();
				// Hit Scanner
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ItemID.MeteoriteBar, 5);
				recipe.AddIngredient(thorium.ItemType("AlienTech"));
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("HitScanner"));
				recipe.AddRecipe();
				// Particle Whip
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ItemID.FallenStar, 5);
				recipe.AddIngredient(thorium.ItemType("AlienTech"));
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("GaussSpark"));
				recipe.AddRecipe();
				// Distress Caller
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ItemID.MeteoriteBar, 5);
				recipe.AddIngredient(thorium.ItemType("AlienTech"));
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("DistressCaller"));
				recipe.AddRecipe();
				// Gauss Flinger
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ItemID.FallenStar, 5);
				recipe.AddIngredient(thorium.ItemType("AlienTech"));
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("GaussKnife"));
				recipe.AddRecipe();
				// Roboboe
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ItemID.MeteoriteBar, 5);
				recipe.AddIngredient(thorium.ItemType("AlienTech"));
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("Roboboe"));
				recipe.AddRecipe();
				// Star Rod
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ItemID.MeteoriteBar, 5);
				recipe.AddIngredient(ItemID.FallenStar, 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("StarRod"));
				recipe.AddRecipe();
			}
		}
	}
}