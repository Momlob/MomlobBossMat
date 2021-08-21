using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Vanilla.Bosses
{
	public class GelidCrownshard : ModItem
	{
		public override bool Autoload(ref string name)
		{
			return ModContent.GetInstance<MainConfig>().EnableBoss;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gelid Crownshard");
			Tooltip.SetDefault("[c/909090:Boss Material:] [c/5481E0:King Slime]");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 10010;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 22;

			item.rare = ItemRarityID.Blue;
			item.maxStack = 999;
			item.value = 1000;
		}



		public override void AddRecipes()
		{
			// Configs & Mod Calls
			Mod bossPlus = ModLoader.GetMod("MomlobBossPlus");
			bool bossPlus_x = bossPlus != null;
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;

			// Solidifier
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
			recipe.AddRecipeGroup("MomlobBossMat:IronBars", 10);
			recipe.AddRecipeGroup("MomlobBossMat:CopperBars", 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Solidifier);
			recipe.AddRecipe();

			// Ninja Armor
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
			recipe.AddIngredient(ItemID.Silk, 2);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.NinjaHood);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
			recipe.AddIngredient(ItemID.Silk, 2);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.NinjaShirt);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
			recipe.AddIngredient(ItemID.Silk, 2);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.NinjaPants);
			recipe.AddRecipe();

			if (bossPlus_x)
			{
				// Grimy Flail
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:SilverBars", 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(bossPlus.ItemType("GrimyFlail_Item"));
				recipe.AddRecipe();
				// Torcher
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ItemID.Torch, 10);
				recipe.AddRecipeGroup("MomlobBossMat:IronBars", 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(bossPlus.ItemType("Torcher_Item"));
				recipe.AddRecipe();
				// Splatter Bolt
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ItemID.FallenStar, 5);
				recipe.AddIngredient(ItemID.Book);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(bossPlus.ItemType("SplatterBolt_Item"));
				recipe.AddRecipe();
			}
			// Slime Staff
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddRecipeGroup("MomlobBossMat:Woods", 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.SlimeStaff);
			recipe.AddRecipe();
			if (bossPlus_x)
			{
				// Slip Star
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 5);
				recipe.AddIngredient(ItemID.FallenStar, 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(bossPlus.ItemType("SlipStar_Item"), 200);
				recipe.AddRecipe();
			}
			if (thorium_x)
			{
				// Shinobi Slicer
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:Woods", 10);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("ShinobiSlicer"), 200);
				recipe.AddRecipe();
				// Hidden Blade Scroll
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(thorium.ItemType("TechniqueBlankScroll"));
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("TechniqueHiddenBlade"));
				recipe.AddRecipe();
			}

			// Slime Hook
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.SlimeHook);
			recipe.AddRecipe();
			// Slimy Saddle
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 25);
			recipe.AddIngredient(ItemID.Leather, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.SlimySaddle);
			recipe.AddRecipe();

			// Slime Gun
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
			recipe.AddRecipeGroup("MomlobBossMat:IronBars", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.SlimeGun);
			recipe.AddRecipe();
		}
	}
}