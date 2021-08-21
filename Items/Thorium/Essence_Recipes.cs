using System;
using System.Linq;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Config;

namespace MomlobBossMat.Items.Vanilla.Bosses
{
    public class MBM_TEssence_Item : GlobalItem
    {

        public override void SetDefaults(Item item)
        {
            Mod thorium = ModLoader.GetMod("ThoriumMod");
            bool thorium_x = (thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium && ModContent.GetInstance<MainConfig>().EnableBoss);

            if (thorium_x && (item.type == thorium.ItemType("InfernoEssence") || item.type == thorium.ItemType("OceanEssence")
                || item.type == thorium.ItemType("DeathEssence")))
            {
                item.maxStack = 999;
                item.value = 15000;
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            Mod thorium = ModLoader.GetMod("ThoriumMod");
            bool thorium_x = (thorium != null && ModContent.GetInstance<MainConfig>().EnableThorium && ModContent.GetInstance<MainConfig>().EnableBoss);

            if (thorium_x && item.type == thorium.ItemType("InfernoEssence"))
            {
                tooltips.Insert(1, new TooltipLine(mod, "MomlobBossMat", "[c/909090:Boss Material:] [c/E7BD35:Slag Fury]"));
                tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
                ItemID.Sets.SortingPriorityMaterials[item.type] = 10120;
                return;
            }
            if (thorium_x && item.type == thorium.ItemType("OceanEssence"))
            {
                tooltips.Insert(1, new TooltipLine(mod, "MomlobBossMat", "[c/909090:Boss Material:] [c/85CEF5:Aquaius]"));
                tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
                ItemID.Sets.SortingPriorityMaterials[item.type] = 10121;
                return;
            }
            if (thorium_x && item.type == thorium.ItemType("DeathEssence"))
            {
                tooltips.Insert(1, new TooltipLine(mod, "MomlobBossMat", "[c/909090:Boss Material:] [c/A8F245:Omnicide]"));
                tooltips.RemoveAll(l => l.Name.EndsWith("Material"));
                ItemID.Sets.SortingPriorityMaterials[item.type] = 10122;
                return;
            }
        }
    }
}