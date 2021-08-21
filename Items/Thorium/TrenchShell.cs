using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Thorium
{
	public class TrenchShell : ModItem
	{
		public override bool Autoload(ref string name)
		{
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;
			return ModContent.GetInstance<MainConfig>().EnableBoss && thorium_x;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Trench Shell");
			Tooltip.SetDefault("[c/909090:Boss Material:] [c/395832:Abyssion]");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 10093;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
		}

		public override void SetDefaults()
		{
			item.width = 34;
			item.height = 30;

			item.rare = ItemRarityID.Yellow;
			item.maxStack = 999;
			item.value = 8000;
		}



		public override void AddRecipes()
		{
			// Configs & Mod Calls
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;

			if (thorium_x)
			{
				// Whispering Armor
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 5);
				recipe.AddIngredient(thorium.ItemType("DarkMatter"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("WhisperingHood"));
				recipe.AddRecipe();
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 5);
				recipe.AddIngredient(thorium.ItemType("DarkMatter"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("WhisperingTabard"));
				recipe.AddRecipe();
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 5);
				recipe.AddIngredient(thorium.ItemType("DarkMatter"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("WhisperingLeggings"));
				recipe.AddRecipe();

				// Mantis Shrimp Punch
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(thorium.ItemType("AbyssalChitin"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("MantisPunch"));
				recipe.AddRecipe();
				// Trench Splitter
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:BeholderBars", 5);
				recipe.AddIngredient(thorium.ItemType("AbyssalChitin"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("TrenchSpitter"));
				recipe.AddRecipe();
				// Old Gods Grasp
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(thorium.ItemType("DarkMatter"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("OldGodGrasp"));
				recipe.AddRecipe();
				// The Incubator
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(thorium.ItemType("AbyssalChitin"), 5);
				recipe.AddIngredient(thorium.ItemType("PharaohsBreath"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("TheIncubator"));
				recipe.AddRecipe();
				// Sirens Lyre
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(thorium.ItemType("IllumiteIngot"), 5);
				recipe.AddIngredient(thorium.ItemType("BloomWeave"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("SirensAllure"));
				recipe.AddRecipe();

				// R`lyehs Lost Rod
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 5);
				recipe.AddIngredient(thorium.ItemType("AbyssalChitin"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("RlyehLostRod"));
				recipe.AddRecipe();
			}
		}
	}
}