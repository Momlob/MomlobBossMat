using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Vanilla.Bosses
{
	public class AncientGear : ModItem
	{
		public override bool Autoload(ref string name)
		{
			return ModContent.GetInstance<MainConfig>().EnableBoss;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Gear");
			Tooltip.SetDefault("[c/909090:Boss Material:] [c/964A10:Golem]");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 10090;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 28;

			item.rare = ItemRarityID.Lime;
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

			// Golems Fist
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.Chain, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.GolemFist);
			recipe.AddRecipe();
			// Possessed Hatchet
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.LunarTabletFragment, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.PossessedHatchet);
			recipe.AddRecipe();
			// Stynger
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.LunarTabletFragment, 5);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.Stynger);
			recipe.AddRecipe();
			// Earth Staff
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.StoneBlock, 50);
			recipe.AddIngredient(ItemID.LunarTabletFragment, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.StaffofEarth);
			recipe.AddRecipe();
			// Heat Ray
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.LivingFireBlock, 10);
			recipe.AddIngredient(ItemID.LunarTabletFragment, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.HeatRay);
			recipe.AddRecipe();

			// Eye of the Golem
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.LunarTabletFragment, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.EyeoftheGolem);
			recipe.AddRecipe();
			// Sun Stone
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.MeteoriteBar, 5);
			recipe.AddIngredient(ItemID.Silk, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.SunStone);
			recipe.AddRecipe();

			// Picksaw
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
			recipe.AddIngredient(ItemID.LunarTabletFragment, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.Picksaw);
			recipe.AddRecipe();
		}
	}
}