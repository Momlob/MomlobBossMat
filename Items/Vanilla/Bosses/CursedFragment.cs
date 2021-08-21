using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Vanilla.Bosses
{
	public class CursedFragment : ModItem
	{
		public override bool Autoload(ref string name)
		{
			return ModContent.GetInstance<MainConfig>().EnableBoss;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cursed Fragment");
			Tooltip.SetDefault("[c/909090:Boss Material:] [c/CCCC9F:Skeletron]");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 10050;
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
		}

		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 30;

			item.rare = ItemRarityID.Green;
			item.maxStack = 999;
			item.value = 3000;
		}



		public override void AddRecipes()
		{
			// Configs & Mod Calls
			Mod bossPlus = ModLoader.GetMod("MomlobBossPlus");
			bool bossPlus_x = bossPlus != null;
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;

			// Bone Welder
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
			recipe.AddRecipeGroup("MomlobBossMat:IronBars", 5);
			recipe.AddIngredient(ItemID.Bone, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BoneWelder);
			recipe.AddRecipe();

			// Bone Sword
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.Bone, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BoneSword);
			recipe.AddRecipe();
			if (bossPlus_x)
			{
				// Osteitis
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 10);
				recipe.AddRecipeGroup("MomlobBossMat:Woods", 25);
				recipe.AddIngredient(ItemID.Obsidian, 25);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(bossPlus.ItemType("Osteitis_Item"));
				recipe.AddRecipe();
			}
			// Book of Skulls
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 10);
			recipe.AddIngredient(ItemID.FallenStar, 10);
			recipe.AddIngredient(ItemID.Book);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BookofSkulls);
			recipe.AddRecipe();

			// Seletrons Hand
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
			recipe.AddIngredient(ItemID.Chain, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.SkeletronHand);
			recipe.AddRecipe();
			if (bossPlus_x)
			{
				// Cursed Lantern
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 25);
				recipe.AddIngredient(ItemID.WaterCandle, 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(bossPlus.ItemType("CursedLantern_Item"));
				recipe.AddRecipe();
			}
			if (thorium_x)
			{
				// Overlord Reference
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 25);
				recipe.AddRecipeGroup("MomlobBossMat:GoldBars", 10);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(thorium.ItemType("GuildsStaff"));
				recipe.AddRecipe();
			}

			// Bone Pickaxe
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
			recipe.AddIngredient(ItemID.Bone, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BonePickaxe);
			recipe.AddRecipe();
			if (bossPlus_x)
			{
				// Skull Smasher
				recipe = new ModRecipe(mod);
				recipe.AddIngredient(this, 5);
				recipe.AddIngredient(ItemID.Bone, 25);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(bossPlus.ItemType("SkullSmasher_Item"));
				recipe.AddRecipe();
			}
			// Bone Wand
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(this, 5);
			recipe.AddRecipeGroup("MomlobBossMat:Woods", 25);
			recipe.AddIngredient(ItemID.Bone, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BoneWand);
			recipe.AddRecipe();
		}
	}
}