using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Thorium
{
	public class PetrifiedEnergy : ModItem
	{
		public override bool Autoload(ref string name)
		{
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;
			return ModContent.GetInstance<MainConfig>().EnableBoss && thorium_x;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Petrified Energy");
			Tooltip.SetDefault("[c/909090:Boss Material:] [c/4F4B86:Granite Energy Storm]");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 10051;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
		}

		public override void SetDefaults()
		{
			item.width = 34;
			item.height = 30;

			item.rare = ItemRarityID.Orange;
			item.maxStack = 999;
			item.value = 2600;
		}



		public override void AddRecipes()
		{
			// Configs & Mod Calls
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;

			if (thorium_x)
			{
				// Energy Storm Partisan
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ItemID.Granite, 25);
				recipe.AddIngredient(thorium.ItemType("GraniteEnergyCore"), 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("EnergyStormPartisan"));
				recipe.AddRecipe();
				// Energy Storm Bolter
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ItemID.Granite, 25);
				recipe.AddIngredient(thorium.ItemType("GraniteEnergyCore"), 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("EnergyStormBolter"));
				recipe.AddRecipe();
				// Energy Projector
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ItemID.Granite, 25);
				recipe.AddIngredient(thorium.ItemType("GraniteEnergyCore"), 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("EnergyProjector"));
				recipe.AddRecipe();
				// Boulder Probe Staff
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ItemID.Granite, 25);
				recipe.AddIngredient(thorium.ItemType("GraniteEnergyCore"), 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("BoulderProbe"));
				recipe.AddRecipe();

				// Shock Absorber
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ItemID.Granite, 25);
				recipe.AddIngredient(thorium.ItemType("GraniteEnergyCore"), 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("ShockAbsorber"));
				recipe.AddRecipe();
			}
		}
	}
}