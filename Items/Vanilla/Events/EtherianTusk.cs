using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Vanilla.Events
{
	public class EtherianTusk : ModItem
	{
		public override bool Autoload(ref string name)
		{
			return ModContent.GetInstance<MainConfig>().EnableEvent;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Etherian Tusk");
			Tooltip.SetDefault("[c/909090:Event Material:] [c/83BBC3:Ogre]");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 10073;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 20;

			item.rare = ItemRarityID.Pink;
			item.maxStack = 999;
			item.value = 6000;
		}



		public override void AddRecipes()
		{
			// Configs & Mod Calls
			Mod bossPlus = ModLoader.GetMod("MomlobBossPlus");
			bool bossPlus_x = bossPlus != null;
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;

			// Brand of the Inferno
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddRecipeGroup("MomlobBossMat:EvilBars", 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.DD2SquireDemonSword);
			recipe.AddRecipe();
			// Sleepy Octopod
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.MonkStaffT1);
			recipe.AddRecipe();
			// Ghastly Glaive
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.MonkStaffT2);
			recipe.AddRecipe();
			// Phantom Phoenix
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.LivingFireBlock, 25);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.DD2PhoenixBow);
			recipe.AddRecipe();
			if (thorium_x)
			{
				// Ogre Snot Gun
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:IronBars", 5);
				recipe.AddIngredient(thorium.ItemType("CeruleanMorel"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("OgreSnotGun"));
				recipe.AddRecipe();
			}
			// Tome of Infinite Wisdom
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ModContent.ItemType<EtherianParchment>(), 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.BookStaff);
			recipe.AddRecipe();
			if (thorium_x)
			{
				// Hippocraticrossbow
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ItemID.HallowedBar, 5);
				recipe.AddIngredient(thorium.ItemType("HallowedCharm"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("Hippocraticrossbow"));
				recipe.AddRecipe();

				// Ogre Sandal
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ItemID.Leather, 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("OgreSandal"));
				recipe.AddRecipe();
				// Grog Blueprint
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 5);
				recipe.AddIngredient(ModContent.ItemType<EtherianParchment>(), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("GrogBlueprint"));
				recipe.AddRecipe();
			}
			// Squires Shield
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
			recipe.AddRecipeGroup("MomlobBossMat:CobaltBars", 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.SquireShield);
			recipe.AddRecipe();
			// Huntresses Buckler
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
			recipe.AddRecipeGroup("MomlobBossMat:MythrilBars", 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.HuntressBuckler);
			recipe.AddRecipe();
			// Apprentices Scarf
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
			recipe.AddIngredient(ItemID.Silk, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.ApprenticeScarf);
			recipe.AddRecipe();
			// Monks Belt
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
			recipe.AddIngredient(ItemID.Silk, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.MonkBelt);
			recipe.AddRecipe();

			// Creeper Egg
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 25);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.DD2PetGhost);
			recipe.AddRecipe();
		}
	}
}