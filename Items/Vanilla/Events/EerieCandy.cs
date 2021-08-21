using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Vanilla.Events
{
	public class EerieCandy : ModItem
	{
		public override bool Autoload(ref string name)
		{
			return ModContent.GetInstance<MainConfig>().EnableEvent;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Eerie Candy");
			Tooltip.SetDefault("[c/909090:Event Material:] [c/F0941D:Pumpking]");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 10083;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 28;

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

			// Horsemans Blade
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.SpookyWood, 50);
			recipe.AddIngredient(ItemID.Pumpkin, 25);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.TheHorsemansBlade);
			recipe.AddRecipe();
			// Candy Corn Rifle
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddRecipeGroup("MomlobBossMat:AdamantiteBars", 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.CandyCornRifle);
			recipe.AddRecipe();
			// Jack O Launcher
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.JackOLanternLauncher);
			recipe.AddRecipe();
			// Bat Scepter
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.SpookyWood, 50);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.BatScepter);
			recipe.AddRecipe();
			// Raven Staff
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.SpookyWood, 50);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.RavenStaff);
			recipe.AddRecipe();
			if (thorium_x)
			{
				// Witchblade
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(thorium.ItemType("MoltenResidue"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("Witchblade"));
				recipe.AddRecipe();
				// Haunting Bass Drum
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ItemID.SpookyWood, 50);
				recipe.AddIngredient(thorium.ItemType("CursedCloth"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("HauntingBassDrum"));
				recipe.AddRecipe();
				// Snack Lantern
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ItemID.Pumpkin, 25);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("SnackLantern"));
				recipe.AddRecipe();
			}

			// Black Fairy Dust
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
			recipe.AddIngredient(ItemID.SpookyWood, 50);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.BlackFairyDust);
			recipe.AddRecipe();
			// Spider Egg
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 25);
			recipe.AddIngredient(ItemID.SpiderFang, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.SpiderEgg);
			recipe.AddRecipe();
			if(thorium_x)
			{
				// Flying Broom
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 25);
				recipe.AddIngredient(ItemID.SpookyWood, 50);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("FlyingBroom"));
				recipe.AddRecipe();
			}

			// Goodie Bag
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.GoodieBag, 10);
			recipe.AddRecipe();
		}
	}
}