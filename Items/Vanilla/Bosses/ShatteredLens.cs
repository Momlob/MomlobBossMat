using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Vanilla.Bosses
{
	public class ShatteredLens : ModItem
	{
		public override bool Autoload(ref string name)
		{
			return ModContent.GetInstance<MainConfig>().EnableBoss;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shattered Lens");
			Tooltip.SetDefault("[c/909090:Boss Material:] [c/D7D7D7:Eye of Cthulhu]");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 10020;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 24;

			item.rare = ItemRarityID.Blue;
			item.maxStack = 999;
			item.value = 1500;
		}



		public override void AddRecipes()
		{
			// Configs & Mod Calls
			Mod bossPlus = ModLoader.GetMod("MomlobBossPlus");
			bool bossPlus_x = bossPlus != null;
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;

			// Corrupt Seeds
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GrassSeeds, 5);
			recipe.AddIngredient(ItemID.DemoniteOre);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(ItemID.CorruptSeeds, 5);
			recipe.AddRecipe();
			// Crimson Seeds
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GrassSeeds, 5);
			recipe.AddIngredient(ItemID.CrimtaneOre);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(ItemID.CrimsonSeeds, 5);
			recipe.AddRecipe();

			if (bossPlus_x)
			{
				// Eyepoker
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:EvilBars", 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(bossPlus.ItemType("Eyepoker_Item"));
				recipe.AddRecipe();
				// Seekers String
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:EvilBars", 5);
				recipe.AddRecipeGroup("MomlobBossMat:Lens", 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(bossPlus.ItemType("SeekersString_Item"));
				recipe.AddRecipe();
				// Crying Eye
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:EvilPowders", 25);
				recipe.AddRecipeGroup("MomlobBossMat:Lens", 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(bossPlus.ItemType("CryingEye_Item"));
				recipe.AddRecipe();
				// Evil Presence
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:Woods", 25);
				recipe.AddRecipeGroup("MomlobBossMat:GoldBars", 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(bossPlus.ItemType("EvilPresence_Item"));
				recipe.AddRecipe();
			}

			// Binoculars
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 25);
			recipe.AddRecipeGroup("MomlobBossMat:GoldBars", 10);
			recipe.AddIngredient(ItemID.Lens, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Binoculars);
			recipe.AddRecipe();
		}
	}
}