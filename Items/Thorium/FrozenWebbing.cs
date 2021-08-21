using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Thorium
{
	public class FrozenWebbing : ModItem
	{
		public override bool Autoload(ref string name)
		{
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;
			return ModContent.GetInstance<MainConfig>().EnableBoss && thorium_x;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Frozen Webbing");
			Tooltip.SetDefault("[c/909090:Boss Material:] [c/9CCEEB:Borean Strider]");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 10064;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 28;

			item.rare = ItemRarityID.Pink;
			item.maxStack = 999;
			item.value = 5200;
		}



		public override void AddRecipes()
		{
			// Configs & Mod Calls
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;

			if (thorium_x)
			{
				// Glacier
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:CobaltBars", 5);
				recipe.AddIngredient(thorium.ItemType("IcyShard"), 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("GlacierFang"));
				recipe.AddRecipe();
				// Freeze Ray
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:CobaltBars", 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("FreezeRay"));
				recipe.AddRecipe();
				// Glacial Sting
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(thorium.ItemType("IcyShard"), 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("GlacialSting"));
				recipe.AddRecipe();
				// Borean Fang Staff
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ItemID.BorealWood, 25);
				recipe.AddIngredient(thorium.ItemType("Geode"), 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("FrostFang"));
				recipe.AddRecipe();
				// The Cryo Fang
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ItemID.BorealWood, 25);
				recipe.AddIngredient(thorium.ItemType("IcyShard"), 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("CryoFang"));
				recipe.AddRecipe();
			}
		}
	}
}