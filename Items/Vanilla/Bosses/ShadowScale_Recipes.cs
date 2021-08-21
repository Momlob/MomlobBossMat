using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Vanilla.Bosses
{
	public class MBM_ShadowScale_Item : GlobalItem
	{

        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.ShadowScale && ModContent.GetInstance<MainConfig>().EnableBoss)
            {
                item.maxStack = 999;
                item.value = 400;
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			if (item.type == ItemID.ShadowScale && ModContent.GetInstance<MainConfig>().EnableBoss)
            {
                tooltips.Insert(1, new TooltipLine(mod, "MomlobBossMat", "[c/909090:Boss Material:] [c/927679:Eater of Worlds]"));
                tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
                ItemID.Sets.SortingPriorityMaterials[item.type] = 10030;
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
                // Ball of Hurt
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.ShadowScale, 25);
                recipe.AddIngredient(ItemID.DemoniteBar, 5);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.BallOHurt);
                recipe.AddRecipe();
                // Musket
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.ShadowScale, 25);
                recipe.AddRecipeGroup("MomlobBossMat:Woods", 25);
                recipe.AddRecipeGroup("MomlobBossMat:IronBars", 5);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.Musket);
                recipe.AddRecipe();
                // Vilethorn
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.ShadowScale, 25);
                recipe.AddIngredient(ItemID.VilePowder, 25);
                recipe.AddIngredient(ItemID.Vine, 5);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.Vilethorn);
                recipe.AddRecipe();
                if (thorium_x)
                {
                    // Eater of Pain
                    recipe = new ModRecipe(mod);
                    recipe.AddIngredient(ItemID.ShadowScale, 25);
                    recipe.AddIngredient(thorium.ItemType("UnholyShards"), 10);
                    recipe.AddTile(TileID.Anvils);
                    recipe.SetResult(thorium.ItemType("EaterOfPain"));
                    recipe.AddRecipe();
                }

                // Band of Starpower
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.ShadowScale, 25);
                recipe.AddIngredient(ItemID.Silk, 5);
                recipe.AddIngredient(ItemID.FallenStar, 5);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.BandofStarpower);
                recipe.AddRecipe();
                // Shadow Orb
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.ShadowScale, 25);
                recipe.AddIngredient(ItemID.FallenStar, 5);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.ShadowOrb);
                recipe.AddRecipe();
                // Eaters Bone
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.ShadowScale, 100);
                recipe.AddIngredient(ItemID.Ebonwood, 25);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(ItemID.EatersBone);
                recipe.AddRecipe();
            }
        }
	}
}