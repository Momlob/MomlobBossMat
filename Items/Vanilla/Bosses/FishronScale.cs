using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Vanilla.Bosses
{
	public class FishronScale : ModItem
	{
		public override bool Autoload(ref string name)
		{
			return ModContent.GetInstance<MainConfig>().EnableBoss;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fishron Scales");
			Tooltip.SetDefault("[c/909090:Boss Material:] [c/20E090:Duke Fishron]");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 10100;
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

			// Flairon
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.Chain, 10);
			recipe.AddIngredient(ItemID.SharkFin, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.Flairon);
			recipe.AddRecipe();
			// Tsunami
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddRecipeGroup("MomlobBossMat:MythrilBars", 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.Tsunami);
			recipe.AddRecipe();
			// Razorblade Typhoon
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddRecipeGroup("MomlobBossMat:Corals", 5);
			recipe.AddIngredient(ItemID.SpellTome);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.RazorbladeTyphoon);
			recipe.AddRecipe();
			// Bubble Gun
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddRecipeGroup("MomlobBossMat:MythrilBars", 5);
			recipe.AddRecipeGroup("MomlobBossMat:Corals", 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.BubbleGun);
			recipe.AddRecipe();
			// Tempest Staff
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddRecipeGroup("MomlobBossMat:CobaltBars", 10);
			recipe.AddIngredient(ItemID.SharkFin, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.TempestStaff);
			recipe.AddRecipe();
			if (thorium_x)
			{
				// Brinefang
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(thorium.ItemType("AquaiteBar"), 5);
				recipe.AddRecipeGroup("MomlobBossMat:Corals", 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("Brinefang"));
				recipe.AddRecipe();
				// Dukes Regal Carnyx
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(thorium.ItemType("AquaiteBar"), 5);
				recipe.AddIngredient(thorium.ItemType("DarkMatter"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("DukesRegalCarnyx"));
				recipe.AddRecipe();
			}

			// Fishron Wings
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.SoulofFlight, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.FishronWings);
			recipe.AddRecipe();
		}
	}
}