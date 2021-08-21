using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Vanilla.Bosses
{
	public class ShackledFlesh : ModItem
	{
		public override bool Autoload(ref string name)
		{
			return ModContent.GetInstance<MainConfig>().EnableBoss;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shackled Flesh");
			Tooltip.SetDefault("[c/909090:Boss Material:] [c/B84E71:Wall of Flesh]");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 10060;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 34;

			item.rare = ItemRarityID.LightRed;
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

			// Breaker Blade
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddRecipeGroup("MomlobBossMat:IronBars", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BreakerBlade);
			recipe.AddRecipe();
			// Clockwork Assault Rifle
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddRecipeGroup("MomlobBossMat:IronBars", 5);
			recipe.AddIngredient(ItemID.FlintlockPistol);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ClockworkAssaultRifle);
			recipe.AddRecipe();
			// Laser Rifle
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.MeteoriteBar, 5);
			recipe.AddIngredient(ItemID.SpaceGun);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.LaserRifle);
			recipe.AddRecipe();

			// Warrior Emblem
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
			recipe.AddRecipeGroup("MomlobBossMat:SilverBars", 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.WarriorEmblem);
			recipe.AddRecipe();
			// Ranger Emblem
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
			recipe.AddRecipeGroup("MomlobBossMat:SilverBars", 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.RangerEmblem);
			recipe.AddRecipe();
			// Sorcerer Emblem
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
			recipe.AddRecipeGroup("MomlobBossMat:SilverBars", 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.SorcererEmblem);
			recipe.AddRecipe();
			// Summoner Emblem
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
			recipe.AddRecipeGroup("MomlobBossMat:SilverBars", 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.SummonerEmblem);
			recipe.AddRecipe();
			if (thorium_x)
			{
				// Ninja Emblem
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 5);
				recipe.AddRecipeGroup("MomlobBossMat:SilverBars", 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("NinjaEmblem"));
				recipe.AddRecipe();
				// Bard Emblem
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 5);
				recipe.AddRecipeGroup("MomlobBossMat:SilverBars", 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("BardEmblem"));
				recipe.AddRecipe();
				// Cleric Emblem
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 5);
				recipe.AddRecipeGroup("MomlobBossMat:SilverBars", 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("ClericEmblem"));
				recipe.AddRecipe();
			}

			// Pwnhammer
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
			recipe.AddRecipeGroup("MomlobBossMat:GoldBars", 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Pwnhammer);
			recipe.AddRecipe();
		}
	}
}