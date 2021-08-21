using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Thorium
{
	public class VampiresWing : ModItem
	{
		public override bool Autoload(ref string name)
		{
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;
			return ModContent.GetInstance<MainConfig>().EnableBoss && thorium_x;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vampires Wing");
			Tooltip.SetDefault("[c/909090:Boss Material:] [c/33293E:Viscount]");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 10035;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 24;

			item.rare = ItemRarityID.Green;
			item.maxStack = 999;
			item.value = 2200;
		}



		public override void AddRecipes()
		{
			// Configs & Mod Calls
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;

			if (thorium_x)
			{
				// Bat Wing Yoyo
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(thorium.ItemType("DangerShard"), 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("BatWing"));
				recipe.AddRecipe();
				// Guano Gunner
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:SilverBars", 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("GuanoGunner"));
				recipe.AddRecipe();
				// Vampire Scepter
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:EvilPowders", 25);
				recipe.AddIngredient(thorium.ItemType("UnholyShards"), 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("VampireScepter"));
				recipe.AddRecipe();
				// Viscount Cane
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:EvilMaterials", 5);
				recipe.AddIngredient(thorium.ItemType("UnholyShards"), 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("ViscountCane"));
				recipe.AddRecipe();
				// Dracula Fang
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 5);
				recipe.AddIngredient(thorium.ItemType("Blood"), 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("DraculaFang"), 200);
				recipe.AddRecipe();
				// Sonar Cannon
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:EvilBars", 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("SonarCannon"));
				recipe.AddRecipe();
				// Bat Scythe
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:EvilBars", 5);
				recipe.AddIngredient(thorium.ItemType("UnholyShards"), 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("BatScythe"));
				recipe.AddRecipe();
			}
		}
	}
}