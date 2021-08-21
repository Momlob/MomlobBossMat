using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Thorium
{
	public class AncientTriobol : ModItem
	{
		public override bool Autoload(ref string name)
		{
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;
			return ModContent.GetInstance<MainConfig>().EnableBoss && thorium_x;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Triobol");
			Tooltip.SetDefault("[c/909090:Boss Material:] [c/9C924E:Buried Champion]");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 10052;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 24;

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
				// Champions Swift Blade
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(thorium.ItemType("aDarksteelAlloy"), 5);
				recipe.AddIngredient(thorium.ItemType("BronzeFragments"), 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("ChampionBlade"));
				recipe.AddRecipe();
				// Champions Trifecta Shot
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ItemID.Marble, 25);
				recipe.AddIngredient(thorium.ItemType("BronzeFragments"), 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("HeroTripleBow"));
				recipe.AddRecipe();
				// Champions Bomber Staff
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(thorium.ItemType("SpiritDroplet"), 5);
				recipe.AddIngredient(thorium.ItemType("BronzeFragments"), 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("ChampionBomberStaff"));
				recipe.AddRecipe();
				// Champions God Hand
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ItemID.Leather, 5);
				recipe.AddIngredient(thorium.ItemType("BronzeFragments"), 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("ChampionsGodHand"));
				recipe.AddRecipe();

				// Champions Rebuttal
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(thorium.ItemType("DangerShard"), 5);
				recipe.AddIngredient(thorium.ItemType("BronzeFragments"), 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("ChampionsBarrier"));
				recipe.AddRecipe();
			}
		}
	}
}