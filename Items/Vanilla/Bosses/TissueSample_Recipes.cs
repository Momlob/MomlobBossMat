using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Vanilla.Bosses
{
	public class MBM_TissueSample_Item : GlobalItem
	{

        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.TissueSample && ModContent.GetInstance<MainConfig>().EnableBoss)
            {
                item.maxStack = 999;
                item.value = 400;
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (item.type == ItemID.TissueSample && ModContent.GetInstance<MainConfig>().EnableBoss)
            {
				tooltips.Insert(1, new TooltipLine(mod, "MomlobBossMat", "[c/909090:Boss Material:] [c/C87578:Brain of Cthulhu]"));
                tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
                ItemID.Sets.SortingPriorityMaterials[item.type] = 10031;
				return;
			}
		}



		public override void AddRecipes()
		{
			// Configs & Mod Calls
			Mod bossPlus = ModLoader.GetMod("MomlobBossPlus");
			bool bossPlus_x = bossPlus != null;
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;

            if (ModContent.GetInstance<MainConfig>().EnableBoss)
            {
                // Rotted Fork
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.TissueSample, 25);
                recipe.AddIngredient(ItemID.CrimtaneBar, 5);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.TheRottedFork);
                recipe.AddRecipe();
                // Undertaker
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.TissueSample, 25);
                recipe.AddRecipeGroup("MomlobBossMat:Woods", 25);
                recipe.AddIngredient(ItemID.CrimtaneBar, 5);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.TheUndertaker);
                recipe.AddRecipe();
                // Crimson Rod
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.TissueSample, 25);
                recipe.AddIngredient(ItemID.ViciousPowder, 25);
                recipe.AddIngredient(ItemID.RainCloud, 10);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.CrimsonRod);
                recipe.AddRecipe();
                if (bossPlus_x)
                {
                    // Creeper Staff
                    recipe = new ModRecipe(mod);
                    recipe.AddIngredient(ItemID.TissueSample, 25);
                    recipe.AddIngredient(ItemID.ViciousPowder, 25);
                    recipe.AddIngredient(ItemID.Vertebrae, 5);
                    recipe.AddTile(TileID.Anvils);
                    recipe.SetResult(bossPlus.ItemType("CreeperStaff_Item"));
                    recipe.AddRecipe();
                }
                if (thorium_x)
                {
                    // The Stalker
                    recipe = new ModRecipe(mod);
                    recipe.AddIngredient(ItemID.TissueSample, 25);
                    recipe.AddIngredient(thorium.ItemType("UnholyShards"), 10);
                    recipe.AddTile(TileID.Anvils);
                    recipe.SetResult(thorium.ItemType("TheStalker"));
                    recipe.AddRecipe();
                }

                // Panic Necklace
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.TissueSample, 25);
                recipe.AddIngredient(ItemID.Silk, 5);
                recipe.AddIngredient(ItemID.Vertebrae, 5);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.PanicNecklace);
                recipe.AddRecipe();
                // Crimson Heart
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.TissueSample, 25);
                recipe.AddIngredient(ItemID.FallenStar, 5);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.CrimsonHeart);
                recipe.AddRecipe();
                // Bone Rattle
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.TissueSample, 100);
                recipe.AddIngredient(ItemID.Shadewood, 25);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.BoneRattle);
                recipe.AddRecipe();
            }
        }
	}
}