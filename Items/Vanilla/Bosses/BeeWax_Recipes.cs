using System;
using System.Linq;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Vanilla.Bosses
{
	public class MBM_BeeWax_Item : GlobalItem
	{

        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.BeeWax && ModContent.GetInstance<MainConfig>().EnableBoss)
            {
                item.maxStack = 999;
                item.value = 1250;
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (item.type == ItemID.BeeWax && ModContent.GetInstance<MainConfig>().EnableBoss)
            {
				tooltips.Insert(1, new TooltipLine(mod, "MomlobBossMat", "[c/909090:Boss Material:] [c/EFAC10:Queen Bee]"));
                tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
                ItemID.Sets.SortingPriorityMaterials[item.type] = 10040;
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
                // Honey Dispenser
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BeeWax, 10);
                recipe.AddRecipeGroup("MomlobBossMat:IronBars", 10);
                recipe.AddIngredient(ItemID.Vine, 5);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.HoneyDispenser);
                recipe.AddRecipe();

                // Bee Armor
                RecipeFinder finder = new RecipeFinder();
                finder.SetResult(ItemID.BeeHeadgear);
                foreach (Recipe FoundRecipe in finder.SearchRecipes())
                {
                    RecipeEditor editor = new RecipeEditor(FoundRecipe);
                    editor.DeleteRecipe();
                }
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BeeWax, 5);
                recipe.AddIngredient(ItemID.Hive, 10);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.BeeHeadgear);
                recipe.AddRecipe();
                finder = new RecipeFinder();
                finder.SetResult(ItemID.BeeBreastplate);
                foreach (Recipe FoundRecipe in finder.SearchRecipes())
                {
                    RecipeEditor editor = new RecipeEditor(FoundRecipe);
                    editor.DeleteRecipe();
                }
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BeeWax, 5);
                recipe.AddIngredient(ItemID.Hive, 10);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.BeeBreastplate);
                recipe.AddRecipe();
                finder = new RecipeFinder();
                finder.SetResult(ItemID.BeeGreaves);
                foreach (Recipe FoundRecipe in finder.SearchRecipes())
                {
                    RecipeEditor editor = new RecipeEditor(FoundRecipe);
                    editor.DeleteRecipe();
                }
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BeeWax, 5);
                recipe.AddIngredient(ItemID.Hive, 10);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.BeeGreaves);
                recipe.AddRecipe();

                // Bee Keeper
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BeeWax, 10);
                recipe.AddRecipeGroup("MomlobBossMat:EvilBars", 5);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.BeeKeeper);
                recipe.AddRecipe();
                // The Bees Knees
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BeeWax, 10);
                recipe.AddIngredient(ItemID.Vine, 5);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.BeesKnees);
                recipe.AddRecipe();
                // Bee Gun
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BeeWax, 10);
                recipe.AddIngredient(ItemID.Stinger, 5);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.BeeGun);
                recipe.AddRecipe();
                // Hornet Staff
                finder = new RecipeFinder();
                finder.SetResult(ItemID.HornetStaff);
                foreach (Recipe FoundRecipe in finder.SearchRecipes())
                {
                    RecipeEditor editor = new RecipeEditor(FoundRecipe);
                    editor.DeleteRecipe();
                }
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BeeWax, 10);
                recipe.AddIngredient(ItemID.HoneyBlock, 25);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.HornetStaff);
                recipe.AddRecipe();
                if (bossPlus_x)
                {
                    // Hover Hive Staff
                    recipe = new ModRecipe(mod);
                    recipe.AddIngredient(ItemID.BeeWax, 10);
                    recipe.AddIngredient(ItemID.Hive, 25);
                    recipe.AddTile(TileID.Anvils);
                    recipe.SetResult(bossPlus.ItemType("HoverHiveStaff_Item"));
                    recipe.AddRecipe();
                }
                // Beenades
                finder = new RecipeFinder();
                finder.SetResult(ItemID.Beenade);
                foreach (Recipe FoundRecipe in finder.SearchRecipes())
                {
                    RecipeEditor editor = new RecipeEditor(FoundRecipe);
                    editor.DeleteRecipe();
                }
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BeeWax, 5);
                recipe.AddIngredient(ItemID.Grenade, 200);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.Beenade, 200);
                recipe.AddRecipe();
                // Honey Comb
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BeeWax, 10);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.HoneyComb);
                recipe.AddRecipe();
                if (thorium_x)
                {
                    // Sweet Heart
                    recipe = new ModRecipe(mod);
                    recipe.AddIngredient(ItemID.BeeWax, 10);
                    recipe.AddIngredient(thorium.ItemType("Petal"), 5);
                    recipe.AddTile(TileID.Anvils);
                    recipe.SetResult(thorium.ItemType("SweetHeart"));
                    recipe.AddRecipe();
                }

                // Honeyeyed Goggles
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BeeWax, 25);
                recipe.AddIngredient(ItemID.HoneyBlock, 25);
                recipe.AddIngredient(ItemID.Lens, 5);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.HoneyedGoggles);
                recipe.AddRecipe();
                // Nectar
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BeeWax, 25);
                recipe.AddIngredient(ItemID.HoneyBlock, 25);
                recipe.AddIngredient(ItemID.JungleRose);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.Nectar);
                recipe.AddRecipe();

                if (bossPlus_x)
                {
                    // Sweetened Hook
                    recipe = new ModRecipe(mod);
                    recipe.AddIngredient(ItemID.BeeWax, 5);
                    recipe.AddIngredient(ItemID.Vine, 5);
                    recipe.AddTile(TileID.Anvils);
                    recipe.SetResult(bossPlus.ItemType("SweetenedHook_Item"));
                    recipe.AddRecipe();
                }
                // Hive Wand
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BeeWax, 5);
                recipe.AddRecipeGroup("MomlobBossMat:Woods", 25);
                recipe.AddIngredient(ItemID.Hive, 25);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.HiveWand);
                recipe.AddRecipe();

                // Bee Vanity
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BeeWax, 1);
                recipe.AddIngredient(ItemID.Silk, 2);
                recipe.AddTile(TileID.Loom);
                recipe.SetResult(ItemID.BeeHat);
                recipe.AddRecipe();
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BeeWax, 1);
                recipe.AddIngredient(ItemID.Silk, 2);
                recipe.AddTile(TileID.Loom);
                recipe.SetResult(ItemID.BeeShirt);
                recipe.AddRecipe();
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BeeWax, 1);
                recipe.AddIngredient(ItemID.Silk, 2);
                recipe.AddTile(TileID.Loom);
                recipe.SetResult(ItemID.BeePants);
                recipe.AddRecipe();
            }
        }
	}
}