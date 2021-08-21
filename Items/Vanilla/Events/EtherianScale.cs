using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Vanilla.Events
{
	public class EtherianScale : ModItem
	{
		public override bool Autoload(ref string name)
		{
			return ModContent.GetInstance<MainConfig>().EnableEvent;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Etherian Scale");
			Tooltip.SetDefault("[c/909090:Event Material:] [c/A33246:Betsy]");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 10099;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
		}

		public override void SetDefaults()
		{
			item.width = 34;
			item.height = 24;

			item.rare = ItemRarityID.Yellow;
			item.maxStack = 999;
			item.value = 8000;
		}



		public override void AddRecipes()
		{
			// Configs & Mod Calls
			Mod bossPlus = ModLoader.GetMod("MomlobBossPlus");
			bool bossPlus_x = bossPlus != null;
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;

			// Flying Dragon
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ModContent.ItemType<EtherianTusk>(), 5);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.DD2SquireBetsySword);
			recipe.AddRecipe();
			// Sky Dragons Fury
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ModContent.ItemType<EtherianParchment>(), 5);
			recipe.AddIngredient(ItemID.LivingFireBlock, 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.MonkStaffT3);
			recipe.AddRecipe();
			// Aerial Bane
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ModContent.ItemType<EtherianTusk>(), 5);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.DD2BetsyBow);
			recipe.AddRecipe();
			// Betsys Wrath
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ModContent.ItemType<EtherianParchment>(), 5);
			recipe.AddIngredient(ItemID.Ectoplasm, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.ApprenticeStaffT3);
			recipe.AddRecipe();
			if (thorium_x)
			{
				// Dragon Fang
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ModContent.ItemType<EtherianTusk>(), 5);
				recipe.AddIngredient(thorium.ItemType("GreenDragonScale"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("DragonFang"));
				recipe.AddRecipe();
				// Betsys Bellow
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ModContent.ItemType<EtherianParchment>(), 5);
				recipe.AddIngredient(thorium.ItemType("GreenDragonScale"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("BetsysBellow"));
				recipe.AddRecipe();
				// Valhallas Descent
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ModContent.ItemType<EtherianParchment>(), 5);
				recipe.AddIngredient(thorium.ItemType("Geode"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("ValhallasDescent"));
				recipe.AddRecipe();
				// Dragon Heart Wand
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ModContent.ItemType<EtherianTusk>(), 5);
				recipe.AddIngredient(thorium.ItemType("UnfathomableFlesh"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("DragonHeartWand"));
				recipe.AddRecipe();

				// Medium Rare Steak
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("MediumRareSteak"));
				recipe.AddRecipe();
			}

			// Betsy Wings
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
			recipe.AddIngredient(ItemID.SoulofFlight, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.BetsyWings);
			recipe.AddRecipe();
		}
	}
}