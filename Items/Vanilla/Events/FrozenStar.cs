using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Vanilla.Events
{
	public class FrozenStar : ModItem
	{
		public override bool Autoload(ref string name)
		{
			return ModContent.GetInstance<MainConfig>().EnableEvent;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Frozen Star");
			Tooltip.SetDefault("[c/909090:Event Material:] [c/BDF3F7:Ice Queen]");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 10085;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 34;

			item.rare = ItemRarityID.Yellow;
			item.maxStack = 999;
			item.value = 7500;
		}



		public override void AddRecipes()
		{
			// Configs & Mod Calls
			Mod bossPlus = ModLoader.GetMod("MomlobBossPlus");
			bool bossPlus_x = bossPlus != null;
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;

			// North Pole
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.IceBlock, 50);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.NorthPole);
			recipe.AddRecipe();
			// Snowman Cannon
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddRecipeGroup("MomlobBossMat:AdamantiteBars", 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.SnowmanCannon);
			recipe.AddRecipe();
			// Blizzard Staff
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.IceBlock, 50);
			recipe.AddIngredient(ItemID.SoulofFlight, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.BlizzardStaff);
			recipe.AddRecipe();
			if (thorium_x)
			{
				// Soft Serve Sunderer
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 5);
				recipe.AddIngredient(ItemID.SnowBlock, 10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("SoftServeSunderer"), 200);
				recipe.AddRecipe();
				// Cryotherapy
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(thorium.ItemType("Permafrost"), 25);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("Cryotherapy"));
				recipe.AddRecipe();
			}

			// Reindeer Bells
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 25);
			recipe.AddRecipeGroup("MomlobBossMat:GoldBars", 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.ReindeerBells);
			recipe.AddRecipe();
			// Grinch Wistle
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 25);
			recipe.AddRecipeGroup("MomlobBossMat:IronBars", 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.BabyGrinchMischiefWhistle);
			recipe.AddRecipe();

			// Presents
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.Present, 10);
			recipe.AddRecipe();
		}
	}
}