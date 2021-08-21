using System;
using System.Linq;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Vanilla.Bosses
{
    public class MBM_TCursedCloth_Item : GlobalItem
    {

        public override void SetDefaults(Item item)
        {
            Mod thorium = ModLoader.GetMod("ThoriumMod");
            bool thorium_x = (thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium && ModContent.GetInstance<MainConfig>().EnableBoss);

            if (thorium_x && item.type == thorium.ItemType("CursedCloth"))
            {
                item.maxStack = 999;
                item.value = 6500;
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            Mod thorium = ModLoader.GetMod("ThoriumMod");
            bool thorium_x = (thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium && ModContent.GetInstance<MainConfig>().EnableBoss);

            if (thorium_x && item.type == thorium.ItemType("CursedCloth"))
            {
                tooltips.Insert(1, new TooltipLine(mod, "MomlobBossMat", "[c/909090:Boss Material:] [c/880F04:The Lich]"));
                tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
                ItemID.Sets.SortingPriorityMaterials[item.type] = 10075;
                return;
            }
        }



        public override void AddRecipes()
        {
            // Configs & Mod Calls
            Mod thorium = ModLoader.GetMod("ThoriumMod");
            bool thorium_x = thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium;

            if (thorium_x && ModContent.GetInstance<MainConfig>().EnableBoss)
            {
                // Soul Render
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(thorium.ItemType("CursedCloth"), 10);
                recipe.AddRecipeGroup("MomlobBossMat:BeholderBars", 5);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(thorium.ItemType("SoulRender"));
                recipe.AddRecipe();
                // Wither Staff
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(thorium.ItemType("CursedCloth"), 10);
                recipe.AddRecipeGroup("MomlobBossMat:BeholderBars", 5);
                recipe.AddIngredient(thorium.ItemType("SpiritDroplets"), 5);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(thorium.ItemType("WitherStaff"));
                recipe.AddRecipe();
                // Phantom Wand
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(thorium.ItemType("CursedCloth"), 10);
                recipe.AddIngredient(thorium.ItemType("aDarksteelAlloy"), 5);
                recipe.AddIngredient(thorium.ItemType("PharaohsBreath"), 5);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(thorium.ItemType("CryptWand"));
                recipe.AddRecipe();
                // Soul Cleaver
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(thorium.ItemType("CursedCloth"), 10);
                recipe.AddRecipeGroup("MomlobBossMat:BeholderBars", 5);
                recipe.AddIngredient(ItemID.Bone, 25);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(thorium.ItemType("SoulCleaver"));
                recipe.AddRecipe();
                // Soul Bomb
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(thorium.ItemType("CursedCloth"), 5);
                recipe.AddIngredient(thorium.ItemType("PharaohsBreath"), 1);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(thorium.ItemType("SoulBomb"), 200);
                recipe.AddRecipe();
                // Cadavers Cornet
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(thorium.ItemType("CursedCloth"), 10);
                recipe.AddIngredient(thorium.ItemType("aDarksteelAlloy"), 5);
                recipe.AddIngredient(ItemID.Bone, 25);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(thorium.ItemType("CadaverCornet"));
                recipe.AddRecipe();

                // Spirit Band
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(thorium.ItemType("CursedCloth"), 10);
                recipe.AddIngredient(thorium.ItemType("SpiritDroplets"), 5);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(thorium.ItemType("SpiritBand"));
                recipe.AddRecipe();
                // The Lost Cross
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(thorium.ItemType("CursedCloth"), 10);
                recipe.AddIngredient(ItemID.HallowedBar, 5);
                recipe.AddIngredient(thorium.ItemType("LifeCell"), 5);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(thorium.ItemType("TheLostCross"));
                recipe.AddRecipe();
            }
        }
    }
}