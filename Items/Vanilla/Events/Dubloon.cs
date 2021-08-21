using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Vanilla.Events
{
	public class Dubloon : ModItem
	{
		public override bool Autoload(ref string name)
		{
			return ModContent.GetInstance<MainConfig>().EnableEvent;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dubloon");
			Tooltip.SetDefault("[c/909090:Event Material:] [c/CCB548:Pirate Invasion]");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 10063;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 24;

			item.rare = ItemRarityID.LightRed;
			item.maxStack = 999;
			item.value = 10000;
		}



		public override void AddRecipes()
		{
			// Configs & Mod Calls
			Mod bossPlus = ModLoader.GetMod("MomlobBossPlus");
			bool bossPlus_x = bossPlus != null;
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;

			// Cutlass
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddRecipeGroup("MomlobBossMat:SilverBars", 10);
			recipe.AddRecipeGroup("MomlobBossMat:GoldBars", 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.Cutlass);
			recipe.AddRecipe();
			if (thorium_x)
			{
				// The Juggernaut
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:SilverBars", 10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("TheJuggernaut"));
				recipe.AddRecipe();
				// Ships Helm
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:Woods", 50);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("ShipsHelm"));
				recipe.AddRecipe();
			}
			// Coin Gun
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddRecipeGroup("MomlobBossMat:GoldBars", 5);
			recipe.AddIngredient(ItemID.PlatinumCoin, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.CoinGun);
			recipe.AddRecipe();
			if (thorium_x)
			{
				// Hand Cannon
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:IronBars", 5);
				recipe.AddIngredient(thorium.ItemType("SmoothCoal"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("HandCannon"));
				recipe.AddRecipe();
			}
			// Pirate Staff
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddRecipeGroup("MomlobBossMat:Woods", 25);
			recipe.AddRecipeGroup("MomlobBossMat:GoldBars", 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.PirateStaff);
			recipe.AddRecipe();
			if (thorium_x)
			{
				// Captains Poniard
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 5);
				recipe.AddRecipeGroup("MomlobBossMat:GoldBars", 2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("CaptainsPoniard"), 200);
				recipe.AddRecipe();
				// Concertina
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ItemID.Leather, 5);
				recipe.AddIngredient(thorium.ItemType("SmoothCoal"), 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("Concertina"));
				recipe.AddRecipe();
				// 24 Carat Tuba
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:GoldBars", 10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("Tuba"));
				recipe.AddRecipe();

				// Deadeye Patch
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddIngredient(ItemID.Leather, 5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("DeadEyePatch"));
				recipe.AddRecipe();
			}

			// Lucky Coin
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddRecipeGroup("MomlobBossMat:GoldBars", 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.LuckyCoin);
			recipe.AddRecipe();
			// Discount Card
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.DiscountCard);
			recipe.AddRecipe();
			// Gold Ring
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddRecipeGroup("MomlobBossMat:SilverBars", 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.GoldRing);
			recipe.AddRecipe();
			if (thorium_x)
			{
				// Greedy Magnet
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:GoldBars", 10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(thorium.ItemType("GreedyMagnet"));
				recipe.AddRecipe();
			}

			// Sailor Vanity
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 1);
			recipe.AddIngredient(ItemID.Silk, 2);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.SailorHat);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 1);
			recipe.AddIngredient(ItemID.Silk, 2);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.SailorShirt);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 1);
			recipe.AddIngredient(ItemID.Silk, 2);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.SailorPants);
			recipe.AddRecipe();
			// Buccaneer Vanity
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 1);
			recipe.AddIngredient(ItemID.Silk, 2);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.BuccaneerBandana);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 1);
			recipe.AddIngredient(ItemID.Silk, 2);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.BuccaneerShirt);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 1);
			recipe.AddIngredient(ItemID.Silk, 2);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.BuccaneerPants);
			recipe.AddRecipe();
			// Eye Patch
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 1);
			recipe.AddIngredient(ItemID.Silk, 2);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(ItemID.EyePatch);
			recipe.AddRecipe();

			// Gold Platforms
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.GoldenPlatform, 200);
			recipe.AddRecipe();
			// Gold Furniture
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenPlatform, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.GoldenWorkbench);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenPlatform, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.GoldenTable);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenPlatform, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.GoldenDresser);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenPlatform, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.GoldenPiano);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenPlatform, 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.GoldenBookcase);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenPlatform, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.GoldenChair);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenPlatform, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.GoldenSofa);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenPlatform, 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.GoldenBed);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenPlatform, 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.GoldenClock);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenPlatform, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.GoldenDoor);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenPlatform, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.GoldenToilet);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenPlatform, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.GoldenSink);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenPlatform, 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.GoldenBathtub);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenPlatform, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.GoldenCandle);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenPlatform, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.GoldenLamp);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenPlatform, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.GoldenCandelabra);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenPlatform, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.GoldenLantern);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenPlatform, 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.GoldChandelier);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenPlatform, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.GoldenChest);
			recipe.AddRecipe();
		}
	}

	public class MBM_Dubloon_Item : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (ModContent.GetInstance<MainConfig>().EnableEvent && 
				   (item.type == 1704 || item.type == 1705 || item.type == 1710 || item.type == 1716 || item.type == 1720
				 || item.type == 2133 || item.type == 2137 || item.type == 2143 || item.type == 2147 || item.type == 2151
				 || item.type == 2155 || item.type == 2238 || item.type == 2379 || item.type == 2389 || item.type == 2405
				 || item.type == 2663 || item.type == 2843 || item.type == 3885 || item.type == 3904 || item.type == 3910))
			{
				item.value = 500;
			}
		}
	}
}