using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Thorium
{
	public class GaleTalon : ModItem
	{
		public override bool Autoload(ref string name)
		{
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;
			return ModContent.GetInstance<MainConfig>().EnableBoss && thorium_x;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gale Talon");
			Tooltip.SetDefault("[c/909090:Boss Material:] [c/EAD375:Grand Thunderbird]");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 10001;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
		}

		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 24;

			item.rare = ItemRarityID.Blue;
			item.maxStack = 999;
			item.value = 800;
		}



		public override void AddRecipes()
		{
			// Configs & Mod Calls
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;

			if (thorium_x)
			{
				// Thunder Talon
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(thorium.ItemType("SandStone"), 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("ThunderTalon"));
				recipe.AddRecipe();
				// Talon Burst
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(thorium.ItemType("BirdTalon"), 5);
				recipe.AddIngredient(thorium.ItemType("SandStone"), 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("TalonBurst"));
				recipe.AddRecipe();
				// Storm Hatchling Staff
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(thorium.ItemType("BirdTalon"), 5);
				recipe.AddIngredient(thorium.ItemType("SandStone"), 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("HatchlingStaff"));
				recipe.AddRecipe();
				// Didgeridoo
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:Woods", 10);
				recipe.AddIngredient(thorium.ItemType("SandStone"), 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("Didgeridoo"));
				recipe.AddRecipe();
			}
		}
	}
}