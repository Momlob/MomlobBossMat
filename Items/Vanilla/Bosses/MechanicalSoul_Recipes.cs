using System;
using System.Linq;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Vanilla.Bosses
{
	public class MBM_MechanicalSoul_Item : GlobalItem
	{

        public override void SetDefaults(Item item)
        {
            if ((item.type == ItemID.SoulofSight || item.type == ItemID.SoulofMight || item.type == ItemID.SoulofFright 
                || item.type == ItemID.HallowedBar) && ModContent.GetInstance<MainConfig>().EnableBoss)
            {
                item.maxStack = 999;
                item.value = 6000;
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.SoulofSight && ModContent.GetInstance<MainConfig>().EnableBoss)
            {
                tooltips.Insert(1, new TooltipLine(mod, "MomlobBossMat", "[c/909090:Boss Material:] [c/A0A0A0:The Twins]"));
                tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
                ItemID.Sets.SortingPriorityMaterials[item.type] = 10070;
                return;
            }
            if (item.type == ItemID.SoulofMight && ModContent.GetInstance<MainConfig>().EnableBoss)
            {
                tooltips.Insert(1, new TooltipLine(mod, "MomlobBossMat", "[c/909090:Boss Material:] [c/A0A0A0:The Destroyer]"));
                tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
                ItemID.Sets.SortingPriorityMaterials[item.type] = 10071;
                return;
            }
            if (item.type == ItemID.SoulofFright && ModContent.GetInstance<MainConfig>().EnableBoss)
            {
                tooltips.Insert(1, new TooltipLine(mod, "MomlobBossMat", "[c/909090:Boss Material:] [c/A0A0A0:Skeletron Prime]"));
                tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
                ItemID.Sets.SortingPriorityMaterials[item.type] = 10072;
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
                // I could propably adjust Recipes for the Souls, but honestly, it seems like a lot of Hassle for nothing,
                // not only due to wierd Recipes like Drax and Sensors, and inclusion of Hallowed Bars,
                // but could also screw with other Mods Recipes.
                // ...maybe ill do it ...someday.
            }
        }
	}
}