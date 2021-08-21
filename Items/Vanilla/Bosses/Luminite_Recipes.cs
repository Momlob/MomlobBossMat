using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Vanilla.Bosses
{
	public class MBM_Luminite_Item : GlobalItem
	{

        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.LunarOre && ModContent.GetInstance<MainConfig>().EnableBoss)
            {
                item.maxStack = 999;
                item.value = 2500;
            }
            if (item.type == ItemID.LunarBar && ModContent.GetInstance<MainConfig>().EnableBoss)
            {
                item.maxStack = 999;
                item.value = 10000;
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.LunarOre && ModContent.GetInstance<MainConfig>().EnableBoss)
            {
                tooltips.Insert(1, new TooltipLine(mod, "MomlobBossMat", "[c/909090:Boss Material:] [c/A7F5E3:Moon Lord]"));
                tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
                ItemID.Sets.SortingPriorityMaterials[item.type] = 10110;
                return;
            }
            if (item.type == ItemID.LunarBar && ModContent.GetInstance<MainConfig>().EnableBoss)
            {
                tooltips.Insert(1, new TooltipLine(mod, "MomlobBossMat", "[c/909090:Boss Material:] [c/A7F5E3:Moon Lord]"));
                tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
                ItemID.Sets.SortingPriorityMaterials[item.type] = 10111;
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
                // Meowmere
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.LunarBar, 20);
                recipe.AddIngredient(ItemID.HallowedBar, 10);
                recipe.AddIngredient(ItemID.PixieDust, 10);
                recipe.AddTile(TileID.LunarCraftingStation);
                recipe.SetResult(ItemID.Meowmere);
                recipe.AddRecipe();
                // Star Wrath
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.LunarBar, 20);
                recipe.AddIngredient(ItemID.MeteoriteBar, 10);
                recipe.AddIngredient(ItemID.Starfury);
                recipe.AddTile(TileID.LunarCraftingStation);
                recipe.SetResult(ItemID.StarWrath);
                recipe.AddRecipe();
                // Terrarian
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.LunarBar, 20);
                recipe.AddIngredient(ItemID.ChlorophyteBar, 10);
                recipe.AddTile(TileID.LunarCraftingStation);
                recipe.SetResult(ItemID.Terrarian);
                recipe.AddRecipe();
                // SDMG
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.LunarBar, 20);
                recipe.AddIngredient(ItemID.ShroomiteBar, 10);
                recipe.AddIngredient(ItemID.Megashark);
                recipe.AddTile(TileID.LunarCraftingStation);
                recipe.SetResult(ItemID.SDMG);
                recipe.AddRecipe();
                // Celebration
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.LunarBar, 20);
                recipe.AddTile(TileID.LunarCraftingStation);
                recipe.SetResult(ItemID.FireworksLauncher);
                recipe.AddRecipe();
                // Lunar Flare
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.LunarBar, 20);
                recipe.AddIngredient(ItemID.Ectoplasm, 10);
                recipe.AddIngredient(ItemID.SpellTome);
                recipe.AddTile(TileID.LunarCraftingStation);
                recipe.SetResult(ItemID.LunarFlareBook);
                recipe.AddRecipe();
                // Last Prism
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.LunarBar, 20);
                recipe.AddIngredient(ItemID.CrystalShard, 10);
                recipe.AddIngredient(ItemID.PixieDust, 10);
                recipe.AddTile(TileID.LunarCraftingStation);
                recipe.SetResult(ItemID.LastPrism);
                recipe.AddRecipe();
                // Rainbow Crystal Staff
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.LunarBar, 20);
                recipe.AddIngredient(ItemID.CrystalShard, 10);
                recipe.AddIngredient(ItemID.PixieDust, 10);
                recipe.AddTile(TileID.LunarCraftingStation);
                recipe.SetResult(ItemID.RainbowCrystalStaff);
                recipe.AddRecipe();
                // Lunar Portal Staff
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.LunarBar, 20);
                recipe.AddIngredient(ItemID.MartianConduitPlating, 20);
                recipe.AddTile(TileID.LunarCraftingStation);
                recipe.SetResult(ItemID.MoonlordTurretStaff);
                recipe.AddRecipe();
                if (thorium_x)
                {
                    // Angels End
                    recipe = new ModRecipe(mod);
                    recipe.AddIngredient(ItemID.LunarBar, 20);
                    recipe.AddIngredient(thorium.ItemType("StrangePlating"), 10);
                    recipe.AddIngredient(thorium.ItemType("DarkMatter"), 10);
                    recipe.AddTile(TileID.LunarCraftingStation);
                    recipe.SetResult(thorium.ItemType("AngelsEnd"));
                    recipe.AddRecipe();
                    // Sonic Amplifier
                    recipe = new ModRecipe(mod);
                    recipe.AddIngredient(ItemID.LunarBar, 20);
                    recipe.AddIngredient(ItemID.HallowedBar, 10);
                    recipe.AddIngredient(thorium.ItemType("HolyKnightsAlloy"), 10);
                    recipe.AddTile(TileID.LunarCraftingStation);
                    recipe.SetResult(thorium.ItemType("SonicAmplifier"));
                    recipe.AddRecipe();
                    // Life And Death
                    recipe = new ModRecipe(mod);
                    recipe.AddIngredient(ItemID.LunarBar, 20);
                    recipe.AddIngredient(thorium.ItemType("CursedCloth"), 10);
                    recipe.AddIngredient(thorium.ItemType("PurityShards"), 10);
                    recipe.AddTile(TileID.LunarCraftingStation);
                    recipe.SetResult(thorium.ItemType("LifeAndDeath"));
                    recipe.AddRecipe();
                }

                // Portal Gun
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.LunarBar, 5);
                recipe.AddTile(TileID.LunarCraftingStation);
                recipe.SetResult(ItemID.PortalGun);
                recipe.AddRecipe();
            }
        }
	}
}