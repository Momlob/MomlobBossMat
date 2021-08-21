using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Vanilla.Events
{
	public class EtherianParchment : ModItem
	{
		public override bool Autoload(ref string name)
		{
			return ModContent.GetInstance<MainConfig>().EnableEvent;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Etherian Parchment");
			Tooltip.SetDefault("[c/909090:Event Material:] [c/D480C3:Dark Mage]");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 10032;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 22;

			item.rare = ItemRarityID.Orange;
			item.maxStack = 999;
			item.value = 2000;
		}



		public override void AddRecipes()
		{
			// Configs & Mod Calls
			Mod bossPlus = ModLoader.GetMod("MomlobBossPlus");
			bool bossPlus_x = bossPlus != null;
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;

			// War Table
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 2);
			recipe.AddRecipeGroup("MomlobBossMat:Woods", 25);
			recipe.AddRecipeGroup("MomlobBossMat:GoldBars", 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.WarTable);
			recipe.AddRecipe();
			// War Table Banner
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 2);
			recipe.AddIngredient(ItemID.Silk, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.WarTableBanner);
			recipe.AddRecipe();

			if (thorium_x)
			{
				// Dark Tome
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(thorium.ItemType("ArcaneDust"), 5);
				recipe.AddIngredient(ItemID.Book);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("DarkTome"));
				recipe.AddRecipe();
				// Taboo Wand
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:Woods", 25);
				recipe.AddIngredient(thorium.ItemType("UnholyShards"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("TabooWand"));
				recipe.AddRecipe();
				// Arcane Anelace
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 5);
				recipe.AddIngredient(thorium.ItemType("ArcaneDust"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("ArcaneAnelace"), 30);
				recipe.AddRecipe();
			}

			// Dragon Egg
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.DD2PetDragon);
			recipe.AddRecipe();
			// Gato Egg
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.DD2PetGato);
			recipe.AddRecipe();
		}
	}
}