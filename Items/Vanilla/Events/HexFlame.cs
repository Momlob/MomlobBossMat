using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Vanilla.Events
{
	public class HexFlame : ModItem
	{
		public override bool Autoload(ref string name)
		{
			return ModContent.GetInstance<MainConfig>().EnableEvent;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hex Flame");
			Tooltip.SetDefault("[c/909090:Event Material:] [c/7CA05F:Goblin Army]");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 10062;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;

			item.rare = ItemRarityID.Pink;
			item.maxStack = 999;
			item.value = 5000;
		}



		public override void AddRecipes()
		{
			// Configs & Mod Calls
			Mod bossPlus = ModLoader.GetMod("MomlobBossPlus");
			bool bossPlus_x = bossPlus != null;
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;

			// Harpoon
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpikyBall, 25);
			recipe.AddRecipeGroup("MomlobBossMat:IronBars", 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Harpoon);
			recipe.AddRecipe();
			if (thorium_x)
			{
				// Yew Wood Blowpipe
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(thorium.ItemType("YewWood"), 25);
				recipe.AddIngredient(ItemID.TatteredCloth, 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("YewWoodBlowpipe"));
				recipe.AddRecipe();
				// Spike Bomb
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.SpikyBall, 200);
				recipe.AddIngredient(thorium.ItemType("SmoothCoal"), 2);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("SpikeBomb"), 200);
				recipe.AddRecipe();

				// Dark Gate
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(thorium.ItemType("YewWood"), 25);
				recipe.AddRecipeGroup("MomlobBossMat:SilverBars", 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("DarkGate"));
				recipe.AddRecipe();
			}

			// Shadowflame Knife
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddRecipeGroup("MomlobBossMat:IronBars", 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ShadowFlameKnife);
			recipe.AddRecipe();
			// Shadowflame Bow
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddRecipeGroup("MomlobBossMat:Woods", 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ShadowFlameBow);
			recipe.AddRecipe();
			// Shadowflame Hex Doll
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.TatteredCloth, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ShadowFlameHexDoll);
			recipe.AddRecipe();
			if (thorium_x)
			{
				// Shadow Tipped Javelin
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 5);
				recipe.AddRecipeGroup("MomlobBossMat:Woods", 25);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("ShadowTippedJavelin"), 200);
				recipe.AddRecipe();
				// Shadow Caltrop
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 5);
				recipe.AddRecipeGroup("MomlobBossMat:IronBars", 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("ShadowPurgeCaltrop"), 200);
				recipe.AddRecipe();
				// Summoner Warhorn
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:EvilBars", 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("SummonerWarhorn"));
				recipe.AddRecipe();
			}
		}
	}
}