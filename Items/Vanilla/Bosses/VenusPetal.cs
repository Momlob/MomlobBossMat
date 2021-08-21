using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Vanilla.Bosses
{
	public class VenusPetal : ModItem
	{
		public override bool Autoload(ref string name)
		{
			return ModContent.GetInstance<MainConfig>().EnableBoss;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Venus Petal");
			Tooltip.SetDefault("[c/909090:Boss Material:] [c/E180CE:Plantera]");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 10080;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 30;

			item.rare = ItemRarityID.Lime;
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

			// Seedler
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.Seedler);
			recipe.AddRecipe();
			// Flower Pow
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.Vine, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.FlowerPow);
			recipe.AddRecipe();
			// Venus Magnum
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddRecipeGroup("MomlobBossMat:AdamantiteBars", 10);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.VenusMagnum);
			recipe.AddRecipe();
			// Grenade Launcher
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddRecipeGroup("MomlobBossMat:AdamantiteBars", 10);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.GrenadeLauncher);
			recipe.AddRecipe();
			// Nettle Burst
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.Vine, 5);
			recipe.AddIngredient(ItemID.Stinger, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.NettleBurst);
			recipe.AddRecipe();
			// Leaf Blower
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 5);
			recipe.AddIngredient(ItemID.JungleSpores, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.LeafBlower);
			recipe.AddRecipe();
			// Wasp Gun
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.Stinger, 5);
			recipe.AddIngredient(ItemID.BeeGun);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.WaspGun);
			recipe.AddRecipe();
			// Pygmy Staff
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddRecipeGroup("MomlobBossMat:Woods", 25);
			recipe.AddIngredient(ItemID.Silk, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.PygmyStaff);
			recipe.AddRecipe();
			if (thorium_x)
			{
				// Bud Bomb
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 5);
				recipe.AddIngredient(ItemID.JungleSpores);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("BudBomb"), 200);
				recipe.AddRecipe();
				// Red Vuvuzela
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(thorium.ItemType("BloomWeave"), 10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("VuvuzelaRed"));
				recipe.AddRecipe();
				// Yellow Vuvuzela
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(thorium.ItemType("BloomWeave"), 10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("VuvuzelaYellow"));
				recipe.AddRecipe();
				// Green Vuvuzela
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(thorium.ItemType("BloomWeave"), 10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("VuvuzelaGreen"));
				recipe.AddRecipe();
				// Blue Vuvuzela
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(thorium.ItemType("BloomWeave"), 10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("VuvuzelaBlue"));
				recipe.AddRecipe();

				// Verdant Ornament
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(thorium.ItemType("BioMatter"), 10);
				recipe.AddIngredient(ItemID.Vine, 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("VerdantOrnament"));
				recipe.AddRecipe();
			}

			// Thorn Hook
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
			recipe.AddIngredient(ItemID.Vine, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.ThornHook);
			recipe.AddRecipe();
			// Seedling
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 25);
			recipe.AddIngredient(ItemID.JungleSpores, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.Seedling);
			recipe.AddRecipe();

			// The Axe
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 25);
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddIngredient(ItemID.BrokenHeroSword);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.TheAxe);
			recipe.AddRecipe();
		}
	}
}