using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Vanilla.Events
{
	public class FestiveOrnament : ModItem
	{
		public override bool Autoload(ref string name)
		{
			return ModContent.GetInstance<MainConfig>().EnableEvent;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Festive Ornament");
			Tooltip.SetDefault("[c/909090:Event Material:] [c/C0493D:Santa NK-1]");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 10084;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
		}

		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 24;

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

			// Christmas Tree Sword
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddRecipeGroup("MomlobBossMat:Woods", 25);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.ChristmasTreeSword);
			recipe.AddRecipe();
			// Chain Gun
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddRecipeGroup("MomlobBossMat:AdamantiteBars", 5);
			recipe.AddIngredient(ItemID.SoulofMight, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.ChainGun);
			recipe.AddRecipe();
			// Elf Melter
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddRecipeGroup("MomlobBossMat:AdamantiteBars", 5);
			recipe.AddIngredient(ItemID.Flamethrower);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.EldMelter);
			recipe.AddRecipe();
			// Razorpine
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddRecipeGroup("MomlobBossMat:Woods", 25);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.Razorpine);
			recipe.AddRecipe();
			if (thorium_x)
			{
				// Jingle Bells
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:GoldBars", 10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("JingleBells"));
				recipe.AddRecipe();
				// Christmas Cheer
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(thorium.ItemType("TitanBar"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("ChristmasCheer"));
				recipe.AddRecipe();
			}

			// Festive Wings
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.SoulofFlight, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.FestiveWings);
			recipe.AddRecipe();
			// Christmas Hook
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.ChristmasHook);
			recipe.AddRecipe();

			// Elf Vanity
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 1);
			recipe.AddIngredient(ItemID.Silk, 2);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.ElfHat);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 1);
			recipe.AddIngredient(ItemID.Silk, 2);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.ElfShirt);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 1);
			recipe.AddIngredient(ItemID.Silk, 2);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.ElfPants);
			recipe.AddRecipe();
		}
	}
}